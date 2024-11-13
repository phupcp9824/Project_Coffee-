namespace DuAn1_Coffe.PRL.Forms
{
    partial class Form_Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            panel5 = new Panel();
            groupBox6 = new GroupBox();
            dgvhoadonct = new DataGridView();
            panel4 = new Panel();
            groupBox5 = new GroupBox();
            dgvsanpham = new DataGridView();
            panel3 = new Panel();
            groupBox4 = new GroupBox();
            btn_tatcam = new Button();
            btn_batcam = new Button();
            btn_Xoasp = new Button();
            txttimkiem = new TextBox();
            panel2 = new Panel();
            groupBox7 = new GroupBox();
            txt_idHD = new TextBox();
            button1 = new Button();
            txtMas = new TextBox();
            txtmahd = new TextBox();
            txtGhiChu = new TextBox();
            txttiengiam = new TextBox();
            cboGiamGia = new ComboBox();
            label17 = new Label();
            label16 = new Label();
            label14 = new Label();
            txtTienKhachdua = new TextBox();
            lbTienThua = new Label();
            lbThanhToan = new Label();
            lbTongTien = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtIdHoaDon = new TextBox();
            cbbnhanvien = new ComboBox();
            btn_huydon = new Button();
            btn_thanhtoan = new Button();
            btn_taohoadon = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            dgvdanhsachhoadon = new DataGridView();
            groupBox2 = new GroupBox();
            cbo_Cam = new ComboBox();
            ptb_Image = new PictureBox();
            groupBox3 = new GroupBox();
            cboid = new ComboBox();
            txtidmax = new TextBox();
            txtTenKH = new TextBox();
            txtMaKh = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_thaydoi = new Button();
            btn_chon = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pdhd = new System.Drawing.Printing.PrintDocument();
            ppdhd = new PrintPreviewDialog();
            panel5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoadonct).BeginInit();
            panel4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).BeginInit();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            groupBox7.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdanhsachhoadon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Image).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSalmon;
            panel5.Controls.Add(groupBox6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 639);
            panel5.Name = "panel5";
            panel5.Size = new Size(1035, 334);
            panel5.TabIndex = 9;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvhoadonct);
            groupBox6.Dock = DockStyle.Left;
            groupBox6.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.Location = new Point(0, 0);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1023, 334);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Hóa đơn chi tiết";
            // 
            // dgvhoadonct
            // 
            dgvhoadonct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvhoadonct.BackgroundColor = SystemColors.ButtonFace;
            dgvhoadonct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoadonct.Location = new Point(5, 26);
            dgvhoadonct.Margin = new Padding(2);
            dgvhoadonct.Name = "dgvhoadonct";
            dgvhoadonct.RowHeadersWidth = 82;
            dgvhoadonct.RowTemplate.Height = 41;
            dgvhoadonct.Size = new Size(1013, 301);
            dgvhoadonct.TabIndex = 0;
            dgvhoadonct.CellClick += dgvhoadonct_CellClick;
            dgvhoadonct.CellEndEdit += dgvhoadonct_CellEndEdit;
            dgvhoadonct.CellValueChanged += dgvhoadonct_CellValueChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSalmon;
            panel4.Controls.Add(groupBox5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 276);
            panel4.Name = "panel4";
            panel4.Size = new Size(1035, 363);
            panel4.TabIndex = 8;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgvsanpham);
            groupBox5.Dock = DockStyle.Left;
            groupBox5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1026, 363);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách sản phẩm";
            // 
            // dgvsanpham
            // 
            dgvsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsanpham.BackgroundColor = SystemColors.ButtonFace;
            dgvsanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsanpham.Dock = DockStyle.Fill;
            dgvsanpham.Location = new Point(3, 26);
            dgvsanpham.Name = "dgvsanpham";
            dgvsanpham.RowHeadersWidth = 51;
            dgvsanpham.RowTemplate.Height = 80;
            dgvsanpham.Size = new Size(1020, 334);
            dgvsanpham.TabIndex = 0;
            dgvsanpham.CellContentClick += dgvsanpham_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSalmon;
            panel3.Controls.Add(groupBox4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 228);
            panel3.Name = "panel3";
            panel3.Size = new Size(1035, 48);
            panel3.TabIndex = 7;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.DarkSalmon;
            groupBox4.Controls.Add(btn_tatcam);
            groupBox4.Controls.Add(btn_batcam);
            groupBox4.Controls.Add(btn_Xoasp);
            groupBox4.Controls.Add(txttimkiem);
            groupBox4.Dock = DockStyle.Left;
            groupBox4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1026, 48);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // btn_tatcam
            // 
            btn_tatcam.Location = new Point(937, 14);
            btn_tatcam.Name = "btn_tatcam";
            btn_tatcam.Size = new Size(86, 29);
            btn_tatcam.TabIndex = 14;
            btn_tatcam.Text = "Tắt cam";
            btn_tatcam.UseVisualStyleBackColor = true;
            btn_tatcam.Click += btn_tatcam_Click;
            // 
            // btn_batcam
            // 
            btn_batcam.Location = new Point(833, 14);
            btn_batcam.Name = "btn_batcam";
            btn_batcam.Size = new Size(86, 29);
            btn_batcam.TabIndex = 13;
            btn_batcam.Text = "Bật cam";
            btn_batcam.UseVisualStyleBackColor = true;
            btn_batcam.Click += btn_batcam_Click;
            // 
            // btn_Xoasp
            // 
            btn_Xoasp.Location = new Point(423, 16);
            btn_Xoasp.Name = "btn_Xoasp";
            btn_Xoasp.Size = new Size(70, 29);
            btn_Xoasp.TabIndex = 12;
            btn_Xoasp.Text = "Xóa";
            btn_Xoasp.UseVisualStyleBackColor = true;
            btn_Xoasp.Click += btn_Xoasp_Click;
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txttimkiem.Location = new Point(83, 15);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.PlaceholderText = "Tìm kiếm";
            txttimkiem.Size = new Size(184, 28);
            txttimkiem.TabIndex = 10;
            txttimkiem.TextChanged += txttimkiem_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox7);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1035, 228);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 745);
            panel2.TabIndex = 6;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = SystemColors.ActiveCaption;
            groupBox7.Controls.Add(txt_idHD);
            groupBox7.Controls.Add(button1);
            groupBox7.Controls.Add(txtMas);
            groupBox7.Controls.Add(txtmahd);
            groupBox7.Controls.Add(txtGhiChu);
            groupBox7.Controls.Add(txttiengiam);
            groupBox7.Controls.Add(cboGiamGia);
            groupBox7.Controls.Add(label17);
            groupBox7.Controls.Add(label16);
            groupBox7.Controls.Add(label14);
            groupBox7.Controls.Add(txtTienKhachdua);
            groupBox7.Controls.Add(lbTienThua);
            groupBox7.Controls.Add(lbThanhToan);
            groupBox7.Controls.Add(lbTongTien);
            groupBox7.Controls.Add(label13);
            groupBox7.Controls.Add(label12);
            groupBox7.Controls.Add(label11);
            groupBox7.Controls.Add(label10);
            groupBox7.Controls.Add(label9);
            groupBox7.Controls.Add(label8);
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(txtIdHoaDon);
            groupBox7.Controls.Add(cbbnhanvien);
            groupBox7.Controls.Add(btn_huydon);
            groupBox7.Controls.Add(btn_thanhtoan);
            groupBox7.Controls.Add(btn_taohoadon);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox7.Location = new Point(0, 0);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(520, 745);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            groupBox7.Text = "Thông tin hóa đơn";
            // 
            // txt_idHD
            // 
            txt_idHD.Location = new Point(277, 15);
            txt_idHD.Name = "txt_idHD";
            txt_idHD.Size = new Size(35, 34);
            txt_idHD.TabIndex = 100;
            txt_idHD.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(109, 684);
            button1.Name = "button1";
            button1.Size = new Size(147, 54);
            button1.TabIndex = 99;
            button1.Text = "Lưu Hóa Đơn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtMas
            // 
            txtMas.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMas.Location = new Point(201, 20);
            txtMas.Margin = new Padding(2);
            txtMas.Name = "txtMas";
            txtMas.Size = new Size(48, 27);
            txtMas.TabIndex = 98;
            txtMas.Visible = false;
            // 
            // txtmahd
            // 
            txtmahd.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtmahd.Location = new Point(362, 20);
            txtmahd.Margin = new Padding(2);
            txtmahd.Name = "txtmahd";
            txtmahd.Size = new Size(26, 27);
            txtmahd.TabIndex = 97;
            txtmahd.Visible = false;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGhiChu.Location = new Point(54, 437);
            txtGhiChu.Margin = new Padding(2);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(393, 106);
            txtGhiChu.TabIndex = 87;
            // 
            // txttiengiam
            // 
            txttiengiam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txttiengiam.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txttiengiam.Location = new Point(235, 166);
            txttiengiam.Margin = new Padding(2);
            txttiengiam.Name = "txttiengiam";
            txttiengiam.ReadOnly = true;
            txttiengiam.Size = new Size(209, 27);
            txttiengiam.TabIndex = 96;
            // 
            // cboGiamGia
            // 
            cboGiamGia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboGiamGia.FormattingEnabled = true;
            cboGiamGia.Location = new Point(234, 126);
            cboGiamGia.Margin = new Padding(2);
            cboGiamGia.Name = "cboGiamGia";
            cboGiamGia.Size = new Size(210, 33);
            cboGiamGia.TabIndex = 95;
            cboGiamGia.SelectedIndexChanged += cboGiamGia_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(385, 343);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(62, 25);
            label17.TabIndex = 94;
            label17.Text = "VNĐ";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(390, 223);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(62, 25);
            label16.TabIndex = 93;
            label16.Text = "VNĐ";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(391, 77);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(62, 25);
            label14.TabIndex = 92;
            label14.Text = "VNĐ";
            // 
            // txtTienKhachdua
            // 
            txtTienKhachdua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTienKhachdua.Location = new Point(234, 271);
            txtTienKhachdua.Margin = new Padding(2);
            txtTienKhachdua.Name = "txtTienKhachdua";
            txtTienKhachdua.Size = new Size(210, 34);
            txtTienKhachdua.TabIndex = 91;
            txtTienKhachdua.TextChanged += txtTienKhachdua_TextChanged;
            // 
            // lbTienThua
            // 
            lbTienThua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTienThua.AutoSize = true;
            lbTienThua.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTienThua.Location = new Point(228, 345);
            lbTienThua.Margin = new Padding(2, 0, 2, 0);
            lbTienThua.Name = "lbTienThua";
            lbTienThua.Size = new Size(24, 25);
            lbTienThua.TabIndex = 89;
            lbTienThua.Text = "0";
            lbTienThua.TextChanged += lbTienThua_TextChanged;
            lbTienThua.Click += lbTienThua_Click;
            // 
            // lbThanhToan
            // 
            lbThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbThanhToan.AutoSize = true;
            lbThanhToan.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbThanhToan.Location = new Point(232, 219);
            lbThanhToan.Margin = new Padding(2, 0, 2, 0);
            lbThanhToan.Name = "lbThanhToan";
            lbThanhToan.Size = new Size(24, 25);
            lbThanhToan.TabIndex = 90;
            lbThanhToan.Text = "0";
            // 
            // lbTongTien
            // 
            lbTongTien.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTongTien.AutoSize = true;
            lbTongTien.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongTien.Location = new Point(233, 74);
            lbTongTien.Margin = new Padding(2, 0, 2, 0);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(24, 25);
            lbTongTien.TabIndex = 88;
            lbTongTien.Text = "0";
            lbTongTien.Click += lbTongTien_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(63, 398);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(98, 26);
            label13.TabIndex = 86;
            label13.Text = "Ghi chú :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(54, 342);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(111, 26);
            label12.TabIndex = 85;
            label12.Text = "Tiền thừa :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(51, 275);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(167, 26);
            label11.TabIndex = 84;
            label11.Text = "Tiền khách đưa :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(54, 223);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(130, 26);
            label10.TabIndex = 83;
            label10.Text = "Thanh toán :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(54, 134);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(107, 26);
            label9.TabIndex = 82;
            label9.Text = "Giảm giá :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(54, 74);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(113, 26);
            label8.TabIndex = 81;
            label8.Text = "Tổng tiền :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(86, 282);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 26);
            label7.TabIndex = 80;
            // 
            // txtIdHoaDon
            // 
            txtIdHoaDon.Location = new Point(442, 15);
            txtIdHoaDon.Margin = new Padding(2);
            txtIdHoaDon.Name = "txtIdHoaDon";
            txtIdHoaDon.Size = new Size(44, 34);
            txtIdHoaDon.TabIndex = 11;
            txtIdHoaDon.Visible = false;
            // 
            // cbbnhanvien
            // 
            cbbnhanvien.FormattingEnabled = true;
            cbbnhanvien.Location = new Point(54, 547);
            cbbnhanvien.Margin = new Padding(2);
            cbbnhanvien.Name = "cbbnhanvien";
            cbbnhanvien.Size = new Size(61, 33);
            cbbnhanvien.TabIndex = 79;
            cbbnhanvien.Visible = false;
            // 
            // btn_huydon
            // 
            btn_huydon.BackColor = Color.MediumTurquoise;
            btn_huydon.Location = new Point(306, 684);
            btn_huydon.Name = "btn_huydon";
            btn_huydon.Size = new Size(138, 54);
            btn_huydon.TabIndex = 76;
            btn_huydon.Text = "Hủy đơn";
            btn_huydon.UseVisualStyleBackColor = false;
            btn_huydon.Click += btn_huydon_Click;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.BackColor = Color.MediumTurquoise;
            btn_thanhtoan.Location = new Point(306, 605);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(138, 60);
            btn_thanhtoan.TabIndex = 74;
            btn_thanhtoan.Text = "Thanh toán";
            btn_thanhtoan.UseVisualStyleBackColor = false;
            btn_thanhtoan.Click += btn_thanhtoan_Click;
            // 
            // btn_taohoadon
            // 
            btn_taohoadon.BackColor = Color.MediumTurquoise;
            btn_taohoadon.Location = new Point(109, 605);
            btn_taohoadon.Name = "btn_taohoadon";
            btn_taohoadon.Size = new Size(147, 60);
            btn_taohoadon.TabIndex = 73;
            btn_taohoadon.Text = "Tạo đơn";
            btn_taohoadon.UseVisualStyleBackColor = false;
            btn_taohoadon.Click += btn_taohoadon_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1555, 228);
            panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSalmon;
            groupBox1.Controls.Add(dgvdanhsachhoadon);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1035, 228);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dgvdanhsachhoadon
            // 
            dgvdanhsachhoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdanhsachhoadon.BackgroundColor = SystemColors.ButtonFace;
            dgvdanhsachhoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdanhsachhoadon.Dock = DockStyle.Left;
            dgvdanhsachhoadon.Location = new Point(3, 23);
            dgvdanhsachhoadon.Name = "dgvdanhsachhoadon";
            dgvdanhsachhoadon.RowHeadersWidth = 51;
            dgvdanhsachhoadon.Size = new Size(811, 202);
            dgvdanhsachhoadon.TabIndex = 2;
            dgvdanhsachhoadon.CellClick += dgvdanhsachhoadon_CellClick;
            dgvdanhsachhoadon.CellDoubleClick += dgvdanhsachhoadon_CellDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbo_Cam);
            groupBox2.Controls.Add(ptb_Image);
            groupBox2.Location = new Point(820, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(206, 208);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // cbo_Cam
            // 
            cbo_Cam.FormattingEnabled = true;
            cbo_Cam.Location = new Point(54, 181);
            cbo_Cam.Name = "cbo_Cam";
            cbo_Cam.Size = new Size(113, 27);
            cbo_Cam.TabIndex = 13;
            cbo_Cam.Text = "Chọn cam";
            // 
            // ptb_Image
            // 
            ptb_Image.BackColor = SystemColors.ActiveCaptionText;
            ptb_Image.BorderStyle = BorderStyle.FixedSingle;
            ptb_Image.Location = new Point(6, 14);
            ptb_Image.Name = "ptb_Image";
            ptb_Image.Size = new Size(192, 161);
            ptb_Image.SizeMode = PictureBoxSizeMode.Zoom;
            ptb_Image.TabIndex = 0;
            ptb_Image.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Khaki;
            groupBox3.Controls.Add(cboid);
            groupBox3.Controls.Add(txtidmax);
            groupBox3.Controls.Add(txtTenKH);
            groupBox3.Controls.Add(txtMaKh);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(btn_thaydoi);
            groupBox3.Controls.Add(btn_chon);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(1035, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(520, 228);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khách hàng";
            // 
            // cboid
            // 
            cboid.FormattingEnabled = true;
            cboid.Location = new Point(336, 11);
            cboid.Margin = new Padding(2);
            cboid.Name = "cboid";
            cboid.Size = new Size(34, 27);
            cboid.TabIndex = 17;
            cboid.Visible = false;
            // 
            // txtidmax
            // 
            txtidmax.Location = new Point(51, 179);
            txtidmax.Margin = new Padding(2);
            txtidmax.Name = "txtidmax";
            txtidmax.Size = new Size(31, 27);
            txtidmax.TabIndex = 16;
            txtidmax.Visible = false;
            // 
            // txtTenKH
            // 
            txtTenKH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTenKH.Location = new Point(123, 125);
            txtTenKH.Margin = new Padding(2);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.ReadOnly = true;
            txtTenKH.Size = new Size(237, 27);
            txtTenKH.TabIndex = 14;
            // 
            // txtMaKh
            // 
            txtMaKh.Location = new Point(123, 61);
            txtMaKh.Margin = new Padding(2);
            txtMaKh.Name = "txtMaKh";
            txtMaKh.ReadOnly = true;
            txtMaKh.Size = new Size(237, 27);
            txtMaKh.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 67);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 22);
            label1.TabIndex = 12;
            label1.Text = "Mã KH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 130);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 22);
            label2.TabIndex = 11;
            label2.Text = "Tên KH";
            // 
            // btn_thaydoi
            // 
            btn_thaydoi.Location = new Point(404, 114);
            btn_thaydoi.Name = "btn_thaydoi";
            btn_thaydoi.Size = new Size(82, 36);
            btn_thaydoi.TabIndex = 9;
            btn_thaydoi.Text = "Thay đổi";
            btn_thaydoi.UseVisualStyleBackColor = true;
            btn_thaydoi.Click += btn_thaydoi_Click;
            // 
            // btn_chon
            // 
            btn_chon.Location = new Point(404, 60);
            btn_chon.Name = "btn_chon";
            btn_chon.Size = new Size(82, 36);
            btn_chon.TabIndex = 8;
            btn_chon.Text = "Chọn ";
            btn_chon.UseVisualStyleBackColor = true;
            btn_chon.Click += btn_chon_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pdhd
            // 
            pdhd.PrintPage += pdhd_PrintPage;
            // 
            // ppdhd
            // 
            ppdhd.AutoScrollMargin = new Size(0, 0);
            ppdhd.AutoScrollMinSize = new Size(0, 0);
            ppdhd.ClientSize = new Size(400, 300);
            ppdhd.Enabled = true;
            ppdhd.Icon = (Icon)resources.GetObject("ppdhd.Icon");
            ppdhd.Name = "ppdhd";
            ppdhd.Visible = false;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1555, 973);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form_Menu";
            Text = "Form_Menu";
            FormClosing += Form_Menu_FormClosing;
            Load += Form_Menu_Load;
            panel5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhoadonct).EndInit();
            panel4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).EndInit();
            panel3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdanhsachhoadon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptb_Image).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private GroupBox groupBox6;
        private Panel panel4;
        private GroupBox groupBox5;
        private DataGridView dgvsanpham;
        private Panel panel3;
        private GroupBox groupBox4;
        private Button btn_tatcam;
        private Button btn_batcam;
        private Button btn_Xoasp;
        private TextBox txttimkiem;
        private Panel panel2;
        private GroupBox groupBox7;
        private ComboBox cbbnhanvien;
        private Button btn_huydon;
        private Button btn_thanhtoan;
        private Button btn_taohoadon;
        private Panel panel1;
        private GroupBox groupBox1;
        private DataGridView dgvdanhsachhoadon;
        private GroupBox groupBox2;
        private ComboBox cbo_Cam;
        private PictureBox ptb_Image;
        private GroupBox groupBox3;
        private Button btn_thaydoi;
        private Button btn_chon;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dgvhoadonct;
        private TextBox txtIdHoaDon;
        private TextBox txtMas;
        private TextBox txtmahd;
        private TextBox txtGhiChu;
        private TextBox txttiengiam;
        private ComboBox cboGiamGia;
        private Label label17;
        private Label label16;
        private Label label14;
        private TextBox txtTienKhachdua;
        private Label lbTienThua;
        private Label lbThanhToan;
        private Label lbTongTien;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtidmax;
        private TextBox txtTenKH;
        private TextBox txtMaKh;
        private Label label1;
        private Label label2;
        private ComboBox cboid;
        private Button button1;
        private TextBox txt_idHD;
        private System.Drawing.Printing.PrintDocument pdhd;
        private PrintPreviewDialog ppdhd;
    }
}