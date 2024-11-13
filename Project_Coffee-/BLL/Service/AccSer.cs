
using DuAn1_Coffe.DAL.Repstory;
using DuAn1_Coffe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_Coffe.BLL.Service
{
    internal class AccSer
    {
        AccRepstory account = new AccRepstory();
        public bool Taikhoans(string taikhoan, string matkhau, out NhanVien user)
        {
            user = account.TaiKhoan(taikhoan, matkhau);
            return user != null;
        }
    }
}
