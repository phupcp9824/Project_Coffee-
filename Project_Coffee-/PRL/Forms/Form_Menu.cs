using AForge.Video.DirectShow;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using DuAn1_Coffe.BLL.Service;
using DuAn1_Coffe.Models;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;


//using static ClosedXML.Excel.XLPredefinedFormat;

namespace DuAn1_Coffe.PRL.Forms
{
    public partial class Form_Menu : Form
    {
        HoaDonService HoaDonService = new HoaDonService();
        KhachHangSer KhachHangSer = new KhachHangSer();
        SanPhamSer SanPhamSer = new SanPhamSer();
        GiamGiaSer GiamGiaSer = new GiamGiaSer();
        NhanVienSer NhanVienSer = new NhanVienSer();
        HoaDonChiTietSer HoaDonChiTietSer = new HoaDonChiTietSer();
        int stt = 0;
        private bool isDoubleClick = false;
        public Form_Menu()
        {
            InitializeComponent();
            LoadSanPham();
            LoadHD();
            LoadGiamGia();
            LoatNguoiTao();
        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            //lấy danh sách các thiết bị view đang được kết nối với máy tính
            camCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in camCollection)
            {
                cbo_Cam.Items.Add(item.Name);
            }
            cbo_Cam.SelectedIndex = 0;// chọn thiết bị có chỉ số đầu tiên trong danh sách
        }

