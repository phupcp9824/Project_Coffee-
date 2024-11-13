
using DuAn1_Coffe.DAL.Repstory;
using DuAn1_Coffe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.BLL.Service
{
    internal class NhanVienSer
    {
        NhanVienRep NhanVienRepositori = new NhanVienRep();
        public List<NhanVien> AllNhanVien()
        {
            return NhanVienRepositori.GetNhanVien();
        }

        public string Them(NhanVien nhanVien)
        {
            if (NhanVienRepositori.GetThem(nhanVien))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string Sua(int? id, NhanVien nhanVien)
        {
            if (NhanVienRepositori.GetSua(id, nhanVien))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        public List<NhanVien> Timkiem(string name, string sdt, string ma)
        {
            return NhanVienRepositori.FindName(name,sdt, ma);
        }
        public NhanVien Findid(int id)
        {
            return NhanVienRepositori.Findid(id);
        }
        public List<NhanVien> Loc(string Vaitro)
        {
            return NhanVienRepositori.Locc(Vaitro);
        }
    }
}
