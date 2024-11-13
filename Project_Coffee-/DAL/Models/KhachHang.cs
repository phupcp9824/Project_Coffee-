using System;
using System.Collections.Generic;

namespace DuAn1_Coffe.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int Id { get; set; }
        public string MaKh { get; set; } = null!;
        public string TenKh { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public string? Diachi { get; set; }
        public string? GioiTinh { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
