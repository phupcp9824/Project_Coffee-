
using DuAn1_Coffe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.DAL.Repstory
{
    internal class KhachHangRep
    {
        DB_QuanLy_CaffeeContext db = new DB_QuanLy_CaffeeContext();
        public List<KhachHang> GetKhachHangs()
        {
            return db.KhachHangs.ToList();
        }

        public bool GetThem(KhachHang khachHang)
        {
            db.KhachHangs.Add(khachHang);
            db.SaveChanges();
            return true;
        }
        public bool GetSua(int? id, KhachHang khachHang)
        {
            var sua = db.KhachHangs.FirstOrDefault(x => x.Id == id);
            sua.MaKh = khachHang.MaKh;
            sua.TenKh = khachHang.TenKh;
            sua.Sdt = khachHang.Sdt;
            sua.Diachi = khachHang.Diachi;
            sua.GioiTinh = khachHang.GioiTinh;
            db.KhachHangs.Update(sua);
            db.SaveChanges();
            return true;
        }

        public List<KhachHang> FindName(string Name, string sdt, string ma)
        {
            return db.KhachHangs.Where(x => x.TenKh.ToLower().Contains(Name.ToLower()) || x.Sdt.Trim().Contains(sdt.Trim()) || x.MaKh.ToLower().Contains(ma.ToLower())).ToList();
        }
   
    }
}
