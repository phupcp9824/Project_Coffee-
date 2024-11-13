namespace DuAn1_Coffe.PRL.Forms
{
    partial class Form_QuanLyNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyNV));
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            dgvnhanvien = new DataGridView();
            groupBox2 = new GroupBox();
            cbolocDU = new ComboBox();
            txttimkiem = new TextBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            rbtnghilam = new RadioButton();
            rbtdanglam = new RadioButton();
            label4 = new Label();
            btn_Reset = new Button();
            groupBox7 = new GroupBox();
            rdonu = new RadioButton();
            rdoNam = new RadioButton();
            lbgioitinh = new Label();
            groupBox6 = new GroupBox();
            rdoquanly = new RadioButton();
            rdoNhanvien = new RadioButton();
            label10 = new Label();
            groupBox3 = new GroupBox();
            btn_anh = new Button();
            pbhinhanh = new PictureBox();
            btn_LoadDGV = new Button();
            btn_suaNV = new Button();
            btn_themNV = new Button();
            dtpNgayvaolam = new DateTimePicker();
            label1 = new Label();
            lbmk = new Label();
            txtmatkhau = new TextBox();
            lbtentk = new Label();
            txttentk = new TextBox();
            lbcccd = new Label();
            txtCccd = new TextBox();
            lbdiachi = new Label();
            txtdiachi = new TextBox();
            label3 = new Label();
            txtSDT = new TextBox();
            label2 = new Label();
            txttenNV = new TextBox();
            lbmanv = new Label();
            txtmanv = new TextBox();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbhinhanh).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 446);
            panel2.Name = "panel2";
            panel2.Size = new Size(1597, 288);
            panel2.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvnhanvien);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(0, 54);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1597, 234);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin nhân viên";
            // 
            // dgvnhanvien
            // 
            dgvnhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvnhanvien.BackgroundColor = SystemColors.ButtonHighlight;
            dgvnhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvnhanvien.Dock = DockStyle.Fill;
            dgvnhanvien.Location = new Point(3, 26);
            dgvnhanvien.Name = "dgvnhanvien";
            dgvnhanvien.RowHeadersWidth = 51;
            dgvnhanvien.RowTemplate.Height = 80;
            dgvnhanvien.Size = new Size(1591, 205);
            dgvnhanvien.TabIndex = 0;
            dgvnhanvien.CellClick += dgvnhanvien_CellClick;

            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(cbolocDU);
            groupBox2.Controls.Add(txttimkiem);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1597, 54);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // cbolocDU
            // 
            cbolocDU.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbolocDU.FormattingEnabled = true;
            cbolocDU.Items.AddRange(new object[] { "Nhân Viên", "Quản Lý" });
            cbolocDU.Location = new Point(1358, 17);
            cbolocDU.Name = "cbolocDU";
            cbolocDU.Size = new Size(204, 31);
            cbolocDU.TabIndex = 107;
            cbolocDU.Text = "Lọc";
            cbolocDU.SelectedIndexChanged += cbolocDU_SelectedIndexChanged;
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkiem.Location = new Point(177, 14);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.PlaceholderText = "Tìm kiếm";
            txttimkiem.Size = new Size(383, 34);
            txttimkiem.TabIndex = 84;
            txttimkiem.TextChanged += txttimkiem_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1597, 446);
            panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(rbtnghilam);
            groupBox1.Controls.Add(rbtdanglam);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btn_Reset);
            groupBox1.Controls.Add(groupBox7);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(btn_LoadDGV);
            groupBox1.Controls.Add(btn_suaNV);
            groupBox1.Controls.Add(btn_themNV);
            groupBox1.Controls.Add(dtpNgayvaolam);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbmk);
            groupBox1.Controls.Add(txtmatkhau);
            groupBox1.Controls.Add(lbtentk);
            groupBox1.Controls.Add(txttentk);
            groupBox1.Controls.Add(lbcccd);
            groupBox1.Controls.Add(txtCccd);
            groupBox1.Controls.Add(lbdiachi);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txttenNV);
            groupBox1.Controls.Add(lbmanv);
            groupBox1.Controls.Add(txtmanv);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1597, 446);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhân Viên";
            // 
            // rbtnghilam
            // 
            rbtnghilam.AutoSize = true;
            rbtnghilam.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnghilam.Location = new Point(1017, 374);
            rbtnghilam.Name = "rbtnghilam";
            rbtnghilam.Size = new Size(125, 30);
            rbtnghilam.TabIndex = 96;
            rbtnghilam.TabStop = true;
            rbtnghilam.Text = "Nghỉ Làm";
            rbtnghilam.UseVisualStyleBackColor = true;
            // 
            // rbtdanglam
            // 
            rbtdanglam.AutoSize = true;
            rbtdanglam.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            rbtdanglam.Location = new Point(764, 374);
            rbtdanglam.Name = "rbtdanglam";
            rbtdanglam.Size = new Size(130, 30);
            rbtdanglam.TabIndex = 95;
            rbtdanglam.TabStop = true;
            rbtdanglam.Text = "Đang Làm";
            rbtdanglam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(574, 378);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 26);
            label4.TabIndex = 94;
            label4.Text = "Trạng thái :";
            // 
            // btn_Reset
            // 
            btn_Reset.BackgroundImage = (Image)resources.GetObject("btn_Reset.BackgroundImage");
            btn_Reset.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Reset.Location = new Point(1453, 244);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(71, 53);
            btn_Reset.TabIndex = 93;
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(rdonu);
            groupBox7.Controls.Add(rdoNam);
            groupBox7.Controls.Add(lbgioitinh);
            groupBox7.Location = new Point(6, 346);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(517, 82);
            groupBox7.TabIndex = 91;
            groupBox7.TabStop = false;
            // 
            // rdonu
            // 
            rdonu.AutoSize = true;
            rdonu.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdonu.Location = new Point(402, 31);
            rdonu.Margin = new Padding(2);
            rdonu.Name = "rdonu";
            rdonu.Size = new Size(61, 30);
            rdonu.TabIndex = 92;
            rdonu.TabStop = true;
            rdonu.Text = "Nữ";
            rdonu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdoNam.Location = new Point(136, 31);
            rdoNam.Margin = new Padding(2);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(77, 30);
            rdoNam.TabIndex = 91;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // lbgioitinh
            // 
            lbgioitinh.AutoSize = true;
            lbgioitinh.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbgioitinh.Location = new Point(6, 31);
            lbgioitinh.Margin = new Padding(2, 0, 2, 0);
            lbgioitinh.Name = "lbgioitinh";
            lbgioitinh.Size = new Size(114, 26);
            lbgioitinh.TabIndex = 90;
            lbgioitinh.Text = "Giới Tính :";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rdoquanly);
            groupBox6.Controls.Add(rdoNhanvien);
            groupBox6.Controls.Add(label10);
            groupBox6.Location = new Point(564, 29);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(584, 79);
            groupBox6.TabIndex = 91;
            groupBox6.TabStop = false;
            // 
            // rdoquanly
            // 
            rdoquanly.AutoSize = true;
            rdoquanly.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdoquanly.Location = new Point(462, 28);
            rdoquanly.Margin = new Padding(2);
            rdoquanly.Name = "rdoquanly";
            rdoquanly.Size = new Size(115, 30);
            rdoquanly.TabIndex = 89;
            rdoquanly.TabStop = true;
            rdoquanly.Text = "Quản Lý";
            rdoquanly.UseVisualStyleBackColor = true;
            // 
            // rdoNhanvien
            // 
            rdoNhanvien.AutoSize = true;
            rdoNhanvien.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdoNhanvien.Location = new Point(200, 30);
            rdoNhanvien.Margin = new Padding(2);
            rdoNhanvien.Name = "rdoNhanvien";
            rdoNhanvien.Size = new Size(132, 30);
            rdoNhanvien.TabIndex = 88;
            rdoNhanvien.TabStop = true;
            rdoNhanvien.Text = "Nhân Viên";
            rdoNhanvien.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(10, 30);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(92, 26);
            label10.TabIndex = 87;
            label10.Text = "Vai Trò :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_anh);
            groupBox3.Controls.Add(pbhinhanh);
            groupBox3.Location = new Point(1186, 76);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(212, 296);
            groupBox3.TabIndex = 83;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hình ảnh";
            // 
            // btn_anh
            // 
            btn_anh.BackColor = Color.DarkOrange;
            btn_anh.Location = new Point(63, 259);
            btn_anh.Name = "btn_anh";
            btn_anh.Size = new Size(94, 37);
            btn_anh.TabIndex = 84;
            btn_anh.Text = "Ảnh";
            btn_anh.UseVisualStyleBackColor = false;
            btn_anh.Click += btn_anh_Click;
            // 
            // pbhinhanh
            // 
            pbhinhanh.BackColor = SystemColors.ActiveCaptionText;
            pbhinhanh.Location = new Point(30, 34);
            pbhinhanh.Name = "pbhinhanh";
            pbhinhanh.Size = new Size(159, 219);
            pbhinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbhinhanh.TabIndex = 82;
            pbhinhanh.TabStop = false;
            // 
            // btn_LoadDGV
            // 
            btn_LoadDGV.BackColor = SystemColors.ControlLightLight;
            btn_LoadDGV.BackgroundImage = (Image)resources.GetObject("btn_LoadDGV.BackgroundImage");
            btn_LoadDGV.BackgroundImageLayout = ImageLayout.Stretch;
            btn_LoadDGV.Location = new Point(1453, 328);
            btn_LoadDGV.Margin = new Padding(3, 4, 3, 4);
            btn_LoadDGV.Name = "btn_LoadDGV";
            btn_LoadDGV.Size = new Size(71, 59);
            btn_LoadDGV.TabIndex = 79;
            btn_LoadDGV.UseVisualStyleBackColor = false;
            btn_LoadDGV.Click += btn_LoadDGV_Click;
            // 
            // btn_suaNV
            // 
            btn_suaNV.BackgroundImage = (Image)resources.GetObject("btn_suaNV.BackgroundImage");
            btn_suaNV.BackgroundImageLayout = ImageLayout.Stretch;
            btn_suaNV.Location = new Point(1453, 154);
            btn_suaNV.Margin = new Padding(3, 4, 3, 4);
            btn_suaNV.Name = "btn_suaNV";
            btn_suaNV.Size = new Size(71, 59);
            btn_suaNV.TabIndex = 78;
            btn_suaNV.UseVisualStyleBackColor = true;
            btn_suaNV.Click += btn_suaNV_Click;
            // 
            // btn_themNV
            // 
            btn_themNV.BackgroundImage = (Image)resources.GetObject("btn_themNV.BackgroundImage");
            btn_themNV.BackgroundImageLayout = ImageLayout.Stretch;
            btn_themNV.Location = new Point(1453, 73);
            btn_themNV.Margin = new Padding(3, 4, 3, 4);
            btn_themNV.Name = "btn_themNV";
            btn_themNV.Size = new Size(71, 58);
            btn_themNV.TabIndex = 77;
            btn_themNV.UseVisualStyleBackColor = true;
            btn_themNV.Click += btn_themNV_Click;
            // 
            // dtpNgayvaolam
            // 
            dtpNgayvaolam.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayvaolam.CustomFormat = "dd/MM/yyyy";
            dtpNgayvaolam.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgayvaolam.Format = DateTimePickerFormat.Custom;
            dtpNgayvaolam.Location = new Point(763, 276);
            dtpNgayvaolam.Name = "dtpNgayvaolam";
            dtpNgayvaolam.Size = new Size(383, 38);
            dtpNgayvaolam.TabIndex = 72;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(565, 284);
            label1.Name = "label1";
            label1.Size = new Size(154, 31);
            label1.TabIndex = 71;
            label1.Text = "Ngày vào làm";
            // 
            // lbmk
            // 
            lbmk.AutoSize = true;
            lbmk.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbmk.Location = new Point(565, 195);
            lbmk.Name = "lbmk";
            lbmk.Size = new Size(110, 31);
            lbmk.TabIndex = 70;
            lbmk.Text = "Mật khẩu";
            // 
            // txtmatkhau
            // 
            txtmatkhau.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtmatkhau.Location = new Point(763, 191);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.PasswordChar = '*';
            txtmatkhau.Size = new Size(383, 38);
            txtmatkhau.TabIndex = 69;
            // 
            // lbtentk
            // 
            lbtentk.AutoSize = true;
            lbtentk.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbtentk.Location = new Point(565, 118);
            lbtentk.Name = "lbtentk";
            lbtentk.Size = new Size(109, 31);
            lbtentk.TabIndex = 68;
            lbtentk.Text = "Tài khoản";
            // 
            // txttentk
            // 
            txttentk.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttentk.Location = new Point(763, 114);
            txttentk.Name = "txttentk";
            txttentk.Size = new Size(383, 38);
            txttentk.TabIndex = 67;
            // 
            // lbcccd
            // 
            lbcccd.AutoSize = true;
            lbcccd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbcccd.Location = new Point(12, 300);
            lbcccd.Name = "lbcccd";
            lbcccd.Size = new Size(96, 28);
            lbcccd.TabIndex = 66;
            lbcccd.Text = "số CMND";
            // 
            // txtCccd
            // 
            txtCccd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCccd.Location = new Point(141, 295);
            txtCccd.Name = "txtCccd";
            txtCccd.Size = new Size(382, 34);
            txtCccd.TabIndex = 65;
            // 
            // lbdiachi
            // 
            lbdiachi.AutoSize = true;
            lbdiachi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbdiachi.Location = new Point(12, 232);
            lbdiachi.Name = "lbdiachi";
            lbdiachi.Size = new Size(71, 28);
            lbdiachi.TabIndex = 64;
            lbdiachi.Text = "Địa chỉ";
            // 
            // txtdiachi
            // 
            txtdiachi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdiachi.Location = new Point(141, 227);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(382, 34);
            txtdiachi.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 166);
            label3.Name = "label3";
            label3.Size = new Size(47, 28);
            label3.TabIndex = 62;
            label3.Text = "SĐT";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(141, 161);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(382, 34);
            txtSDT.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 60;
            label2.Text = "Tên NV";
            // 
            // txttenNV
            // 
            txttenNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttenNV.Location = new Point(141, 99);
            txttenNV.Name = "txttenNV";
            txttenNV.Size = new Size(382, 34);
            txttenNV.TabIndex = 59;
            // 
            // lbmanv
            // 
            lbmanv.AutoSize = true;
            lbmanv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbmanv.Location = new Point(12, 43);
            lbmanv.Name = "lbmanv";
            lbmanv.Size = new Size(72, 28);
            lbmanv.TabIndex = 57;
            lbmanv.Text = "Mã NV";
            // 
            // txtmanv
            // 
            txtmanv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtmanv.Location = new Point(141, 38);
            txtmanv.Name = "txtmanv";
            txtmanv.Size = new Size(382, 34);
            txtmanv.TabIndex = 56;
            // 
            // Form_QuanLyNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1597, 734);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form_QuanLyNV";
            Text = "Form_QuanLyNV";
            Load += Form_QuanLyNV_Load;
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbhinhanh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private GroupBox groupBox4;
        private DataGridView dgvnhanvien;
        private GroupBox groupBox2;
        private ComboBox cbolocDU;
        private TextBox txttimkiem;
        private Panel panel1;
        private GroupBox groupBox1;
        private RadioButton rbtnghilam;
        private RadioButton rbtdanglam;
        private Label label4;
        private Button btn_Reset;
        private GroupBox groupBox7;
        private RadioButton rdonu;
        private RadioButton rdoNam;
        private Label lbgioitinh;
        private GroupBox groupBox6;
        private RadioButton rdoquanly;
        private RadioButton rdoNhanvien;
        private Label label10;
        private GroupBox groupBox3;
        private Button btn_anh;
        private PictureBox pbhinhanh;
        private Button btn_LoadDGV;
        private Button btn_suaNV;
        private Button btn_themNV;
        private DateTimePicker dtpNgayvaolam;
        private Label label1;
        private Label lbmk;
        private TextBox txtmatkhau;
        private Label lbtentk;
        private TextBox txttentk;
        private Label lbcccd;
        private TextBox txtCccd;
        private Label lbdiachi;
        private TextBox txtdiachi;
        private Label label3;
        private TextBox txtSDT;
        private Label label2;
        private TextBox txttenNV;
        private Label lbmanv;
        private TextBox txtmanv;
    }
}