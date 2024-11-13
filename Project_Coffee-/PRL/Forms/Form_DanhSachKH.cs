using DocumentFormat.OpenXml.Office2010.Drawing;
using DuAn1_Coffe.BLL.Service;
using DuAn1_Coffe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_Coffe.PRL.Forms
{
    public partial class Form_DanhSachKH : Form
    {

        public Form_DanhSachKH()
        {
            InitializeComponent();
        }

        int idwhenclick = new int();
        KhachHangSer KhachHangService = new KhachHangSer();
        private void Form_DanhSachKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dgvDSkhachhang.ColumnCount = 7;
            dgvDSkhachhang.Rows.Clear();
            dgvDSkhachhang.Columns[0].Name = "Id";
            dgvDSkhachhang.Columns[1].Name = "Stt";
            dgvDSkhachhang.Columns[2].Name = "Mã khách hàng";
            dgvDSkhachhang.Columns[3].Name = "Tên khách hàng";
            dgvDSkhachhang.Columns[4].Name = "Sđt";
            dgvDSkhachhang.Columns[5].Name = "Địa chỉ";
            dgvDSkhachhang.Columns[6].Name = "Giới tính";
            dgvDSkhachhang.Columns[0].Visible = false;

            foreach (var item in KhachHangService.AllKhachHang())
            {
                dgvDSkhachhang.Rows.Add(item.Id, stt++, item.MaKh, item.TenKh, item.Sdt, item.Diachi, item.GioiTinh);
            }
        }
        public void Timkiem(string name, string sdt, string ma)
        {
            int stt = 1;
            dgvDSkhachhang.ColumnCount = 7;
            dgvDSkhachhang.Rows.Clear();
            dgvDSkhachhang.Columns[0].Name = "Id";
            dgvDSkhachhang.Columns[1].Name = "Stt";
            dgvDSkhachhang.Columns[2].Name = "Mã khách hàng";
            dgvDSkhachhang.Columns[3].Name = "Tên khách hàng";
            dgvDSkhachhang.Columns[4].Name = "Sđt";
            dgvDSkhachhang.Columns[5].Name = "Địa chỉ";
            dgvDSkhachhang.Columns[6].Name = "Giới tính";
            dgvDSkhachhang.Columns[0].Visible = false;

            foreach (var item in KhachHangService.Timkiem(name,sdt,ma))
            {
                dgvDSkhachhang.Rows.Add(item.Id, stt++, item.MaKh, item.TenKh, item.Sdt, item.Diachi, item.GioiTinh);
            }
        }
        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idwhenclick = int.Parse(dgvDSkhachhang.CurrentRow.Cells[0].Value.ToString());
            txtmakh.Text = dgvDSkhachhang.CurrentRow.Cells[2].Value.ToString();
            txttenkh.Text = dgvDSkhachhang.CurrentRow.Cells[3].Value.ToString();
            if (dgvDSkhachhang.CurrentRow.Cells[6].Value.ToString().Equals("Nam"))
            {
                rbtNam.Checked = true;
            }
            else
            {
                rbtNu.Checked = true;
            }
            txtsdt.Text = dgvDSkhachhang.CurrentRow.Cells[4].Value.ToString();
            txtdiachi.Text = dgvDSkhachhang.CurrentRow.Cells[5].Value.ToString();
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            Timkiem(txttimkiem.Text, txttimkiem.Text, txttimkiem.Text);
            //Timkiemsdt(txttimkiem.Text);
        }
        private void btn_chonn_Click(object sender, EventArgs e)
        {
            //
            if (Application.OpenForms["Form_Menu"] != null)
            {
                Form_Menu banHangForm = (Form_Menu)Application.OpenForms["Form_Menu"];
                int id = int.Parse(dgvDSkhachhang.CurrentRow.Cells[0].Value.ToString());
                string maKhachHang = dgvDSkhachhang.CurrentRow.Cells[2].Value.ToString();
                string tenKhachHang = dgvDSkhachhang.CurrentRow.Cells[3].Value.ToString();

                banHangForm.CapNhatThongTinKhachHang(maKhachHang, tenKhachHang, id);
            }
            else
            {
                Form_Menu banHangForm = new Form_Menu();

                string maKhachHang = dgvDSkhachhang.CurrentRow.Cells[2].Value.ToString();
                string tenKhachHang = dgvDSkhachhang.CurrentRow.Cells[3].Value.ToString();
                int id = int.Parse(dgvDSkhachhang.CurrentRow.Cells[0].Value.ToString());


                banHangForm.CapNhatThongTinKhachHang(maKhachHang, tenKhachHang, id);
            }
            this.Close();
        }
        public bool Checksdt(string mess)
        {
            return Regex.IsMatch(mess, @"^(03|09)\d{8}$");
        }
        public bool Checkma(string mess)
        {
            return Regex.IsMatch(mess, @"^(?=.*[a-zA-Z])(?=.*\d).{1,10}$");
        }
        public bool Checkten(string mess)
        {
            return Regex.IsMatch(mess, @"^[a-zA-Z].{1,50}$");
        }
        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            bool check = KhachHangService.AllKhachHang().Any(x => x.MaKh.ToLower() == txtmakh.Text);
            if (string.IsNullOrEmpty(txtmakh.Text))
            {
                MessageBox.Show("Không được để trống mã khách hàng");
            }
            else if (!Checkma(txtmakh.Text))
            {
                MessageBox.Show("Mã khách hàng phải chứa cả chữ và số");
            }
            else if (check)
            {
                MessageBox.Show("Mã Kh đã tồn tại");
            }
            else if (string.IsNullOrEmpty(txttenkh.Text))
            {
                MessageBox.Show("Không được để trống tên khách hàng");
            }
            else if (!Checkten(txttenkh.Text))
            {
                MessageBox.Show("Tên khách hàng không được quá 50 ký tự");
            }
            else if (string.IsNullOrEmpty(txtsdt.Text))
            {
                MessageBox.Show("Không được để trống tên sđt");
            }
            else if (!Checksdt(txtsdt.Text))
            {
                MessageBox.Show("Sđt không đúng định dạng");
            }
            else
            {
                KhachHang khachHang = new KhachHang();
                khachHang.MaKh = txtmakh.Text;
                khachHang.TenKh = txttenkh.Text;
                khachHang.Sdt = txtsdt.Text;
                khachHang.Diachi = txtdiachi.Text;
                khachHang.GioiTinh = rbtNam.Checked ? "Nam" : "Nữ";
                DialogResult dr = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    KhachHangService.Them(khachHang);
                    LoadData();
                    MessageBox.Show("Thêm thành công");
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtmakh.ResetText();
            txttenkh.ResetText();
            txtsdt.ResetText();
            txtdiachi.ResetText();
            rbtNam.Checked = false;
            rbtNu.Checked = false;
        }

        
    }
}
