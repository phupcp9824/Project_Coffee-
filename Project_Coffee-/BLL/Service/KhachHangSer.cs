
using DuAn1_Coffe.DAL.Repstory;
using DuAn1_Coffe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.BLL.Service
{
    internal class KhachHangSer
    {
        KhachHangRep KhachHangRepositoti = new KhachHangRep();
        public List<KhachHang> AllKhachHang()
        {
            return KhachHangRepositoti.GetKhachHangs();
        }


        public string Them(KhachHang khachHang)
        {
            if (KhachHangRepositoti.GetThem(khachHang))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string Sua(int? id, KhachHang khachHang)
        {
            if (KhachHangRepositoti.GetSua(id, khachHang))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        public List<KhachHang> Timkiem(string name, string sdt, string ma)
        {
            return KhachHangRepositoti.FindName(name, sdt, ma);
        }
     
    }
}
