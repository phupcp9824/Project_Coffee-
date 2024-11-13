using DuAn1_Coffe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.DAL.Repstory
{
    internal class AccRepstory
    {
        DB_QuanLy_CaffeeContext db = new DB_QuanLy_CaffeeContext();
        public List<NhanVien> GetTaiKhoan()
        {
            return db.NhanViens.ToList();
        }
        public NhanVien TaiKhoan(string taikhoan, string matkhau)
        {
            return db.NhanViens.FirstOrDefault(u => u.TenTaiKhoan == taikhoan && u.MatKhau == matkhau);
        }
    }
}
