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

    public partial class Form_QuanLyNV : Form
    {
        NhanVienSer NhanVienService = new NhanVienSer();

        string pathimg;
        int idwhenclick = new int();
        dynamic imgLoad;
        public Form_QuanLyNV()
        {
            InitializeComponent();
            LoadData();

        }

        public void LoadData()
        {
            int stt = 1;
            dgvnhanvien.ColumnCount = 14;
            dgvnhanvien.Rows.Clear();
            dgvnhanvien.Columns[0].Name = "Id";
            dgvnhanvien.Columns[1].Name = "Stt";
            dgvnhanvien.Columns[2].Name = "Mã NV";
            dgvnhanvien.Columns[3].Name = "Tên NV";
            dgvnhanvien.Columns[4].Name = "Giới tính";
            dgvnhanvien.Columns[5].Name = "Sđt";
            dgvnhanvien.Columns[6].Name = "Địa Chỉ";
            dgvnhanvien.Columns[7].Name = "Số CMND";
            dgvnhanvien.Columns[8].Name = "Vai trò";
            dgvnhanvien.Columns[9].Name = "Tên TK";
            dgvnhanvien.Columns[10].Name = "Mật khẩu";
            dgvnhanvien.Columns[11].Name = "Ngày Vào Làm";
            dgvnhanvien.Columns[12].Name = "Trạng Thái";
            dgvnhanvien.Columns[13].Name = "Hình Ảnh";
            dgvnhanvien.Columns[0].Visible = false;
            dgvnhanvien.Columns[10].Visible = false;
            foreach (var item in NhanVienService.AllNhanVien())
            {
                dgvnhanvien.Rows.Add(item.Id, stt++, item.MaNv, item.TenNv, item.GioiTinh, item.Sdt, item.DiaChi, item.Cccd, item.VaiTro, item.TenTaiKhoan, item.MatKhau, item.NgayVaoLam, item.TrangThai, item.HinhAnh);
            }
        }

        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imagebytes = ms.ToArray();
                return imagebytes;
            }
        }

        public Image Base64ToImage(byte[] imagebytes)
        {
            MemoryStream ms = new MemoryStream(imagebytes, 0, imagebytes.Length);
            ms.Write(imagebytes, 0, imagebytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
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
        public bool Checksdt(string mess)
        {
            return Regex.IsMatch(mess, @"^(03|09)\d{8}$");
        }
        // check CCCD 12 số
        public bool Checkcccd(string mess)
        {
            return Regex.IsMatch(mess, @"^\d{12}$");
        }
        public bool Tencheckk(string mess)
        {
            return Regex.IsMatch(mess, @"^\p{L}+(\s+\p{L}+)+$");
        }
        public bool CheckTkmk(string mess)
        {
            return Regex.IsMatch(mess, @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d].{1,50}$");
        }
        private void btn_themNV_Click(object sender, EventArgs e)
        {
            bool check = NhanVienService.AllNhanVien().Any(x => x.MaNv.ToLower() == txtmanv.Text);
            if (string.IsNullOrEmpty(txtmanv.Text))
            {
                MessageBox.Show("Không được để trống mã NV");
            }
            else if (check)
            {
                MessageBox.Show("Mã đã tồn tại");
            }
            else if (string.IsNullOrEmpty(txttenNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Tencheckk(txttenNV.Text.Trim()))
            {
                MessageBox.Show("Nhập tên sai định dạng");
            }
            else if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập SĐT", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Checksdt(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtdiachi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtCccd.Text))
            {
                MessageBox.Show("Bạn chưa nhập cccd", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Checkcccd(txtCccd.Text))
            {
                MessageBox.Show("Chưa đúng số cccd", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rdoNam.Checked == false && rdonu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txttentk.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CheckTkmk(txttentk.Text))
            {
                MessageBox.Show("Tên tài khoản không đúng định dạng");
            }
            else if (string.IsNullOrEmpty(txtmatkhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rdoquanly.Checked == false && rdoNhanvien.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn chức vụ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbtdanglam.Checked == false && rbtnghilam.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn trang thái làm việc", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CheckTkmk(txtmatkhau.Text))
            {
                MessageBox.Show("Mật khẩu chưa đúng định dạng");
            }
            else if (string.IsNullOrEmpty(pathimg))
            {
                MessageBox.Show("Vui lòng chọn một hình ảnh trước khi thêm sản phẩm.", "Thông báo");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn thêm không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    byte[] imageBytes = File.ReadAllBytes(pathimg);
                    NhanVien nhanVien = new NhanVien();
                    nhanVien.MaNv = txtmanv.Text;
                    nhanVien.TenNv = txttenNV.Text;
                    nhanVien.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                    nhanVien.Sdt = txtSDT.Text;
                    nhanVien.DiaChi = txtdiachi.Text;
                    nhanVien.Cccd = txtCccd.Text;
                    nhanVien.VaiTro = rdoNhanvien.Checked ? "Nhân viên" : "Quản lý";
                    nhanVien.TenTaiKhoan = txttentk.Text;
                    nhanVien.MatKhau = txtmatkhau.Text;
                    nhanVien.NgayVaoLam = DateTime.ParseExact(dtpNgayvaolam.Text.Trim(), "dd/MM/yyyy", null);
                    nhanVien.TrangThai = rbtdanglam.Checked ? "Đang làm" : "Nghỉ làm";
                    if (pathimg == null) nhanVien.HinhAnh = imgLoad;
                    nhanVien.HinhAnh = imageBytes;
                    MessageBox.Show(NhanVienService.Them(nhanVien));
                    LoadData();
                }
            }
        }

        private void btn_suaNV_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = NhanVienService.AllNhanVien().Any(x => x.MaNv.ToLower() == txtmanv.Text);
                if (string.IsNullOrEmpty(txtmanv.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mã NV");
                }
                else if (check)
                {
                    MessageBox.Show("Mã NV đã tồn tại");
                }
                else if (string.IsNullOrEmpty(txttenNV.Text.Trim()))
                {
                    MessageBox.Show("Bạn chưa nhập tên nhân viên", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Tencheckk(txttenNV.Text))
                {
                    MessageBox.Show("Nhập tên sai định dạng");
                }
                else if (string.IsNullOrEmpty(txtSDT.Text))
                {
                    MessageBox.Show("Bạn chưa nhập SĐT", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Checksdt(txtSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txtdiachi.Text))
                {
                    MessageBox.Show("Bạn chưa nhập địa chỉ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txtCccd.Text))
                {
                    MessageBox.Show("Bạn chưa nhập cccd", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Checkcccd(txtCccd.Text))
                {
                    MessageBox.Show("Chưa đúng số cccd", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(txttentk.Text))
                {
                    MessageBox.Show("Bạn chưa nhập tên tài khoản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!CheckTkmk(txttentk.Text))
                {
                    MessageBox.Show("Tên tài khoản không đúng định dạng");
                }
                else if (string.IsNullOrEmpty(txtmatkhau.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!CheckTkmk(txtmatkhau.Text))
                {
                    MessageBox.Show("Mật khẩu chưa đúng định dạng");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn sửa không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dr == DialogResult.Yes)
                    {

                        NhanVien nhanVien = new NhanVien();
                        if (pathimg != null)
                        {
                            byte[] imageBytes = File.ReadAllBytes(pathimg);
                            nhanVien.HinhAnh = imageBytes;
                        }
                        else nhanVien.HinhAnh = imgLoad;
                        nhanVien.MaNv = txtmanv.Text;
                        nhanVien.TenNv = txttenNV.Text;
                        nhanVien.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                        nhanVien.Sdt = txtSDT.Text;
                        nhanVien.DiaChi = txtdiachi.Text;
                        nhanVien.Cccd = txtCccd.Text;
                        nhanVien.VaiTro = rdoNhanvien.Checked ? "Nhân viên" : "Quản lý";
                        nhanVien.TenTaiKhoan = txttentk.Text;
                        nhanVien.MatKhau = txtmatkhau.Text;
                        nhanVien.NgayVaoLam = DateTime.ParseExact(dtpNgayvaolam.Text.Trim(), "dd/MM/yyyy", null);
                        nhanVien.TrangThai = rbtdanglam.Checked ? "Đang làm" : "Nghỉ làm";

                        MessageBox.Show(NhanVienService.Sua(idwhenclick, nhanVien));
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi rồi" + ex.Message);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtmanv.ResetText();
            txtmanv.ReadOnly = false;
            txttenNV.ResetText();
            txtSDT.ResetText();
            txtdiachi.ResetText();
            txtCccd.ResetText();
            rdoNam.Checked = false;
            rdonu.Checked = false;
            rdoquanly.Checked = false;
            rdoNhanvien.Checked = false;
            rbtdanglam.Checked = false;
            rbtnghilam.Checked = false;
            txttentk.ResetText();
            txtmatkhau.ResetText();
            dtpNgayvaolam.ResetText();
            pbhinhanh.Image = null;
        }

        private void btn_LoadDGV_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void Timkiem(string name, string sdt, string ma)
        {
            int stt = 1;
            dgvnhanvien.ColumnCount = 14;
            dgvnhanvien.Rows.Clear();
            dgvnhanvien.Columns[0].Name = "Id";
            dgvnhanvien.Columns[1].Name = "Stt";
            dgvnhanvien.Columns[2].Name = "Mã NV";
            dgvnhanvien.Columns[3].Name = "Tên NV";
            dgvnhanvien.Columns[4].Name = "Giới tính";
            dgvnhanvien.Columns[5].Name = "Sđt";
            dgvnhanvien.Columns[6].Name = "Địa Chỉ";
            dgvnhanvien.Columns[7].Name = "Số CMND";
            dgvnhanvien.Columns[8].Name = "Vai trò";
            dgvnhanvien.Columns[9].Name = "Tên TK";
            dgvnhanvien.Columns[10].Name = "Mật khẩu";
            dgvnhanvien.Columns[11].Name = "Ngày Vào Làm";
            dgvnhanvien.Columns[12].Name = "Trạng Thái";
            dgvnhanvien.Columns[13].Name = "Hình Ảnh";
            dgvnhanvien.Columns[0].Visible = false;
            foreach (var item in NhanVienService.Timkiem(name, sdt, ma))
            {

                dgvnhanvien.Rows.Add(item.Id, stt++, item.MaNv, item.TenNv, item.GioiTinh, item.Sdt, item.DiaChi, item.Cccd, item.VaiTro, item.TenTaiKhoan, item.MatKhau, item.NgayVaoLam, item.TrangThai, item.HinhAnh);
            }
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            Timkiem(txttimkiem.Text, txttimkiem.Text, txttimkiem.Text);
        }


        public void Locc(string Vaitro)
        {
            int stt = 1;
            dgvnhanvien.ColumnCount = 14;
            dgvnhanvien.Rows.Clear();
            dgvnhanvien.Columns[0].Name = "Id";
            dgvnhanvien.Columns[1].Name = "Stt";
            dgvnhanvien.Columns[2].Name = "Mã NV";
            dgvnhanvien.Columns[3].Name = "Tên NV";
            dgvnhanvien.Columns[4].Name = "Giới tính";
            dgvnhanvien.Columns[5].Name = "Sđt";
            dgvnhanvien.Columns[6].Name = "Địa Chỉ";
            dgvnhanvien.Columns[7].Name = "Số CMND";
            dgvnhanvien.Columns[8].Name = "Vai trò";
            dgvnhanvien.Columns[9].Name = "Tên TK";
            dgvnhanvien.Columns[10].Name = "Mật khẩu";
            dgvnhanvien.Columns[11].Name = "Ngày Vào Làm";
            dgvnhanvien.Columns[12].Name = "Trạng Thái";
            dgvnhanvien.Columns[13].Name = "Hình Ảnh";
            dgvnhanvien.Columns[0].Visible = false;
            foreach (var item in NhanVienService.Loc(Vaitro))
            {

                dgvnhanvien.Rows.Add(item.Id, stt++, item.MaNv, item.TenNv, item.GioiTinh, item.Sdt, item.DiaChi, item.Cccd, item.VaiTro, item.TenTaiKhoan, item.MatKhau, item.NgayVaoLam, item.TrangThai, item.HinhAnh);
            }
        }

        private void cbolocDU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbolocDU.SelectedIndex == 1)
            {
                Locc("Quản Lý");
            }
            else
            {
                Locc("Nhân Viên");
            }
        }

        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvnhanvien.CurrentRow != null && dgvnhanvien.CurrentRow.Cells[0].Value != null)
            {
                int d = e.RowIndex;
                idwhenclick = int.Parse(dgvnhanvien.Rows[d].Cells[0].Value.ToString());
                txtmanv.ReadOnly = true;
                txtmanv.Text = dgvnhanvien.Rows[d].Cells[2].Value.ToString();
                txttenNV.Text = dgvnhanvien.Rows[d].Cells[3].Value.ToString();

                if (dgvnhanvien.Rows[d].Cells[4].Value.ToString().Equals("Nam"))
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdonu.Checked = true;
                }
                txtSDT.Text = dgvnhanvien.Rows[d].Cells[5].Value.ToString();
                txtdiachi.Text = dgvnhanvien.Rows[d].Cells[6].Value.ToString();
                txtCccd.Text = dgvnhanvien.Rows[d].Cells[7].Value.ToString();
                if (dgvnhanvien.Rows[d].Cells[8].Value.ToString().Equals("Quản Lý", StringComparison.OrdinalIgnoreCase))
                {

                    rdoquanly.Checked = true;
                }
                else
                {
                    rdoNhanvien.Checked = true;
                }
                txttentk.Text = dgvnhanvien.Rows[d].Cells[9].Value.ToString();
                txtmatkhau.Text = dgvnhanvien.Rows[d].Cells[10].Value.ToString();
                dtpNgayvaolam.Text = dgvnhanvien.Rows[d].Cells[11].Value.ToString();
                if (dgvnhanvien.Rows[d].Cells[12].Value.ToString().Equals("Đang Làm", StringComparison.OrdinalIgnoreCase))
                {
                    rbtdanglam.Checked = true;
                }
                else
                {
                    rbtnghilam.Checked = true;
                }
                var s = NhanVienService.Findid(idwhenclick);
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

        private void Form_QuanLyNV_Load(object sender, EventArgs e)
        {

        }
    }
}
