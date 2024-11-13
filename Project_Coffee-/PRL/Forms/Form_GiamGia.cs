using DuAn1_Coffe.BLL.Service;
using DuAn1_Coffe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_Coffe.PRL.Forms
{
    public partial class Form_GiamGia : Form
    {
        GiamGiaSer GiamGiaService = new GiamGiaSer();
        int idwhenclick = new int();
        public Form_GiamGia()
        {
            InitializeComponent();
            LoadDataGG();
        }
        private void Form_GiamGia_Load(object sender, EventArgs e)
        {

        }
        public void LoadDataGG()
        {
            int STT = 1;
            dgvgiamgia.ColumnCount = 9;
            dgvgiamgia.Rows.Clear();
            dgvgiamgia.Columns[0].Name = "ID";
            dgvgiamgia.Columns[1].Name = "STT";
            dgvgiamgia.Columns[2].Name = "Mã giảm giá";
            dgvgiamgia.Columns[3].Name = "Ngày bắt đầu";
            dgvgiamgia.Columns[4].Name = "Ngày kết thúc";
            dgvgiamgia.Columns[5].Name = "Tỉ lệ giảm(%)";
            dgvgiamgia.Columns[6].Name = "Đơn hàng tối thiểu";
            dgvgiamgia.Columns[7].Name = "Giảm tối đa";
            dgvgiamgia.Columns[8].Name = "Số Lượng";

            dgvgiamgia.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvgiamgia.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvgiamgia.Columns[0].Visible = false;

            foreach (var item in GiamGiaService.AllGiamGia())
            {
                dgvgiamgia.Rows.Add(item.Id, STT++, item.MaGiamGia, item.NgayBatDau, item.NgayKetThuc, item.TiLeGiam, item.DonHangToiThieu, item.GiamToiDa, item.SoLuong);
            }
        }
        private void dgvgiamgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvgiamgia.CurrentRow != null && dgvgiamgia.CurrentRow.Cells[0].Value != null)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgvgiamgia.Rows[e.RowIndex];

                    // Set textbox values based on the selected row
                    idwhenclick = int.Parse(dgvgiamgia.CurrentRow.Cells[0].Value.ToString());
                    txtMaGiamGia.ReadOnly = true;
                    txtMaGiamGia.Text = selectedRow.Cells[2].Value.ToString();
                    dtpNgayBatDau.Value = Convert.ToDateTime(selectedRow.Cells[3].Value);
                    dtpNgayKetThuc.Value = Convert.ToDateTime(selectedRow.Cells[4].Value);
                    txtTiLeGiam.Text = selectedRow.Cells[5].Value.ToString();
                    txtDonToiThieu.Text = selectedRow.Cells[6].Value.ToString();
                    txtGiamToiDa.Text = selectedRow.Cells[7].Value.ToString();
                    txtSoLuong.Text = selectedRow.Cells[8].Value.ToString();
                    txtMaGiamGia.ReadOnly = true;
                }
            }
            
        }
        public bool CheckGiagiam(string gia)
        {
            return Regex.IsMatch(gia, @"^(?:\d{1,2}|100)$");
        }
        public bool Checkint(string Mess)
        {
            return Regex.IsMatch(Mess, @"^\d+$");
        }

        public bool checkngay(string mess)
        {
            return Regex.IsMatch(mess, @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/((19|20)\d\d)\s*((0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/((19|20)\d\d))$");
        }
        private void btn_themGG_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = GiamGiaService.AllGiamGia().Any(x => x.MaGiamGia.ToLower() == txtMaGiamGia.Text.ToLower());
                if (string.IsNullOrEmpty(txtMaGiamGia.Text))
                {
                    MessageBox.Show("Không được để trống mã giảm giá");
                }
                else if (check)
                {
                    MessageBox.Show("Mã đã tồn tại");
                }   
                else if (DateTime.ParseExact(dtpNgayBatDau.Text.Trim(), "dd/MM/yyyy", null) > DateTime.ParseExact(dtpNgayKetThuc.Text.Trim(), "dd/MM/yyyy", null))
                {
                    MessageBox.Show("Ngày bắt đầu <= Ngày kết thúc");
                }
                else if (string.IsNullOrEmpty(txtTiLeGiam.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tỉ lệ giảm", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!CheckGiagiam(txtTiLeGiam.Text))
                {
                    MessageBox.Show("Tỉ lệ giảm <= 100", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txtDonToiThieu.Text))
                {
                    MessageBox.Show("Bạn chưa nhập đơn hàng tối thiểu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Checkint(txtDonToiThieu.Text))
                {
                    MessageBox.Show("Nhập sai định dạng đơn hàng tối thiểu! nhập lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txtGiamToiDa.Text))
                {
                    MessageBox.Show("Bạn chưa nhập giảm tối đa", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Checkint(txtGiamToiDa.Text))
                {
                    MessageBox.Show("Nhập sai định dạng giảm tối đa", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txtSoLuong.Text))
                {
                    MessageBox.Show("Bạn chưa nhập số lượng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Checkint(txtSoLuong.Text))
                {
                    MessageBox.Show("Nhập sai định dạng số lượng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else

                    {
                        DialogResult dr = MessageBox.Show("Bạn có muốn thêm không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dr == DialogResult.Yes)
                        {
                            GiamGium giamGia = new GiamGium();
                            giamGia.MaGiamGia = txtMaGiamGia.Text;
                            giamGia.NgayBatDau = DateTime.ParseExact(dtpNgayBatDau.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            giamGia.NgayKetThuc = DateTime.ParseExact(dtpNgayKetThuc.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            giamGia.TiLeGiam = int.Parse(txtTiLeGiam.Text);
                            giamGia.DonHangToiThieu = int.Parse(txtDonToiThieu.Text);
                            giamGia.GiamToiDa = int.Parse(txtGiamToiDa.Text);
                            giamGia.SoLuong = int.Parse(txtSoLuong.Text);
                            MessageBox.Show(GiamGiaService.Them(giamGia));
                            LoadDataGG();
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_suaGG_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.ParseExact(dtpNgayBatDau.Text.Trim(), "dd/MM/yyyy", null) > DateTime.ParseExact(dtpNgayKetThuc.Text.Trim(), "dd/MM/yyyy", null))
                {
                    MessageBox.Show("Ngày bắt đầu <= Ngày kết thúc");
                }
                else if (string.IsNullOrEmpty(txtTiLeGiam.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tỉ lệ giảm", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!CheckGiagiam(txtTiLeGiam.Text))
                {
                    MessageBox.Show("Tỉ lệ giảm <= 100", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txtDonToiThieu.Text))
                {
                    MessageBox.Show("Bạn chưa nhập đơn hàng tối thiểu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Checkint(txtDonToiThieu.Text))
                {
                    MessageBox.Show("Nhập sai định dạng đơn hàng tối thiểu! nhập lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txtGiamToiDa.Text))
                {
                    MessageBox.Show("Bạn chưa nhập giảm tối đa", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Checkint(txtGiamToiDa.Text))
                {
                    MessageBox.Show("Nhập sai định dạng giảm tối đa", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txtSoLuong.Text))
                {
                    MessageBox.Show("Bạn chưa nhập số lượng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Checkint(txtSoLuong.Text))
                {
                    MessageBox.Show("Nhập sai định dạng số lượng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn sửa không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dr == DialogResult.Yes)
                    {
                        GiamGium giamGia = new GiamGium();
                        giamGia.MaGiamGia = txtMaGiamGia.Text;
                        giamGia.NgayBatDau = DateTime.ParseExact(dtpNgayBatDau.Text.Trim(), "dd/MM/yyyy", null);
                        giamGia.NgayKetThuc = DateTime.ParseExact(dtpNgayKetThuc.Text.Trim() + " 23:59:59", "dd/MM/yyyy HH:mm:ss", null);
                        giamGia.TiLeGiam = int.Parse(txtTiLeGiam.Text);
                        giamGia.DonHangToiThieu = int.Parse(txtDonToiThieu.Text);
                        giamGia.GiamToiDa = int.Parse(txtGiamToiDa.Text);
                        giamGia.SoLuong = int.Parse(txtSoLuong.Text);
                        MessageBox.Show(GiamGiaService.Sua(idwhenclick, giamGia));
                        LoadDataGG();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadDataGG();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtMaGiamGia.Text = "";
            txtMaGiamGia.ReadOnly = false;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            txtTiLeGiam.Text = "";
            txtDonToiThieu.Text = "";
            txtGiamToiDa.Text = "";
            txtSoLuong.Text = "";
        }
        public void Timkiem(string ma)
        {
            int STT = 1;
            dgvgiamgia.ColumnCount = 9;
            dgvgiamgia.Rows.Clear();
            dgvgiamgia.Columns[0].Name = "ID";
            dgvgiamgia.Columns[1].Name = "STT";
            dgvgiamgia.Columns[2].Name = "Mã giảm giá";
            dgvgiamgia.Columns[3].Name = "Ngày bắt đầu";
            dgvgiamgia.Columns[4].Name = "Ngày kết thúc";
            dgvgiamgia.Columns[5].Name = "Tỉ lệ giảm(%)";
            dgvgiamgia.Columns[6].Name = "Đơn hàng tối thiểu";
            dgvgiamgia.Columns[7].Name = "Giảm tối đa";
            dgvgiamgia.Columns[8].Name = "Số Lượng";

            dgvgiamgia.Columns[0].Visible = false;

            foreach (var item in GiamGiaService.TimkiemMa(ma))
            {
                dgvgiamgia.Rows.Add(item.Id, STT++, item.MaGiamGia, item.NgayBatDau, item.NgayKetThuc, item.TiLeGiam, item.DonHangToiThieu, item.GiamToiDa, item.SoLuong);
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            Timkiem(txtTimKiem.Text);
        }
    }
}
