using System;
using System.Collections.Generic;

namespace DuAn1_Coffe.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int Id { get; set; }
        public string MaNv { get; set; } = null!;
        public string TenNv { get; set; } = null!;
        public string? GioiTinh { get; set; }
        public string Sdt { get; set; } = null!;
        public string? DiaChi { get; set; }
        public string? Cccd { get; set; }
        public string? VaiTro { get; set; }
        public string TenTaiKhoan { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public DateTime? NgayVaoLam { get; set; }
        public string? TrangThai { get; set; }
        public byte[]? HinhAnh { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
