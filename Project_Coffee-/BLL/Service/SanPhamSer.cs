
using DuAn1_Coffe.DAL.Repstory;
using DuAn1_Coffe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.BLL.Service
{
    internal class SanPhamSer
    {
        SanPhamRep SanPhamRepositori = new SanPhamRep();

        public List<SanPham> Allsanpham()
        {
            return SanPhamRepositori.GetSanPham();
        }

        public string Them(SanPham sanPham)
        {
            if (SanPhamRepositori.GetThem(sanPham))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        public string Sua(int? id, SanPham sanPham)
        {
            if (SanPhamRepositori.GetSua(id, sanPham))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        public List<SanPham> Timkiem(string name, string ma)
        {
            return SanPhamRepositori.FindName(name,ma);
        }
        public SanPham Findid(int id)
        {
            return SanPhamRepositori.Findid(id);
        }

        public List<SanPham> Loc(string trangthai)
        {
            return SanPhamRepositori.Loc(trangthai);
        }
        public string UpdateSP(int id, SanPham sanPham)
        {
            SanPhamRepositori.UpdateSanPham(id, sanPham);
            return "Thêm thành công";
        }
        public string updateSL(int id, int sl)
        {
            SanPham upSPCT = SanPhamRepositori.findbyID(id);
            upSPCT.SoLuong = sl;
            if (SanPhamRepositori.UpdateSPCTRes(upSPCT))
            {
                return "Cap nhat so luong thanh cong";
            }
            else
            {
                return "Cap nhat so luong that bai";
            }
        }
    }
}
