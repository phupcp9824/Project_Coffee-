
using DuAn1_Coffe.DAL.Repstory;
using DuAn1_Coffe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.BLL.Service
{
    internal class HoaDonService
    {
        HoaDonRep HoaDonRep = new HoaDonRep();
        public List<HoaDon> GetAllHoaDonrv()
        {
            return HoaDonRep.GetAllHoaDonstr();
        }
        public void Them(HoaDon hoadon)
        {
            HoaDonRep.Them(hoadon);
        }
        public string Sua(HoaDon hoadon, int id)
        {
            HoaDonRep.Sua(hoadon, id);
            return "Sửa thành công";
        }

        public string suatt(HoaDon hoadon, int id)
        {
            HoaDonRep.suatt(hoadon, id);
            return "Sửa thành công";
        }
        public List<HoaDon> Loc(string trangthai)
        {
            return HoaDonRep.Loc(trangthai);
        }

        public List<HoaDon> TimkiemMaHD(string ma)
        {
            return HoaDonRep.FindName(ma);
        }
    }
}
