using DuAn1_Coffe.BLL.Service;
using DuAn1_Coffe.Models;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_Coffe.PRL.Forms
{
   
    public partial class Form_ThongKe : Form
    {

        SanPhamSer SanPhamService = new SanPhamSer();
        HoaDonChiTietSer HoaDonChiTietSer = new HoaDonChiTietSer();
        KhachHangSer KhachHangSer = new KhachHangSer();
        HoaDonService HoaDonService = new HoaDonService();
        public Form_ThongKe()
        {
            InitializeComponent();
        }

        private void Form_ThongKe_Load(object sender, EventArgs e)
        {
            //LoadDoanhthuSp();
        }
     
        public void LoadDoanhthuSp()
        {
            int stt = 1;
            dgvdoanhthusp.ColumnCount = 7;
            dgvdoanhthusp.Rows.Clear();
            dgvdoanhthusp.Columns[0].Name = "Id";
            dgvdoanhthusp.Columns[1].Name = "Stt";
            dgvdoanhthusp.Columns[2].Name = "MaHD";
            dgvdoanhthusp.Columns[3].Name = "Tên SP";
            dgvdoanhthusp.Columns[4].Name = "Số Lượng";
            dgvdoanhthusp.Columns[5].Name = "Tổng Giá";
            dgvdoanhthusp.Columns[6].Name = "Ghi chú";
            dgvdoanhthusp.Columns[0].Visible = false;

            foreach (var item in HoaDonChiTietSer.AllHoadonchitiet())
            {
                var hd = HoaDonService.GetAllHoaDonrv().FirstOrDefault(x => x.Id == item.IdHoaDon);
                if (hd != null && hd.TrangThai == "Đã thanh toán")
                {
                    dgvdoanhthusp.Rows.Add(item.Id, stt++, item.MaHoaDon, item.TenSanPham, item.SoLuong, item.ThanhTien, item.Ghichu);
                }
            }
            lbdoanhthu.Text = HoaDonChiTietSer.AllHoadonchitiet().Sum(x => x.ThanhTien).ToString();
            lbtongdonhang.Text = HoaDonChiTietSer.AllHoadonchitiet().Count().ToString();
            lbspban.Text = HoaDonChiTietSer.AllHoadonchitiet().Sum(x => x.SoLuong).ToString();
        }
        private void btn_All_Click(object sender, EventArgs e)
        {
            LoadDoanhthuSp();
        }
        public void ThongKeSanPhamBanChay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            int index = 0;
            var thongkesanpham = (from hct in HoaDonChiTietSer.AllHoadonchitiet()
                                  join hd in HoaDonService.GetAllHoaDonrv() on hct.IdHoaDon equals hd.Id
                                  where hd.NgayMuaHang >= ngayBatDau && hd.NgayMuaHang <= ngayKetThuc
                                  group hct by hct.IdSanPham into g
                                  select new
                                  {
                                      Masanpham = g.Key,
                                      TenSP = g.Select(x => x.TenSanPham).FirstOrDefault(),
                                      GiaBan = g.Select(x => x.Gia).FirstOrDefault(),
                                      SoLuotMua = g.Sum(x => x.SoLuong),
                                      TongTien = g.Sum(x => x.SoLuong * x.Gia),
                                  }).OrderByDescending(x => x.SoLuotMua).ToList();
            dgvspbanchay.DataSource = thongkesanpham;
            dgvspbanchay.Columns[0].HeaderText = "Mã Sp";
            dgvspbanchay.Columns[1].HeaderText = "Tên SP";
            dgvspbanchay.Columns[2].HeaderText = "Giá bán";
            dgvspbanchay.Columns[3].HeaderText = "Số lượt mua";
            dgvspbanchay.Columns[4].HeaderText = "Tổng tiền";
            // Tạo một DataGridViewImageColumn

        }
        public void ThongKeSanPhamSapHetHang(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            try
            {
                int index = 0;
                var result = from sp in SanPhamService.Allsanpham()
                             where sp.SoLuong < 10
                             select new
                             {
                                 sp.Id,
                                 stt = ++index,
                                 sp.MaSp,
                                 sp.TenSanPham,
                                 sp.DonGia,
                                 sp.SoLuong,
                                 sp.TrangThai,
                                 sp.MoTa,
                                 sp.HinhAnh
                             };
                dgvsphethang.DataSource = result.ToList();
                dgvsphethang.Columns[0].Visible = false;
                dgvsphethang.Columns[1].HeaderText = "STT";
                dgvsphethang.Columns[2].HeaderText = "Mã Sp";
                dgvsphethang.Columns[3].HeaderText = "Tên sản phẩm";
                dgvsphethang.Columns[4].HeaderText = "Đơn giá";
                dgvsphethang.Columns[5].HeaderText = "Số lượng";
                dgvsphethang.Columns[6].HeaderText = "Trạng thái";
                dgvsphethang.Columns[7].HeaderText = "Mô tả";
                dgvsphethang.Columns[8].HeaderText = "Hình ảnh";
                DataGridViewImageColumn pic = new DataGridViewImageColumn();
                pic = (DataGridViewImageColumn)dgvsphethang.Columns[8];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void LoadDoanhthuSpthongke(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            int stt = 1;

            var result = from hdct in HoaDonChiTietSer.AllHoadonchitiet()
                         join hd in HoaDonService.GetAllHoaDonrv() on hdct.IdHoaDon equals hd.Id
                         join sp in SanPhamService.Allsanpham() on hdct.IdSanPham equals sp.Id
                         where hd.NgayMuaHang >= ngayBatDau && hd.NgayMuaHang <= ngayKetThuc && hd != null && hd.TrangThai == "Đã thanh toán"
                         select new
                         {
                             hdct.Id,
                             Stt = stt++,
                             hdct.MaHoaDon,
                             sp.TenSanPham,
                             hdct.SoLuong,
                             hdct.ThanhTien,
                             hdct.Ghichu
                         };
            dgvdoanhthusp.DataSource = result.ToList();
            dgvdoanhthusp.Columns[0].Visible = false;
            dgvdoanhthusp.Columns[1].HeaderText = "Stt";
            dgvdoanhthusp.Columns[2].HeaderText = "MaHD";
            dgvdoanhthusp.Columns[3].HeaderText = "Tên SP";
            dgvdoanhthusp.Columns[4].HeaderText = "Số Lượng";
            dgvdoanhthusp.Columns[5].HeaderText = "Tổng Giá";
            dgvdoanhthusp.Columns[6].HeaderText = "Ghi chú";

        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
           
            if (DateTime.ParseExact(dtptungay.Text.Trim(), "dd/MM/yyyy", null) > DateTime.ParseExact(dtpDenNgay.Text.Trim(), "dd/MM/yyyy", null))
            {
                MessageBox.Show("Ngày bắt đầu <= Ngày kết thúc");
            }
            else
            {
                DateTime ngayBatDau = dtptungay.Value.Date; // Lấy chỉ ngày, loại bỏ thông tin về giờ, phút và giây
                DateTime ngayKetThuc = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1); // Lấy ngày kết thúc và đặt giờ, phút và giây về 23:59:59
          /*      LoadDoanhthuSpthongke(ngayBatDau, ngayKetThuc);   */                                                         // Tổng doanh thu
                var tongDoanhThu = (from hct in HoaDonChiTietSer.AllHoadonchitiet()
                                    join hd in HoaDonService.GetAllHoaDonrv() on hct.IdHoaDon equals hd.Id
                                    where hd.NgayMuaHang >= ngayBatDau && hd.NgayMuaHang <= ngayKetThuc
                                    select hct.ThanhTien).Sum();
                //Tổng sản phẩm
                var tongsanpham = (from hct in HoaDonChiTietSer.AllHoadonchitiet()
                                   join hd in HoaDonService.GetAllHoaDonrv() on hct.IdHoaDon equals hd.Id
                                   where hd.NgayMuaHang >= ngayBatDau && hd.NgayMuaHang <= ngayKetThuc
                                   select hct.SoLuong).Sum();

                //Tổng số đơn hàng 
                var tongSoDonh = (from hd in HoaDonService.GetAllHoaDonrv()
                                  where hd.NgayMuaHang >= ngayBatDau && hd.NgayMuaHang <= ngayKetThuc
                                  select hd).Count();
       
                //Hiển thị lên lable
                lbdoanhthu.Text = tongDoanhThu.ToString();
                lbspban.Text = tongsanpham.ToString();
                lbtongdonhang.Text = tongSoDonh.ToString();
                ThongKeSanPhamBanChay(ngayBatDau, ngayKetThuc);
                ThongKeSanPhamSapHetHang(ngayBatDau, ngayKetThuc);
                
            }
        }
    }
}
