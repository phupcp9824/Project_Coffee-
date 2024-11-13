
using DuAn1_Coffe.DAL.Repstory;
using DuAn1_Coffe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.BLL.Service
{
    internal class GiamGiaSer
    {
        GiamGiaRep  GiamGiaRepositori = new GiamGiaRep();
        public List<GiamGium> AllGiamGia()
        {
            return GiamGiaRepositori.Getgiamgia();
        }

        public string Them(GiamGium giamGium)
        {
            if (GiamGiaRepositori.GetThem(giamGium))
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }
        public string Sua(int? id, GiamGium giamGium)
        {
            if (GiamGiaRepositori.GetSua(id, giamGium))
            {
                return "sửa thành công";
            }
            else
            {
                return "sửa thất bại";
            }
        }

        public List<GiamGium> TimkiemMa(string ma)
        {
            return GiamGiaRepositori.FindMa(ma);
        }
        public double GetTiLeGiamGia(string maGiamGia)
        {
            // Gọi phương thức từ repository để lấy tỉ lệ giảm giá từ cơ sở dữ liệu
            return GiamGiaRepositori.GetTiLeGiamGia(maGiamGia);
        }
        public double GetGiamToiDa(string maGiamGia)
        {
            return GiamGiaRepositori.GetGiamToiDa(maGiamGia);
        }
        public void UpdateMaGiamGia(GiamGium giamgia)
        {
            GiamGiaRepositori.UpdateMaGiamGia(giamgia);
        }
    }
}
