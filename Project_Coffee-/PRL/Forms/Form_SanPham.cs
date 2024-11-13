using DuAn1_Coffe.BLL.Service;
using DuAn1_Coffe.Models;
using QRCoder;
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
using TheArtOfDevHtmlRenderer.Adapters;

namespace DuAn1_Coffe.PRL.Forms
{
    public partial class Form_SanPham : Form
    {
       
        SanPhamSer sanPhamService = new SanPhamSer();
        string pathimg;
        dynamic imgLoad;
        int idWhenclick = new int();
        public Form_SanPham()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            int stt = 1;
            dgvsanpham.ColumnCount = 10;
            dgvsanpham.Rows.Clear();
            dgvsanpham.Columns[0].Name = "Id";
            dgvsanpham.Columns[1].Name = "Stt";
            dgvsanpham.Columns[2].Name = "Mã SP";
            dgvsanpham.Columns[3].Name = "Tên SP";
            dgvsanpham.Columns[4].Name = "Đơn Giá";
            dgvsanpham.Columns[5].Name = "Số Lượng";
            dgvsanpham.Columns[6].Name = "Trạng Thái";
            dgvsanpham.Columns[7].Name = "Mô Tả";
            dgvsanpham.Columns[8].Name = "Hình Ảnh";
            dgvsanpham.Columns[9].Name = "MaKM";
            dgvsanpham.Columns[0].Visible = false;
            dgvsanpham.Columns[9].Visible = false;
            foreach (var item in sanPhamService.Allsanpham())
            {
                dgvsanpham.Rows.Add(item.Id, stt++, item.MaSp, item.TenSanPham, item.DonGia, item.SoLuong, item.TrangThai, item.MoTa, item.HinhAnh);
            }
        }

        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            idWhenclick = int.Parse(dgvsanpham.Rows[d].Cells[0].Value.ToString());
            txtmasp.Text = dgvsanpham.Rows[d].Cells[2].Value.ToString();
            txttensp.Text = dgvsanpham.Rows[d].Cells[3].Value.ToString();
            txtdongia.Text = dgvsanpham.Rows[d].Cells[4].Value.ToString();
            txtsoluong.Text = dgvsanpham.Rows[d].Cells[5].Value.ToString();
            txtmotaDU.Text = dgvsanpham.Rows[d].Cells[7].Value.ToString();
            if (dgvsanpham.Rows[d].Cells[6].Value.ToString().Equals("Đang Bán"))
            {
                rbtdangbanDU.Checked = true;
            }
            else
            {
                rbtngungbanDU.Checked = true;
            }
            var s = sanPhamService.Findid(idWhenclick);
            object img = s.HinhAnh;
            imgLoad = s.HinhAnh;
            byte[] imageData = (byte[])img;
            Image image;
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                image = Image.FromStream(ms);
            }
            pbhinhanh.Image = image;
        }

        private void btn_anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif";
            openFileDialog.Title = "Chọn ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Image image = Image.FromFile(openFileDialog.FileName);


                    pbhinhanh.Image = image;

                    pathimg = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải hình ảnh: " + ex.Message);
                }
            }
        }
        public bool Checkint(string mess)
        {
            return Regex.IsMatch(mess, @"^\d+$");
        }
        private void btn_themDU_Click(object sender, EventArgs e)
        {
            int soluong;
            bool check = sanPhamService.Allsanpham().Any(x => x.MaSp == txtmasp.Text);
            if (string.IsNullOrEmpty(txtmasp.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sản phẩm");
            }
            else if (check)
            {
                MessageBox.Show("Mã đã tồn tại");
            }
            else if (string.IsNullOrEmpty(txttensp.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtdongia.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtdongia.Text, out soluong) || soluong < 0 || soluong >= 1000000)
            {
                MessageBox.Show("Thứ bạn nhập đơn giá không phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtsoluong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtsoluong.Text, out soluong) || soluong <= 0 || soluong >= 10000)
            {
                MessageBox.Show("Thứ bạn nhập số lượng không phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbtdangbanDU.Checked == false && rbtngungbanDU.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái");
            }
            else if (string.IsNullOrEmpty(pathimg))
            {
                MessageBox.Show("Vui lòng chọn một hình ảnh trước khi thêm sản phẩm", "Thông báo");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn thêm không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    byte[] imageBytes = File.ReadAllBytes(pathimg);
                    SanPham sanPham = new SanPham();
                    sanPham.MaSp = txtmasp.Text;
                    sanPham.TenSanPham = txttensp.Text;
                    sanPham.DonGia = Convert.ToInt32(txtdongia.Text);
                    sanPham.SoLuong = Convert.ToInt32(txtsoluong.Text);
                    sanPham.MoTa = txtmotaDU.Text;
                    sanPham.TrangThai = rbtdangbanDU.Checked ? "Đang Bán" : "Ngừng Bán";
                    sanPham.HinhAnh = imageBytes;
                    MessageBox.Show(sanPhamService.Them(sanPham));
                    LoadData();
                }
            }
                       
        }

        private void btn_suaDU_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttensp.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtdongia.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Checkint(txtdongia.Text))
            {
                MessageBox.Show("Thứ bạn nhập đơn giá không phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtsoluong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Checkint(txtsoluong.Text))
            {
                MessageBox.Show("Thứ bạn nhập số lượng không phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbtdangbanDU.Checked == false && rbtngungbanDU.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn Sửa không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    SanPham sanPham = new SanPham();
                    if (pathimg != null)
                    {
                        byte[] imageBytes = File.ReadAllBytes(pathimg);
                        sanPham.HinhAnh = imageBytes;
                    }
                    else
                        sanPham.HinhAnh = imgLoad;
                    sanPham.MaSp = txtmasp.Text;
                    sanPham.TenSanPham = txttensp.Text;
                    sanPham.DonGia = Convert.ToInt32(txtdongia.Text);
                    sanPham.SoLuong = Convert.ToInt32(txtsoluong.Text);
                    sanPham.MoTa = txtmotaDU.Text;
                    sanPham.TrangThai = rbtdangbanDU.Checked ? "Đang Bán" : "Ngừng Bán";
                    MessageBox.Show(sanPhamService.Sua(idWhenclick, sanPham));
                    LoadData();
                }
            }
        }

        public void TimKiem(string name, string ma)
        {
            int stt = 1;
            dgvsanpham.ColumnCount = 9;
            dgvsanpham.Rows.Clear();
            dgvsanpham.Columns[0].Name = "Id";
            dgvsanpham.Columns[1].Name = "Stt";
            dgvsanpham.Columns[2].Name = "Mã SP";
            dgvsanpham.Columns[3].Name = "Tên SP";
            dgvsanpham.Columns[4].Name = "Đơn Giá";
            dgvsanpham.Columns[5].Name = "Số Lượng";
            dgvsanpham.Columns[6].Name = "Trạng Thái";
            dgvsanpham.Columns[7].Name = "Mô Tả";
            dgvsanpham.Columns[8].Name = "Hình Ảnh";
            dgvsanpham.Columns[0].Visible = false;
            foreach (var item in sanPhamService.Timkiem(name, ma))
            {
                dgvsanpham.Rows.Add(item.Id, stt++, item.MaSp, item.TenSanPham, item.DonGia, item.SoLuong, item.TrangThai, item.MoTa, item.HinhAnh);
            }
        }
        private void txttimkimdouong_TextChanged(object sender, EventArgs e)
        {
            TimKiem(txttimkimdouong.Text, txttimkimdouong.Text);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtmasp.ResetText();
            txtmasp.ReadOnly = false;
            txttensp.ResetText();
            txtdongia.ResetText();
            txtsoluong.ResetText();
            rbtdangbanDU.Checked = false;
            rbtngungbanDU.Checked = false;
            pbhinhanh.Image = null;
        }

        public void Locc(string trangthai)
        {
            int stt = 1;
            dgvsanpham.ColumnCount = 9;
            dgvsanpham.Rows.Clear();
            dgvsanpham.Columns[0].Name = "Id";
            dgvsanpham.Columns[1].Name = "Stt";
            dgvsanpham.Columns[2].Name = "Mã SP";
            dgvsanpham.Columns[3].Name = "Tên SP";
            dgvsanpham.Columns[4].Name = "Đơn Giá";
            dgvsanpham.Columns[5].Name = "Số Lượng";
            dgvsanpham.Columns[6].Name = "Trạng Thái";
            dgvsanpham.Columns[7].Name = "Mô Tả";
            dgvsanpham.Columns[8].Name = "Hình Ảnh";
            dgvsanpham.Columns[0].Visible = false;
            foreach (var item in sanPhamService.Loc(trangthai))
            {
                dgvsanpham.Rows.Add(item.Id, stt++, item.MaSp, item.TenSanPham, item.DonGia, item.SoLuong, item.TrangThai, item.MoTa, item.HinhAnh);
            }
        }
        private void cbolocDU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbolocDU.SelectedIndex == 0)
            {
                Locc("Đang bán");
            }
            else
            {
                Locc("Ngừng bán");
            }
        }

        private void btn_LoadDU_Click(object sender, EventArgs e)
        {
            LoadData();
        }



        private void dgvsanpham_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvsanpham.CurrentRow != null && dgvsanpham.CurrentRow.Cells[0].Value != null)
            {
                int d = e.RowIndex;
                idWhenclick = int.Parse(dgvsanpham.Rows[d].Cells[0].Value.ToString());
                txtmasp.ReadOnly = true;
                txtmasp.Text = dgvsanpham.Rows[d].Cells[2].Value.ToString();
                txttensp.Text = dgvsanpham.Rows[d].Cells[3].Value.ToString();
                txtdongia.Text = dgvsanpham.Rows[d].Cells[4].Value.ToString();
                txtsoluong.Text = dgvsanpham.Rows[d].Cells[5].Value.ToString();
                txtmotaDU.Text = dgvsanpham.Rows[d].Cells[7].Value.ToString();
                if (dgvsanpham.Rows[d].Cells[6].Value.ToString().Equals("Đang Bán"))
                {
                    rbtdangbanDU.Checked = true;
                }
                else
                {
                    rbtngungbanDU.Checked = true;
                }
                var s = sanPhamService.Findid(idWhenclick);
                object img = s.HinhAnh;
                imgLoad = s.HinhAnh;
                byte[] imageData = (byte[])img;
                Image image;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    image = Image.FromStream(ms);
                }
                pbhinhanh.Image = image;
            }
        }

        private void btn_qr_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenernator = new QRCodeGenerator();
            QRCodeData qrCodedata = qrGenernator.CreateQrCode(txtmasp.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodedata);
            Bitmap qrcodeImg = qrcode.GetGraphic(20);
            pbhinhanh.Image = qrcodeImg;
        }

        private void btn_LuuQR_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog savefliedialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (savefliedialog.ShowDialog() == DialogResult.OK)
                {
                    pbhinhanh.Image.Save(savefliedialog.FileName);
                    MessageBox.Show("Tệp đã lưu");
                }
            }
        }

        private void Form_SanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