        FilterInfoCollection camCollection; // danh sách các cam của máy
        VideoCaptureDevice videoCaptureDevice;
        bool scanning = false;

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            if (scanning)
            {
                ptb_Image.Image = (Bitmap)eventArgs.Frame.Clone();
            }
        }

        private void btn_batcam_Click(object sender, EventArgs e)
        {
            if (!scanning)
            {
                videoCaptureDevice = new VideoCaptureDevice(camCollection[cbo_Cam.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += new AForge.Video.NewFrameEventHandler(VideoCaptureDevice_NewFrame);
                videoCaptureDevice.Start();
                scanning = true;
                timer1.Start();
            }
        }

        private void btn_tatcam_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoCaptureDevice != null)
                {
                    if (videoCaptureDevice.IsRunning)
                    {
                        videoCaptureDevice.SignalToStop();
                        videoCaptureDevice.WaitForStop();
                        ptb_Image.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi dừng camera: " + ex.Message);
            }
        }

        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (scanning && ptb_Image.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Bitmap bitmap = new Bitmap(ptb_Image.Image);
                Result result = reader.Decode(bitmap);
                if (result != null)
                {
                    string decoded = result.Text.Trim();
                    MessageBox.Show("Mã sản phẩm:" + decoded);
                    //Tìm kiếm sản phẩm trong database
                    var sanPham = (from sp in SanPhamSer.Allsanpham()
                                   where string.Equals(sp.MaSp, decoded, StringComparison.OrdinalIgnoreCase)
                                   select new
                                   {
                                       Masp = sp.MaSp,
                                       TenSP = sp.TenSanPham,
                                       giaban = sp.DonGia,
                                       sl = sp.SoLuong,
                                       idsp = sp.Id
                                   }).FirstOrDefault();
                    if (sanPham != null)
                    {
                        string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập số lượng:", "Nhập số lượng", "1");
                        if (string.IsNullOrEmpty(input))
                        {
                            return;
                        }

                        int soLuong;
                        if (!int.TryParse(input, out soLuong) || soLuong <= 0)
                        {
                            MessageBox.Show("Số lượng không hợp lệ");
                            return;
                        }

                        int soluongkho = sanPham.sl;
                        if (soLuong > soluongkho)
                        {
                            MessageBox.Show("Số lượng không đủ trong kho");
                            return;
                        }
                        int IdSp = sanPham.idsp;
                        int tong = soluongkho - soLuong;
                        SanPham sanPham1 = new SanPham();
                        sanPham1.SoLuong = tong;

                        //Cập nhật số lượng mới cho sản phẩm
                        var success = SanPhamSer.UpdateSP(IdSp, sanPham1);
                        if (success != null)
                        {
                            //Nếu cập nhật thành công, cập nhật giá trị mới của số lượng
                            soluongkho = tong;
                        }

                        HoaDonChiTiet hdct = new HoaDonChiTiet();
                        hdct.MaHoaDon = GenerateHoaDonCtId();
                        hdct.TenSanPham = sanPham.TenSP;
                        hdct.SoLuong = soLuong;
                        hdct.Gia = sanPham.giaban;
                        hdct.ThanhTien = hdct.Gia * hdct.SoLuong;
                        hdct.IdHoaDon = int.Parse(txtidmax.Text);
                        hdct.IdSanPham = sanPham.idsp;

                        HoaDonChiTietSer.Update(hdct);

                        //Kiểm tra xem Idhoadon có bằng với txtidmax.Text hay không
                        int selectedHoaDonId = Convert.ToInt32(txtidmax.Text);
                        if (selectedHoaDonId == int.Parse(txtidmax.Text))
                        {
                            LoadHDCT(selectedHoaDonId);
                        }
                        LoadSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm không tồn tại");
                    }

                    timer1.Stop();
                    scanning = false; // Đặt biến scanning về false để ngăn quét tiếp
                }
            }
        }
        public string GenerateHoaDonCtId()
        {
            string mahdct;
            var allHoaDonct = HoaDonChiTietSer.AllHoadonchitiet();
            int count = allHoaDonct.Count + 1;
            mahdct = "HDCT" + count;
            while (allHoaDonct.Any(x => x.MaHoaDon == mahdct))
            {
                count++;
                mahdct = "HDCT" + count;
            }
            return mahdct; // Trả về mã hóa đơn chi tiết đã được tạo
        }

        // Load sản phẩm
        public void LoadSanPham()
        {
            int stt = 1;
            var result = from sp in SanPhamSer.Allsanpham()
                         select new
                         {
                             sp.Id,
                             stt = ++stt,
                             sp.MaSp,
                             sp.TenSanPham,
                             sp.DonGia,
                             sp.SoLuong,
                             sp.TrangThai,
                             sp.MoTa,
                             sp.HinhAnh
                         };
            dgvsanpham.DataSource = result.ToList();

            dgvsanpham.Columns[0].Visible = false;
            dgvsanpham.Columns[1].Name = "stt";
            dgvsanpham.Columns[2].Name = "MaSP";
            dgvsanpham.Columns[3].Name = "tên";
            dgvsanpham.Columns[4].Name = "Giá Bán";
            dgvsanpham.Columns[5].Name = "Số Lượng";
            dgvsanpham.Columns[6].Name = "Trang Thái";
            dgvsanpham.Columns[7].Name = "Mô Tả";
            dgvsanpham.Columns[8].Name = "Hình Ảnh";

            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvsanpham.Columns[8];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }
        public void TimkiemSP(string name, string ma)
        {
            int stt = 1;
            var result = from sp in SanPhamSer.Timkiem(name, ma)
                         select new
                         {
                             sp.Id,
                             stt = ++stt,
                             sp.MaSp,
                             sp.TenSanPham,
                             sp.DonGia,
                             sp.SoLuong,
                             sp.TrangThai,
                             sp.MoTa,
                             sp.HinhAnh
                         };
            dgvsanpham.DataSource = result.ToList();

            dgvsanpham.Columns[0].Visible = false;
            dgvsanpham.Columns[1].Name = "stt";
            dgvsanpham.Columns[2].Name = "MaSP";
            dgvsanpham.Columns[3].Name = "tên";
            dgvsanpham.Columns[4].Name = "Giá Bán";
            dgvsanpham.Columns[5].Name = "Số Lượng";
            dgvsanpham.Columns[6].Name = "Trang Thái";
            dgvsanpham.Columns[7].Name = "Mô Tả";
            dgvsanpham.Columns[8].Name = "Hình Ảnh";

            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvsanpham.Columns[8];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            TimkiemSP(txttimkiem.Text, txttimkiem.Text);
        }
        // Load hóa đơn
        private void LoadHD()
        {
            dgvdanhsachhoadon.Columns.Clear();
            dgvdanhsachhoadon.ColumnCount = 9;
            dgvdanhsachhoadon.Columns[0].Name = "Id";
            dgvdanhsachhoadon.Columns[1].Name = "Stt";
            dgvdanhsachhoadon.Columns[2].Name = "Mã HD";
            dgvdanhsachhoadon.Columns[3].Name = "Tên NV";
            dgvdanhsachhoadon.Columns[4].Name = "Tên KH";
            dgvdanhsachhoadon.Columns[5].Name = "Ngày Tạo";
            dgvdanhsachhoadon.Columns[6].Name = "Trạng Thái";
            dgvdanhsachhoadon.Columns[7].Name = "Mã KH";
            dgvdanhsachhoadon.Columns[8].Name = "Giảm Giá";

            dgvdanhsachhoadon.Columns[7].Visible = false;
            dgvdanhsachhoadon.Columns[0].Visible = false;
            dgvdanhsachhoadon.Columns[8].Visible = false;

            foreach (var item in HoaDonService.GetAllHoaDonrv())
            {
                var nv = NhanVienSer.AllNhanVien().FirstOrDefault(x => x.Id == item.IdNhanVien);
                var kh = KhachHangSer.AllKhachHang().FirstOrDefault(x => x.Id == item.IdKhachHang);
                if (nv != null && kh != null && item.TrangThai == "Chưa thanh toán")
                {
                    dgvdanhsachhoadon.Rows.Add(item.Id, stt++, item.MaHd, nv.TenNv, kh.TenKh, item.NgayMuaHang, item.TrangThai, kh.MaKh, item.GiamGia);
                }
            }
            var loadkh = KhachHangSer.AllKhachHang().ToList();
            cboid.DataSource = loadkh;
            cboid.ValueMember = "Id";
        }

        List<HoaDonChiTiet> hoaDonChiTiets = new List<HoaDonChiTiet>();
        public void LoadHDCT(int selectedHoaDonId)
        {
            int stt = 1;
            dgvhoadonct.Rows.Clear();
            dgvhoadonct.ColumnCount = 9;
            dgvhoadonct.Columns[0].Name = "Id";
            dgvhoadonct.Columns[1].Name = "Stt";
            dgvhoadonct.Columns[2].Name = "MaHDCT";
            dgvhoadonct.Columns[3].Name = "tên SP";
            dgvhoadonct.Columns[4].Name = "Sô Lượng";
            dgvhoadonct.Columns[5].Name = "Giá";
            dgvhoadonct.Columns[6].Name = "Thành Tiền";
            dgvhoadonct.Columns[7].Name = "IDHD";
            dgvhoadonct.Columns[8].Name = "IdSP";

            dgvhoadonct.Columns[0].Visible = false;
            dgvhoadonct.Columns[7].Visible = false;
            dgvhoadonct.Columns[8].Visible = false;

            var result = from hdct in HoaDonChiTietSer.AllHoadonchitiet()
                         join hd in HoaDonService.GetAllHoaDonrv() on hdct.IdHoaDon equals hd.Id
                         where hdct.IdHoaDon == selectedHoaDonId
                         select new
                         {
                             hdct.Id,
                             stt = stt++,
                             hdct.MaHoaDon,
                             hdct.TenSanPham,
                             hdct.SoLuong,
                             hdct.Gia,
                             hdct.ThanhTien,
                             hdct.IdHoaDon,
                             hdct.IdSanPham
                         };
            foreach (var item in result)
            {
                dgvhoadonct.Rows.Add(item.Id, stt++, item.MaHoaDon, item.TenSanPham, item.SoLuong, item.Gia, item.ThanhTien, item.IdHoaDon, item.IdSanPham);
            }
            TinhTongTien();
        }
        public void LoatNguoiTao()
        {
            cbbnhanvien.DataSource = NhanVienSer.AllNhanVien();
            cbbnhanvien.ValueMember = "Id";
            cbbnhanvien.DisplayMember = "TenNV";
        }
        private void cboGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGiamGia.SelectedItem != null && cboGiamGia.SelectedItem is KeyValuePair<string, string> selectedItem)
            {
                string maGiamGia = selectedItem.Key;
                double tongTien;
                if (double.TryParse(lbTongTien.Text, out tongTien))
                {
                    double tiLeGiamGia = GiamGiaSer.GetTiLeGiamGia(maGiamGia);
                    double giamToiDa = GiamGiaSer.GetGiamToiDa(maGiamGia); // Lấy giá trị GiamToiDa từ mã giảm giá

                    if (tiLeGiamGia > 0)
                    {
                        double tienGiam = tongTien * (tiLeGiamGia / 100.0);

                        // Nếu số tiền giảm vượt quá số tiền giảm tối đa, chỉ sử dụng số tiền giảm tối đa
                        if (tienGiam > giamToiDa)
                        {
                            tienGiam = giamToiDa;
                        }

                        double tongTienSauGiam = tongTien - tienGiam;

                        txttiengiam.Text = tienGiam.ToString();
                        lbThanhToan.Text = tongTienSauGiam.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi: Không thể chuyển đổi tổng tiền thành số.");
                }
            }
        }
        public void LoadGiamGia()
        {
            cboGiamGia.Items.Clear();
            foreach (var magiamgia in GiamGiaSer.AllGiamGia())
            {
                if (magiamgia.NgayKetThuc > DateTime.Now && magiamgia.DonHangToiThieu <= GetTongTien())
                {
                    string displayText = $"{magiamgia.TiLeGiam}% - {magiamgia.GiamToiDa}đ";
                    cboGiamGia.Items.Add(new KeyValuePair<string, string>(magiamgia.MaGiamGia, displayText));
                }
            }
        }
        //
        private double GetTongTien()
        {
            double tongTien;
            if (double.TryParse(lbTongTien.Text, out tongTien))
            {
                return tongTien;
            }
            return 0;
        }
        //
        private void TinhTongTien()
        {
            double tongTien = 0;
            foreach (DataGridViewRow row in dgvhoadonct.Rows)
            {
                double thanhTien;
                if (row.Cells[6].Value != null && double.TryParse(row.Cells[6].Value.ToString(), out thanhTien))
                {
                    tongTien += thanhTien;
                }
                lbTongTien.Text = tongTien.ToString();
                lbThanhToan.Text = tongTien.ToString();
                LoadGiamGia();
            }

        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
            // Kiểm tra số lượng hóa đơn chưa thanh toán
            var allHoaDon = HoaDonService.GetAllHoaDonrv();
            int unPaidCount = allHoaDon.Count(x => x.TrangThai == "Chưa thanh toán");

            if (unPaidCount >= 10)
            {
                MessageBox.Show("Đã đạt giới hạn 10 hóa đơn trống. Vui lòng thanh toán hoặc xóa các hóa đơn cũ trước khi tạo mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo hóa đơn mới nếu chưa đạt giới hạn
            HoaDon hd = new HoaDon();
            string maHD;
            int count = allHoaDon.Count + 1;
            maHD = "HĐ" + count;
            while (allHoaDon.Any(x => x.MaHd == maHD))
            {
                count++;
                maHD = "HĐ" + count;
            }

            hd.MaHd = maHD;
            NhanVien idnv = (NhanVien)cbbnhanvien.SelectedItem;
            hd.IdNhanVien = idnv.Id;
            hd.NguoiTao = idnv.TenNv;
            hd.IdKhachHang = 1;
            hd.NgayMuaHang = DateTime.Now;
            hd.TrangThai = "Chưa thanh toán";
            hd.GiamGia = "Chưa có";

            HoaDonService.Them(hd);
            LoadHD();
            txtMaKh.Text = "";
            txtTenKH.Text = "";
        }


        private void btn_chon_Click(object sender, EventArgs e)
        {
            Form_DanhSachKH form_DanhSachKH = new Form_DanhSachKH();
            form_DanhSachKH.ShowDialog();
        }
        int idwhenlick = new int();
        private void btn_thaydoi_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.IdKhachHang = int.Parse(cboid.SelectedValue.ToString());
            HoaDonService.Sua(hd, idwhenlick);
            LoadHD();
        }
        public void CapNhatThongTinKhachHang(string maKhachHang, string tenKhachHang, int id)
        {
            //
            cboid.Text = id.ToString();
            txtMaKh.Text = maKhachHang;
            txtTenKH.Text = tenKhachHang;

            int idhd = int.Parse(txtidmax.Text);
            foreach (DataGridViewRow row in dgvdanhsachhoadon.Rows)
            {
                string cellValue = row.Cells["Id"].Value.ToString();
                if (cellValue == idhd.ToString())
                {
                    row.Cells["Tên KH"].Value = tenKhachHang;
                    break;
                }
            }
        }

        private void dgvdanhsachhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdanhsachhoadon.CurrentRow != null && dgvdanhsachhoadon.CurrentRow.Cells[0].Value != null)
            {
                idwhenlick = int.Parse(dgvdanhsachhoadon.CurrentRow.Cells[0].Value.ToString());
                txtMaKh.Text = dgvdanhsachhoadon.CurrentRow.Cells[7].Value.ToString();
                txtTenKH.Text = dgvdanhsachhoadon.CurrentRow.Cells[4].Value.ToString();
                txtidmax.Text = dgvdanhsachhoadon.CurrentRow.Cells[0].Value.ToString();
            }
        }
        private void lbTienThua_TextChanged(object sender, EventArgs e)
        {
            double kt, tt;
            if (double.TryParse(txtTienKhachdua.Text, out kt) && double.TryParse(lbThanhToan.Text, out tt))
            {
                double tienthua = kt - tt;
                lbTienThua.Text = tienthua.ToString();
            }
        }
        private void txtTienKhachdua_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtTienKhachdua.Text, out double tienKhachDua))
            {
                double tongTienSauGiam = Convert.ToDouble(lbThanhToan.Text);
                double tienThua = Math.Max(tienKhachDua - tongTienSauGiam, 0);
                lbTienThua.Text = tienThua.ToString();
            }
            else
            {
                lbTienThua.Text = "0";
            }
        }
        private void dgvdanhsachhoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string idhd = dgvdanhsachhoadon.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtidmax.Text = idhd;

                // Kiểm tra xem Idhoadon có bằng với txtidmax.Text hay không
                int selectedHoaDonId = Convert.ToInt32(idhd);
                if (selectedHoaDonId == int.Parse(txtidmax.Text))
                {
                    LoadHDCT(selectedHoaDonId);
                }
            }
        }

        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvsanpham.Rows[e.RowIndex];
                string mahdct;
                var allHoaDonct = HoaDonChiTietSer.AllHoadonchitiet();
                int count = allHoaDonct.Count + 1;
                mahdct = "HDCT" + count;
                while (allHoaDonct.Any(x => x.MaHoaDon == mahdct))
                {
                    count++;
                    mahdct = "HDCT" + count;
                }
                string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập số lượng:", "Nhập số lượng");
                if (string.IsNullOrEmpty(input))
                {
                    return; // Kết thúc hàm
                }
                int soLuong;
                if (!int.TryParse(input, out soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0");
                    return;
                }
                int soluongkho = int.Parse(selectedRow.Cells[5].Value.ToString());
                if (soLuong > soluongkho)
                {
                    MessageBox.Show("Số lượng không đủ trong kho");
                    return;
                }
                int IdSp = int.Parse(selectedRow.Cells[0].Value.ToString());
                int tong = soluongkho - soLuong;
                SanPham sanPham = new SanPham();
                sanPham.SoLuong = tong;

                var success = SanPhamSer.UpdateSP(IdSp, sanPham);
                if (success != null)
                {
                    selectedRow.Cells[5].Value = tong;
                }

                string maSpct = selectedRow.Cells[2].Value.ToString();
                HoaDonChiTiet hdct = new HoaDonChiTiet();
                hdct.MaHoaDon = mahdct;
                hdct.TenSanPham = selectedRow.Cells[3].Value.ToString();
                hdct.SoLuong = soLuong;
                hdct.Gia = int.Parse(selectedRow.Cells[4].Value.ToString());
                hdct.ThanhTien = hdct.Gia * hdct.SoLuong;
                hdct.IdHoaDon = int.Parse(txtidmax.Text);
                hdct.IdSanPham = int.Parse(selectedRow.Cells[0].Value.ToString());

                HoaDonChiTietSer.Update(hdct);

                // Kiểm tra xem Idhoadon có bằng với txtidmax.Text hay không
                int selectedHoaDonId = Convert.ToInt32(txtidmax.Text);
                if (selectedHoaDonId == int.Parse(txtidmax.Text))
                {
                    LoadHDCT(selectedHoaDonId);
                }
                LoadSanPham();
            }
        }

        private void dgvhoadonct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvhoadonct.CurrentRow != null && dgvhoadonct.CurrentRow.Cells[0].Value != null)
            {
                txt_idHD.Text = dgvhoadonct.CurrentRow.Cells[0].Value.ToString();
                txtMas.Text = dgvhoadonct.CurrentRow.Cells[8].Value.ToString();
            }

        }

        private void dgvhoadonct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvhoadonct.Columns[6].Index)
            {
                TinhTongTien();
            }
            else if (e.ColumnIndex == dgvhoadonct.Columns[5].Index)
            {
                int sl = Convert.ToInt32(dgvhoadonct.Rows[e.RowIndex].Cells[5].Value);
                double gia = Convert.ToDouble(dgvhoadonct.Rows[e.RowIndex].Cells[6].Value);
                dgvhoadonct.Rows[e.RowIndex].Cells[7].Value = sl * gia;
                TinhTongTien();
            }
        }

        private void lbTienThua_Click(object sender, EventArgs e)
        {

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvhoadonct.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm sản phẩm vào hóa đơn trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                double tienkhachdua = double.Parse(txtTienKhachdua.Text);
                double tientt = double.Parse(lbThanhToan.Text);

                if (tienkhachdua < tientt)
                {
                    MessageBox.Show("Số tiền khách đưa không đủ.", "", MessageBoxButtons.OKCancel);
                    return;
                }

                HoaDon hd = new HoaDon();
                hd.TrangThai = "Đã thanh toán";

                // Kiểm tra nếu có mã giảm giá được chọn
                if (cboGiamGia.SelectedItem != null)
                {
                    KeyValuePair<string, string> resoud = (KeyValuePair<string, string>)cboGiamGia.SelectedItem;
                    string khuyenmai = resoud.Key;
                    var gg = GiamGiaSer.AllGiamGia().FirstOrDefault(x => x.MaGiamGia == khuyenmai);

                    if (gg != null)
                    {
                        hd.IdGiamGia = gg.Id;
                        hd.GiamGia = gg.MaGiamGia;

                        // Trừ số lượng mã giảm giá
                        if (gg.SoLuong > 0)
                        {
                            gg.SoLuong--;
                            GiamGiaSer.UpdateMaGiamGia(gg);
                        }
                    }
                }

                HoaDonService.suatt(hd, int.Parse(txtidmax.Text));

                // Cập nhật ghi chú trong hóa đơn chi tiết
                List<HoaDonChiTiet> listHDCT = HoaDonChiTietSer.SeachIdHDCT(int.Parse(txtidmax.Text));
                foreach (HoaDonChiTiet hdct in listHDCT)
                {
                    hdct.Ghichu = txtGhiChu.Text;
                    HoaDonChiTietSer.UpdateHDCT(hdct.Id, hdct);
                }

                MessageBox.Show("Thanh toán thành công");

                DialogResult dr = MessageBox.Show("Bạn có muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    XuatHoaDon();
                    MessageBox.Show("In hóa đơn thành công");
                }

                // Xóa các thông tin sau khi thanh toán
                hoaDonChiTiets.Clear();
                dgvhoadonct.Rows.Clear();
                LoadHD();
                lbTongTien.Text = "";
                cboGiamGia.Text = "";
                txttiengiam.Text = "";
                lbThanhToan.Text = "";
                txtTienKhachdua.Text = "";
                lbTienThua.Text = "";
                txtGhiChu.Text = "";
                txtMaKh.Text = "";
                txtTenKH.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btn_huydon_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.TrangThai = "Đã Hủy";
            HoaDonService.suatt(hd, int.Parse(txtidmax.Text));
            MessageBox.Show("Hủy thành công");
            LoadHD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu hóa đơn thành cônng");
            hoaDonChiTiets.Clear();
            dgvhoadonct.Rows.Clear();
            LoadHD();
            lbTongTien.Text = "";
            cboGiamGia.Text = "";
            txttiengiam.Text = "";
            lbThanhToan.Text = "";
            txtTienKhachdua.Text = "";
            lbTienThua.Text = "";
            txtGhiChu.Text = "";
            txtMaKh.Text = "";
            txtTenKH.Text = "";
        }

        private void btn_Xoasp_Click(object sender, EventArgs e)
        {
            int IdHD = int.Parse(txt_idHD.Text);
            var removedItem = HoaDonChiTietSer.AllHoadonchitiet().FirstOrDefault(x => x.Id == IdHD);
            int removedQuantity = removedItem != null ? removedItem.SoLuong : 0;
            var ctsp = SanPhamSer.Allsanpham().Find(x => x.Id == int.Parse(txtMas.Text));
            int slcon = ctsp.SoLuong;
            int newSL = slcon + removedQuantity;
            string mess = HoaDonChiTietSer.Xoa(IdHD);
            MessageBox.Show(mess, "Thông báo");
            SanPhamSer.updateSL(int.Parse(txtMas.Text), newSL);
            LoadSanPham();
            // Kiểm tra xem Idhoadon có bằng với txtidmax.Text hay không
            int selectedHoaDonId = Convert.ToInt32(txtidmax.Text);
            if (selectedHoaDonId == int.Parse(txtidmax.Text))
            {
                LoadHDCT(selectedHoaDonId);
            }
        }

        private void btn_Inhoadon_Click(object sender, EventArgs e)
        {
            ////Phú
            //if (dgvhoadonct.Rows.Count > 0)
            //{
            //    // Tạo một Workbook mới
            //    using (var workbook = new XLWorkbook())
            //    {
            //        // Tạo một WorkSheet mới
            //        var worksheet = workbook.Worksheets.Add("HoaDonChiTiet");

            //        // Thêm tiêu đề
            //        worksheet.Cell("A1").Value = "Hóa Đơn Bán Hàng";
            //        worksheet.Range("A1:H1").Merge().Style.Font.Bold = true;
            //        worksheet.Range("A1:H1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            //        // Copy header từ DataGridView sang Excel
            //        for (int i = 0; i < dgvhoadonct.Columns.Count; i++)
            //        {
            //            if (i != 0 && i != 7 && i != 8) // Kiểm tra nếu không phải là cột cần ẩn
            //            {
            //                worksheet.Cell(2, i).Value = dgvhoadonct.Columns[i].HeaderText;
            //            }
            //        }

            //        // Copy dữ liệu từ DataGridView sang Excel
            //        for (int i = 0; i < dgvhoadonct.Rows.Count; i++)
            //        {
            //            DataGridViewRow row = dgvhoadonct.Rows[i];
            //            for (int j = 0; j < dgvhoadonct.Columns.Count; j++)
            //            {
            //                if (j != 0 && j != 7 && j != 8)
            //                {
            //                    worksheet.Cell(i + 3, j).Value = row.Cells[j].Value?.ToString();
            //                }
            //            }
            //        }

            //        // Ẩn cột có id 
            //        worksheet.Column(1).Hide();
            //        worksheet.Column(8).Hide();
            //        worksheet.Column(9).Hide();

            //        // Thêm border vào cho đẹp zai
            //        var range = worksheet.Range(worksheet.FirstCellUsed(), worksheet.LastCellUsed());
            //        range.Style.Border.TopBorder = XLBorderStyleValues.Thin;
            //        range.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            //        range.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            //        range.Style.Border.RightBorder = XLBorderStyleValues.Thin;

            //        // chọn file đê lưu. nếu không chọn file nó sẽ lưu linh tinh
            //        int index = 1;
            //        string filePath = "E:\\fpt fpolytechnic\\học kỳ 4\\Block2\\Du_An_1_CaFe\\Excle File\\";
            //        string fileName = $"HoaDon{index}.xlsx";

            //        // Kiểm tra nếu tên file đã tồn tại thì tăng biến số
            //        while (File.Exists(Path.Combine(filePath, fileName)))
            //        {
            //            index++;
            //            fileName = $"HoaDon{index}.xlsx";
            //        }
            //        // tạo đường dẫn hoàn chỉnh
            //        string fileIN = Path.Combine(filePath, fileName);
            //        // Lưu file
            //        workbook.SaveAs(fileIN);

            //        MessageBox.Show($"Hóa đơn đã được In");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Danh sách sản phẩm trống");
            //}
        }
        private void XuatHoaDon()
        {
            ppdhd.Document = pdhd;
            ppdhd.ShowDialog();

        }

        private void pdhd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var hoadon = HoaDonService.GetAllHoaDonrv().FirstOrDefault(x => x.Id == idwhenlick);
            var kh = KhachHangSer.AllKhachHang().FirstOrDefault(k => k.Id == hoadon.IdKhachHang);
            var nv = NhanVienSer.AllNhanVien().FirstOrDefault(n => n.Id == hoadon.IdNhanVien);
            var HDCT = HoaDonChiTietSer.AllHoadonchitiet().FirstOrDefault(x => x.IdHoaDon == hoadon.Id);
            var GG = GiamGiaSer.AllGiamGia().FirstOrDefault(x => x.Id == idwhenlick);
            var w = pdhd.DefaultPageSettings.PaperSize.Width;

            // tên cửa hàng
            string text = "Cửa Hàng bán Cafe Felix";
            Font font = new Font("Times New Roman", 30, FontStyle.Bold);
            Brush brush = Brushes.Black;
            SizeF textSize = e.Graphics.MeasureString(text, font);

            int x = (int)((e.PageBounds.Width - textSize.Width) / 2);
            int y = 20; // Điểm y không thay đổi

            e.Graphics.DrawString(text, font, brush, new PointF(x, y));

            // Địa chỉ
            string address = "Địa chỉ: số 23 ngõ 20 Đ.Mỹ Đình, Hà Nội, Việt Nam";
            Font addressFont = new Font("Times New Roman", 18, FontStyle.Regular);
            Brush addressBrush = Brushes.Black;
            SizeF addressSize = e.Graphics.MeasureString(address, addressFont);

            int addressX = (int)((e.PageBounds.Width - addressSize.Width) / 2);
            int addressY = 80;

            e.Graphics.DrawString(address, addressFont, addressBrush, new PointF(addressX, addressY));

            // Số điện thoại
            string phone = "SĐT: 0989851319";
            Font PhoneFont = new Font("Times New Roman", 18, FontStyle.Regular);
            Brush PhoneBrush = Brushes.Black;
            SizeF PhoneSize = e.Graphics.MeasureString(address, addressFont);

            int PhoneX = (int)((e.PageBounds.Width - addressSize.Width) / 2 + 160);
            int PhoneY = 110;

            e.Graphics.DrawString(phone, PhoneFont, PhoneBrush, new PointF(PhoneX, PhoneY));

            // Tiêu đề
            string tieude = "Hóa Đơn Bán Cafe";
            Font tieudeFont = new Font("Times New Roman", 30, FontStyle.Bold);
            Brush tieudeBrush = Brushes.Black;
            SizeF tieudeSize = e.Graphics.MeasureString(tieude, tieudeFont);

            int tieudeX = (int)((e.PageBounds.Width - tieudeSize.Width) / 2);
            int tieudeY = 170;

            e.Graphics.DrawString(tieude, tieudeFont, tieudeBrush, new PointF(tieudeX, tieudeY));

            // Mã Hóa Đơn
            string hdon = "Mã Hóa Đơn: " + (hoadon?.MaHd ?? "");
            Font hdFont = new Font("Times New Roman", 15, FontStyle.Bold);
            Brush hdBrush = Brushes.Black;
            SizeF hdSize = e.Graphics.MeasureString(hdon, hdFont);

            int hdX = (int)((e.PageBounds.Width - hdSize.Width) / 2);
            int hdY = 225; // Điểm y giống với dòng tiêu đề

            e.Graphics.DrawString(hdon, hdFont, hdBrush, new PointF(hdX, hdY));

            // Thời gian
            string currentTime = DateTime.Now.ToString();
            Font timeFont = new Font("Times New Roman", 15, FontStyle.Bold);
            Brush timeBrush = Brushes.Black;
            SizeF timeSize = e.Graphics.MeasureString(currentTime, timeFont);

            int timeX = (int)((e.PageBounds.Width - timeSize.Width) / 2);
            int timeY = hdY + (int)hdSize.Height + 15; // Thêm khoảng cách 20 pixel giữa dòng mã hóa đơn và dòng thời gian

            e.Graphics.DrawString(currentTime, timeFont, timeBrush, new PointF(timeX, timeY));

            // Ngày Mua
            y += 20;
            e.Graphics.DrawString(string.Format("Ngày Mua : {0}", ((DateTime)hoadon.NgayMuaHang).ToString("dd/MM/yyyy HH:mm")),
                new System.Drawing.Font("Times New Roman", 15),
                System.Drawing.Brushes.Black,
                new System.Drawing.Point(40, y + 280));
            e.Graphics.DrawString(string.Format("Tên Khách Hàng : {0}", txtTenKH.Text),
                new System.Drawing.Font("Times New Roman", 15),
                System.Drawing.Brushes.Black,
                new System.Drawing.Point(40, y + 320));
            e.Graphics.DrawString(string.Format("Tên Nhân Viên : {0}", nv.TenNv),
                new System.Drawing.Font("Times New Roman", 15),
                System.Drawing.Brushes.Black,
                new System.Drawing.Point(40, y + 360));
            e.Graphics.DrawString(string.Format("SĐT : {0}", kh.Sdt),
               new System.Drawing.Font("Times New Roman", 15),
               System.Drawing.Brushes.Black,
               new System.Drawing.Point(40, y + 400));
            y += 50;

            int rowHeight = 30; // Chiều cao của mỗi hàng
            int columnWidth = w / 2; // Chiều rộng của mỗi cột

            // Vẽ ô và nội dung cho tiêu đề của từng cột
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(40, y + 400, columnWidth, rowHeight)); // Ô cho tiêu đề "STT"
            e.Graphics.DrawString(string.Format("STT"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(40, y + 400));

            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(100, y + 400, columnWidth, rowHeight)); // Ô cho tiêu đề "Tên Sản Phẩm"
            e.Graphics.DrawString(string.Format("Tên Sản Phẩm"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(100, y + 400));

            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(w / 2, y + 400, columnWidth, rowHeight)); // Ô cho tiêu đề "Số Lượng"
            e.Graphics.DrawString(string.Format("Số Lượng"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2, y + 400));

            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(w / 2 + 100, y + 400, columnWidth, rowHeight)); // Ô cho tiêu đề "Đơn Giá"
            e.Graphics.DrawString(string.Format("Đơn Giá"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 100, y + 400));

            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(w / 2 + 200, y + 400, columnWidth, rowHeight)); // Ô cho tiêu đề "Thành Tiền"
            e.Graphics.DrawString(string.Format("Thành Tiền"), new System.Drawing.Font("Times New Roman", 15, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 200, y + 400));

            int stt = 1;
            y += 30;

            foreach (var hct in HoaDonChiTietSer.AllHoadonchitiet().Where(c => c.IdHoaDon == idwhenlick))
            {
                var thanhtien = hct.SoLuong * hct.Gia;

                // Vẽ ô và nội dung cho từng ô trong bảng dữ liệu
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(40, y + 400, columnWidth, rowHeight)); // Ô cho dữ liệu của "STT"
                e.Graphics.DrawString(string.Format("{0}", stt++), new System.Drawing.Font("Times New Roman", 15, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(40, y + 400));

                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(100, y + 400, columnWidth, rowHeight)); // Ô cho dữ liệu của "Tên Sản Phẩm"
                e.Graphics.DrawString(string.Format("{0}", hct.TenSanPham), new System.Drawing.Font("Times New Roman", 15, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(100, y + 400));

                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(w / 2, y + 400, columnWidth, rowHeight)); // Ô cho dữ liệu của "Số Lượng"
                e.Graphics.DrawString(string.Format("{0}", hct.SoLuong), new System.Drawing.Font("Times New Roman", 15, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(w / 2, y + 400));

                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(w / 2 + 100, y + 400, columnWidth, rowHeight)); // Ô cho dữ liệu của "Đơn Giá"
                e.Graphics.DrawString(string.Format("{0}", hct.Gia), new System.Drawing.Font("Times New Roman", 15, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(w / 2 + 100, y + 400));

                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(w / 2 + 200, y + 400, columnWidth, rowHeight)); // Ô cho dữ liệu của "Thành Tiền"
                e.Graphics.DrawString(string.Format("{0}", thanhtien), new System.Drawing.Font("Times New Roman", 15, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(w / 2 + 200, y + 400));

                // Di chuyển đến hàng tiếp theo
                y += 30;

                // Tăng số thứ tự
                stt++;
            }

            // Tổng tiền 

            e.Graphics.DrawString(string.Format("Tổng tiền : {0}   VNĐ", lbTongTien.Text),
              new System.Drawing.Font("Times New Roman", 18, FontStyle.Bold),
              System.Drawing.Brushes.Black,
              new System.Drawing.Point(40, y + 410));


            //Giảm Giá


            e.Graphics.DrawString(string.Format("Giảm giá : {0}    VNĐ", txttiengiam.Text),
              new System.Drawing.Font("Times New Roman", 18, FontStyle.Bold),
              System.Drawing.Brushes.Black,
              new System.Drawing.Point(40, y + 450));

            // Thanh toán

            e.Graphics.DrawString(string.Format("Thanh toán : {0}    VNĐ", lbThanhToan.Text),
              new System.Drawing.Font("Times New Roman", 18, FontStyle.Bold),
              System.Drawing.Brushes.Black,
              new System.Drawing.Point(40, y + 490));

            //Tiền khách đưa
            e.Graphics.DrawString(string.Format("Tiền khách đưa : {0}    VNĐ", txtTienKhachdua.Text),
            new System.Drawing.Font("Times New Roman", 18, FontStyle.Bold),
            System.Drawing.Brushes.Black,
            new System.Drawing.Point(40, y + 530));

            //Tiền thừa
            e.Graphics.DrawString(string.Format("Tiền thừa : {0}    VNĐ", lbTienThua.Text),
            new System.Drawing.Font("Times New Roman", 18, FontStyle.Bold),
            System.Drawing.Brushes.Black,
            new System.Drawing.Point(40, y + 570));

            // cảm ơn
            string Thanhks = "Cảm ơn quý khách. Hẹn gặp lại.!";
            Font ThanhksFont = new Font("Times New Roman", 18, FontStyle.Regular);
            Brush ThanhksBrush = Brushes.Black;
            SizeF ThanhksSize = e.Graphics.MeasureString(address, addressFont);

            int ThanhksX = (int)((e.PageBounds.Width - addressSize.Width) / 2 + 300);
            int ThanhksY = 1000;

            e.Graphics.DrawString(Thanhks, ThanhksFont, ThanhksBrush, new PointF(ThanhksX, ThanhksY));


        }


        private void button2_Click(object sender, EventArgs e)
        {
            XuatHoaDon();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            XuatHoaDon();
        }

        private void lbTongTien_Click(object sender, EventArgs e)
        {

        }


        private void dgvhoadonct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow editedRow = dgvhoadonct.Rows[rowIndex];
            int idHD = int.Parse(txt_idHD.Text);
            int productId = int.Parse(editedRow.Cells[8].Value.ToString());
            int newQuantity = int.Parse(editedRow.Cells[4].Value.ToString());
            int idhoadonct = int.Parse(editedRow.Cells[0].Value.ToString());
            var product = SanPhamSer.Allsanpham().FirstOrDefault(x => x.Id == productId);
            if (product != null)
            {

                int old = product.SoLuong;
                int difference = newQuantity + old;
                SanPhamSer.updateSL(productId, difference);
                HoaDonChiTiet hdct = new HoaDonChiTiet();
                hdct.SoLuong = newQuantity;
                HoaDonChiTietSer.UpdateSoLuong(idhoadonct, hdct);
                var pro = SanPhamSer.Allsanpham().FirstOrDefault(x => x.Id == productId);
                if (product != null)
                {
                    double gia = product.DonGia;
                    double thanhTien = newQuantity * gia;
                    editedRow.Cells[6].Value = thanhTien;
                }

                double oldTotal = double.Parse(txtidmax.Text);
                double newTotal = oldTotal + (difference * product.DonGia);
            }
            LoadSanPham();
        }
    }
}





