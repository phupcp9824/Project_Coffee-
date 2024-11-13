using System;
using System.Collections.Generic;

namespace DuAn1_Coffe.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public int Id { get; set; }
        public string MaHd { get; set; } = null!;
        public DateTime NgayMuaHang { get; set; }
        public string? TrangThai { get; set; }
        public string? NguoiTao { get; set; }
        public string? GiamGia { get; set; }
        public int? IdKhachHang { get; set; }
        public int? IdNhanVien { get; set; }
        public int? IdGiamGia { get; set; }

        public virtual GiamGium? IdGiamGiaNavigation { get; set; }
        public virtual KhachHang? IdKhachHangNavigation { get; set; }
        public virtual NhanVien? IdNhanVienNavigation { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
