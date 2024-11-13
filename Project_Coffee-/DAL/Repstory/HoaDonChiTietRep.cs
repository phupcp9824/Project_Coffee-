using DuAn1_Coffe.BLL.Service;
using DuAn1_Coffe.Models;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.DAL.Repstory
{
    internal class HoaDonChiTietRep
    {
        DB_QuanLy_CaffeeContext db = new DB_QuanLy_CaffeeContext();
        public List<HoaDonChiTiet> GetHoaDonchotiet()
        {
            return db.HoaDonChiTiets.ToList();
        }
        public void Update(HoaDonChiTiet hoadonct)
        {
            var existingHdct = db.HoaDonChiTiets.FirstOrDefault(x => x.IdSanPham == hoadonct.IdSanPham && x.IdHoaDon == hoadonct.IdHoaDon);

            if (existingHdct != null)
            {
                existingHdct.SoLuong += hoadonct.SoLuong;
                existingHdct.ThanhTien += hoadonct.ThanhTien;
            }
            else
            {
                db.HoaDonChiTiets.Add(hoadonct);
            }
            db.SaveChanges();
        }
        public HoaDonChiTiet GetHoaDonCtByMaSpctAndIdHoaDon(int maSpct, int idHoaDon)
        {
            // Truy vấn từ database để lấy chi tiết hóa đơn với mã sản phẩm và Id hóa đơn tương ứng
            return db.HoaDonChiTiets.FirstOrDefault(x => x.IdSanPham == maSpct && x.IdHoaDon == idHoaDon);
        }
        public bool Xoa(int id)
        {
            var XemayDelete = db.HoaDonChiTiets.FirstOrDefault(x => x.Id == id);
            if (XemayDelete == null)
            {
                return false;
            }
            db.HoaDonChiTiets.Remove(XemayDelete);
            db.SaveChanges();
            return true;
        }
      

        public bool UpdateGhiChuHDCT(int id, HoaDonChiTiet hdct)
        {
            var update = db.HoaDonChiTiets.FirstOrDefault(x => x.Id ==  id);
            update.Ghichu = hdct.Ghichu;
            db.HoaDonChiTiets.Update(update);
            db.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet>SeachIdHoadonchitiet(int id)
        {
            return db.HoaDonChiTiets.Where(x => x.IdHoaDon == id).ToList();
        }
        public bool UpdateSoLuongHDCT(int id, HoaDonChiTiet hdct)
        {
            var update = db.HoaDonChiTiets.First(x => x.Id == id);
            update.SoLuong = hdct.SoLuong;
            db.HoaDonChiTiets.Update(update);
            db.SaveChanges();
            return true;
        }
    }
}
