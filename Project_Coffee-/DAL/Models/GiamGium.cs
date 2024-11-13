using System;
using System.Collections.Generic;

namespace DuAn1_Coffe.Models
{
    public partial class GiamGium
    {
        public GiamGium()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int Id { get; set; }
        public string MaGiamGia { get; set; } = null!;
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int TiLeGiam { get; set; }
        public int DonHangToiThieu { get; set; }
        public int GiamToiDa { get; set; }
        public int SoLuong { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
