using System;
using System.Collections.Generic;

namespace DuAn1_Coffe.Models
{
    public partial class HoaDonChiTiet
    {
        public int Id { get; set; }
        public string MaHoaDon { get; set; } = null!;
        public string? TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public double Gia { get; set; }
        public double? ThanhTien { get; set; }
        public string? Ghichu { get; set; }
        public int? IdSanPham { get; set; }
        public int? IdHoaDon { get; set; }

        public virtual HoaDon? IdHoaDonNavigation { get; set; }
        public virtual SanPham? IdSanPhamNavigation { get; set; }
    }
}
