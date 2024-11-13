using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DuAn1_Coffe.PRL.Forms
{
    public partial class Form_NhanVien : Form
    {
        public Form_NhanVien()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.panelchucang.Controls.Count > 0)
                this.panelchucang.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;


            f.Size = this.panelchucang.ClientSize;


            f.AutoScaleMode = AutoScaleMode.None;


            f.MinimumSize = f.Size;
            f.MaximumSize = f.Size;


            f.Dock = DockStyle.Fill;
            this.panelchucang.Controls.Add(f);
            this.panelchucang.Tag = f;
            f.Show();
        }
        private void hideSubMenu()
        {
            label4.Visible = false;
            pictureBox3.Visible = false;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            loadform(new Form_Menu());
            hideSubMenu();
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            loadform(new Form_QuanLyHoaDon());
            hideSubMenu();
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            loadform(new Form_QuanLyKH());
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_NhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
