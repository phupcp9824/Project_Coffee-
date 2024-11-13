using DuAn1_Coffe.BLL.Service;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form_QuanLyHoaDon : Form
    {
        HoaDonChiTietSer HoaDonchitietService = new HoaDonChiTietSer();
        NhanVienSer NhanVienService = new NhanVienSer();
        KhachHangSer KhachHangService = new KhachHangSer();
        SanPhamSer SanPhamService = new SanPhamSer();
        HoaDonService HoaDonService = new HoaDonService();
        int idwhenclick = new int();
        public Form_QuanLyHoaDon()
        {
            InitializeComponent();
            LoadHDD();
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadHDD();
        }

        public void LoadHDD()
        {
            int stt = 1;
            dgvhoadon.ColumnCount = 8;
            dgvhoadon.Rows.Clear();
            dgvhoadon.Columns[0].Name = "Id";
            dgvhoadon.Columns[1].Name = "Stt";
            dgvhoadon.Columns[2].Name = "MaHD";
            dgvhoadon.Columns[3].Name = "Ngày Mua Hàng";
            dgvhoadon.Columns[4].Name = "Nhân Viên";
            dgvhoadon.Columns[5].Name = "khách hàng";
            dgvhoadon.Columns[6].Name = "Trạng thái";
            dgvhoadon.Columns[7].Name = "MaKH";
            dgvhoadon.Columns[0].Visible = false;
            dgvhoadon.Columns[7].Visible = false;

            foreach (var item in HoaDonService.GetAllHoaDonrv())
            {
                var kh = KhachHangService.AllKhachHang().FirstOrDefault(x => x.Id == item.IdKhachHang);
                var nv = NhanVienService.AllNhanVien().FirstOrDefault(x => x.Id == item.IdNhanVien);
                dgvhoadon.Rows.Add(item.Id, stt++, item.MaHd, item.NgayMuaHang, nv.TenNv, kh.TenKh, item.TrangThai, kh.MaKh);
            }

        }

        private void btn_timNgay_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtpTu.Value.Date;
            DateTime ngayKetThuc = dtpTu.Value.Date.AddDays(1).AddSeconds(-1);
            LoadHD(ngayBatDau, ngayKetThuc);
        }

        public void LoadHD(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            int stt = 1;
            dgvhoadon.Rows.Clear();
            dgvhoadon.ColumnCount = 8;
            dgvhoadon.Columns[0].Name = "Id";
            dgvhoadon.Columns[1].Name = "Stt";
            dgvhoadon.Columns[2].Name = "MaHD";
            dgvhoadon.Columns[3].Name = "Ngày Tạo";
            dgvhoadon.Columns[4].Name = "Tên NV";
            dgvhoadon.Columns[5].Name = "Tên KH";
            dgvhoadon.Columns[6].Name = "Trạng thái";
            dgvhoadon.Columns[7].Name = "MaKH";
            dgvhoadon.Columns[0].Visible = false;
            dgvhoadon.Columns[7].Visible = false;

            var result = from hd in HoaDonService.GetAllHoaDonrv()
                         join kh in KhachHangService.AllKhachHang() on hd.IdKhachHang equals kh.Id
                         join nv in NhanVienService.AllNhanVien() on hd.IdNhanVien equals nv.Id
                         where hd.TrangThai == "Đã thanh toán" && hd.NgayMuaHang >= ngayBatDau && hd.NgayMuaHang <= ngayKetThuc
                         select
                         new
                         {
                             hd.Id,
                             Stt = stt++,
                             hd.MaHd,
                             hd.NgayMuaHang,
                             nv.TenNv,
                             kh.TenKh,
                             hd.TrangThai,
                             kh.MaKh
                         };
            foreach (var item in result)
            {
                dgvhoadon.Rows.Add(item.Id, stt++, item.MaHd, item.NgayMuaHang, item.TenNv, item.TenNv, item.TrangThai, item.MaKh);
            }
        }


        public void TimkiemMaHD(string ma)
        {
            int stt = 1;
            dgvhoadon.ColumnCount = 7;
            dgvhoadon.Rows.Clear();
            dgvhoadon.Columns[0].Name = "Id";
            dgvhoadon.Columns[1].Name = "Stt";
            dgvhoadon.Columns[2].Name = "MaHD";
            dgvhoadon.Columns[3].Name = "Ngày Mua Hàng";
            dgvhoadon.Columns[4].Name = "Nhân Viên";
            dgvhoadon.Columns[5].Name = "khách hàng";
            dgvhoadon.Columns[6].Name = "Trạng thái";
            dgvhoadon.Columns[0].Visible = false;
            foreach (var item in HoaDonService.TimkiemMaHD(ma))
            {
                var nv = NhanVienService.AllNhanVien().FirstOrDefault(x => x.Id == item.IdNhanVien);
                var kh = KhachHangService.AllKhachHang().FirstOrDefault(x => x.Id == item.IdKhachHang);
                dgvhoadon.Rows.Add(item.Id, stt++, item.MaHd, item.NgayMuaHang, nv.TenNv, kh.TenKh, item.TrangThai);
            }
        }
        private void dgvhoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rows = e.RowIndex;
            if (Rows >= 0)
            {
                int index = 0;
                var selectedHoaDonId = int.Parse(dgvhoadon.Rows[Rows].Cells[0].Value.ToString());
                var result = from hdct in HoaDonchitietService.AllHoadonchitiet()
                             join hd in HoaDonService.GetAllHoaDonrv() on hdct.IdHoaDon equals hd.Id
                             where hdct.IdHoaDon == selectedHoaDonId
                             select
                             new
                             {
                                 hdct.Id,
                                 Stt = ++index,
                                 hdct.MaHoaDon,
                                 hdct.TenSanPham,
                                 hdct.Gia,
                                 hdct.SoLuong,
                                 hdct.ThanhTien,
                                 hdct.IdHoaDon
                             };
                dgvhoadonchitiet.DataSource = result.ToList();

                dgvhoadonchitiet.Columns[0].HeaderText = "Id";
                dgvhoadonchitiet.Columns[1].HeaderText = "Stt";
                dgvhoadonchitiet.Columns[2].HeaderText = "MaHD";
                dgvhoadonchitiet.Columns[3].HeaderText = "TenSP";
                dgvhoadonchitiet.Columns[4].HeaderText = "Giá tiền";
                dgvhoadonchitiet.Columns[5].HeaderText = "Số Lượng";
                dgvhoadonchitiet.Columns[6].HeaderText = "Thành Tiền";
                dgvhoadonchitiet.Columns[7].HeaderText = "IdHD";
                dgvhoadonchitiet.Columns[0].Visible = false;
                dgvhoadonchitiet.Columns[7].Visible = false;
            }
        }
        public void Loc(string trangthai)
        {
            int stt = 1;
            dgvhoadon.ColumnCount = 8;
            dgvhoadon.Rows.Clear();
            dgvhoadon.Columns[0].Name = "Id";
            dgvhoadon.Columns[1].Name = "Stt";
            dgvhoadon.Columns[2].Name = "MaHD";
            dgvhoadon.Columns[3].Name = "Ngày Mua Hàng";
            dgvhoadon.Columns[4].Name = "Nhân Viên";
            dgvhoadon.Columns[5].Name = "khách hàng";
            dgvhoadon.Columns[6].Name = "Trạng thái";
            dgvhoadon.Columns[7].Name = "MaKH";
            dgvhoadon.Columns[0].Visible = false;
            dgvhoadon.Columns[7].Visible = false;

            foreach (var item in HoaDonService.Loc(trangthai))
            {
                var kh = KhachHangService.AllKhachHang().FirstOrDefault(x => x.Id == item.IdKhachHang);
                var nv = NhanVienService.AllNhanVien().FirstOrDefault(x => x.Id == item.IdNhanVien);
                dgvhoadon.Rows.Add(item.Id, stt++, item.MaHd, item.NgayMuaHang, nv.TenNv, kh.TenKh, item.TrangThai, kh.MaKh);
            }

        }
        private void cbolochoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbolochoadon.SelectedIndex == 0)
            {
                Loc("Đã Thanh Toán");
            }
            else if (cbolochoadon.SelectedIndex == 1)
            {
                Loc("Chưa Thanh Toán");
            }
            else
            {
                Loc("Đã Hủy");
            }
        }
        private void txttimkiemmahoadon_TextChanged(object sender, EventArgs e)
        {
            TimkiemMaHD(txttimkiemmahoadon.Text);
        }
        public void TimkiemNV(string name, string sdt, string ma)
        {
            int stt = 1;
            dgvhoadon.ColumnCount = 8;
            dgvhoadon.Rows.Clear();
            dgvhoadon.Columns[0].Name = "Id";
            dgvhoadon.Columns[1].Name = "Stt";
            dgvhoadon.Columns[2].Name = "MaHD";
            dgvhoadon.Columns[3].Name = "Ngày Mua Hàng";
            dgvhoadon.Columns[4].Name = "Nhân Viên";
            dgvhoadon.Columns[5].Name = "khách hàng";
            dgvhoadon.Columns[6].Name = "Trạng thái";
            dgvhoadon.Columns[7].Name = "MaKH";
            dgvhoadon.Columns[0].Visible = false;
            dgvhoadon.Columns[7].Visible = false;

            foreach (var item in NhanVienService.Timkiem(name, sdt, ma))
            {
                var hd = HoaDonService.GetAllHoaDonrv().FirstOrDefault(x => x.IdNhanVien == item.Id);
                var kh = KhachHangService.AllKhachHang().FirstOrDefault(x => x.Id == item.Id);
                dgvhoadon.Rows.Add(hd.Id, stt++, hd.MaHd, hd.NgayMuaHang, item.TenNv, kh.TenKh, item.TrangThai, kh.MaKh);
            }

        }
        private void txttimkiemnguoitao_TextChanged(object sender, EventArgs e)
        {
            TimkiemNV(txttimkiemnguoitao.Text, txttimkiemnguoitao.Text, txttimkiemnguoitao.Text);
        }

        private void Form_QuanLyHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
