
using DuAn1_Coffe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.DAL.Repstory
{
    internal class HoaDonRep
    {
        DB_QuanLy_CaffeeContext db = new DB_QuanLy_CaffeeContext();
        public List<HoaDon> GetAllHoaDonstr()
        {
            return db.HoaDons.ToList();
        }

        public bool Them(HoaDon hoaDon)
        {
            db.HoaDons.Add(hoaDon);
            db.SaveChanges();
            return true;
        }
        public bool Sua(HoaDon hoaDon, int id)
        {
            var sua = db.HoaDons.FirstOrDefault(x => x.Id == id);
            sua.IdKhachHang = hoaDon.IdKhachHang;
            db.HoaDons.Update(sua);
            db.SaveChanges();
            return true;
        }
        public bool suatt(HoaDon hoaDon, int id)
        {
            var sua = db.HoaDons.FirstOrDefault(x => x.Id == id);
            sua.TrangThai = hoaDon.TrangThai;
            sua.GiamGia = hoaDon.GiamGia;
            sua.IdGiamGia = hoaDon.IdGiamGia;
            db.HoaDons.Update(sua);
            db.SaveChanges();
            return true;
        }

        public List<HoaDon> Loc(string trangthai)
        {
            return db.HoaDons.Where(x => x.TrangThai == trangthai).ToList();
        }

        public List<HoaDon> FindName(string ma)
        {
            return db.HoaDons.Where(x => x.MaHd.ToLower().Trim().Contains(ma.ToLower().Trim())).ToList();
        }

        
    }
}
