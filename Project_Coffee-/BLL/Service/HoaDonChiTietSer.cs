
using DuAn1_Coffe.DAL.Repstory;
using DuAn1_Coffe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.BLL.Service
{
    internal class HoaDonChiTietSer
    {
        HoaDonChiTietRep HoaDonchitietRepositori = new HoaDonChiTietRep();

        public List<HoaDonChiTiet> AllHoadonchitiet()
        {
            return HoaDonchitietRepositori.GetHoaDonchotiet();
        }
        public void Update(HoaDonChiTiet hdct)
        {
            HoaDonchitietRepositori.Update(hdct);
        }

        public string Xoa(int id)
        {
            if (HoaDonchitietRepositori.Xoa(id))
            {
                return "Xóa Thành công ";
            }
            else
            {
                return "Xóa thất bại";
            }
        }


        public string UpdateHDCT(int id, HoaDonChiTiet hdct)
        {
            if (HoaDonchitietRepositori.UpdateGhiChuHDCT(id, hdct))
            {
                return "Thanh cong";
            }
            return "That bai";
        }

        public List<HoaDonChiTiet> SeachIdHDCT(int id)
        {
            return HoaDonchitietRepositori.SeachIdHoadonchitiet(id);
        }

        public string UpdateSoLuong(int id , HoaDonChiTiet hoaDonChiTiet)
        {
            if(HoaDonchitietRepositori.UpdateSoLuongHDCT(id, hoaDonChiTiet))
            {
                return "Update thành công";
            }
            else
            {
                return "Update thất bại";
            }
        }
    }
}
