using DuAn1_Coffe.BLL.Service;
using DuAn1_Coffe.Models;
using DuAn1_Coffe.PRL.Forms;

namespace DuAn1_Coffe
{
    public partial class Form1 : Form
    {
        AccSer AccountService = new AccSer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taikhoan = txtuser.Text;
            string matkhau = txtpass.Text;
            NhanVien user;
            if (AccountService.Taikhoans(taikhoan, matkhau, out user))
            {
                if (user.VaiTro == "Quản lý")
                {
                    // M? form dành cho qu?n lý
                    Form_TrangChu trangchu = new Form_TrangChu();
                    trangchu.Show();
                }
                else
                {
                    // M? form dành cho nhân viên
                    Form_NhanVien trang_NhanVien = new Form_NhanVien();
                    trang_NhanVien.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void phide_Click_1(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '*')
            {
                peye.BringToFront();
                txtpass.PasswordChar = '\0';
            }
        }

        private void peye_Click_1(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '\0')
            {
                phide.BringToFront();
                txtpass.PasswordChar = '*';
            }
        }
    }
}
