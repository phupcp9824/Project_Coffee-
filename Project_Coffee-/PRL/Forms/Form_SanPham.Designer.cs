namespace DuAn1_Coffe.PRL.Forms
{
    partial class Form_SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SanPham));
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            cbolocDU = new ComboBox();
            txttimkimdouong = new TextBox();
            txttensp = new TextBox();
            label3 = new Label();
            txtsoluong = new TextBox();
            label2 = new Label();
            btn_LoadDU = new Button();
            btn_qr = new Button();
            cbomakm = new ComboBox();
            btn_Reset = new Button();
            txtmasp = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            btn_anh = new Button();
            pbhinhanh = new PictureBox();
            btn_suaDU = new Button();
            btn_themDU = new Button();
            rbtngungbanDU = new RadioButton();
            lbtrangthai = new Label();
            txtmotaDU = new TextBox();
            lbmota = new Label();
            txtdongia = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btn_LuuQR = new Button();
            rbtdangbanDU = new RadioButton();
            panel1 = new Panel();
            panel3 = new Panel();
            dgvsanpham = new DataGridView();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbhinhanh).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 449);
            panel2.Name = "panel2";
            panel2.Size = new Size(1476, 48);
            panel2.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Lavender;
            groupBox2.Controls.Add(cbolocDU);
            groupBox2.Controls.Add(txttimkimdouong);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1476, 48);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // cbolocDU
            // 
            cbolocDU.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbolocDU.FormattingEnabled = true;
            cbolocDU.Items.AddRange(new object[] { "Đang bán", "Ngừng bán" });
            cbolocDU.Location = new Point(1224, 15);
            cbolocDU.Name = "cbolocDU";
            cbolocDU.Size = new Size(203, 30);
            cbolocDU.TabIndex = 106;
            cbolocDU.Text = "Lọc";
            cbolocDU.SelectedIndexChanged += cbolocDU_SelectedIndexChanged;
            // 
            // txttimkimdouong
            // 
            txttimkimdouong.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkimdouong.Location = new Point(79, 15);
            txttimkimdouong.Name = "txttimkimdouong";
            txttimkimdouong.PlaceholderText = "Tìm kiếm";
            txttimkimdouong.Size = new Size(288, 30);
            txttimkimdouong.TabIndex = 105;
            txttimkimdouong.TextChanged += txttimkimdouong_TextChanged;
            // 
            // txttensp
            // 
            txttensp.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttensp.Location = new Point(168, 162);
            txttensp.Name = "txttensp";
            txttensp.Size = new Size(369, 38);
            txttensp.TabIndex = 120;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 168);
            label3.Name = "label3";
            label3.Size = new Size(80, 31);
            label3.TabIndex = 119;
            label3.Text = "Tên SP";
            // 
            // txtsoluong
            // 
            txtsoluong.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtsoluong.Location = new Point(711, 81);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(369, 38);
            txtsoluong.TabIndex = 118;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(594, 89);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
            label2.TabIndex = 117;
            label2.Text = "Số lượng";
            // 
            // btn_LoadDU
            // 
            btn_LoadDU.BackColor = SystemColors.ControlLightLight;
            btn_LoadDU.BackgroundImage = (Image)resources.GetObject("btn_LoadDU.BackgroundImage");
            btn_LoadDU.BackgroundImageLayout = ImageLayout.Stretch;
            btn_LoadDU.Location = new Point(1363, 343);
            btn_LoadDU.Margin = new Padding(3, 4, 3, 4);
            btn_LoadDU.Name = "btn_LoadDU";
            btn_LoadDU.Size = new Size(72, 57);
            btn_LoadDU.TabIndex = 116;
            btn_LoadDU.UseVisualStyleBackColor = false;
            btn_LoadDU.Click += btn_LoadDU_Click;
            // 
            // btn_qr
            // 
            btn_qr.BackColor = Color.Turquoise;
            btn_qr.Location = new Point(1108, 364);
            btn_qr.Name = "btn_qr";
            btn_qr.Size = new Size(92, 46);
            btn_qr.TabIndex = 128;
            btn_qr.Text = "Tạo QR";
            btn_qr.UseVisualStyleBackColor = false;
            btn_qr.Click += btn_qr_Click;
            // 
            // cbomakm
            // 
            cbomakm.FormattingEnabled = true;
            cbomakm.Location = new Point(1047, 273);
            cbomakm.Name = "cbomakm";
            cbomakm.Size = new Size(33, 31);
            cbomakm.TabIndex = 127;
            cbomakm.Visible = false;
            // 
            // btn_Reset
            // 
            btn_Reset.BackgroundImage = (Image)resources.GetObject("btn_Reset.BackgroundImage");
            btn_Reset.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Reset.Location = new Point(1363, 258);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(72, 60);
            btn_Reset.TabIndex = 126;
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // txtmasp
            // 
            txtmasp.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtmasp.Location = new Point(168, 68);
            txtmasp.Name = "txtmasp";
            txtmasp.Size = new Size(369, 38);
            txtmasp.TabIndex = 123;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 73);
            label4.Name = "label4";
            label4.Size = new Size(78, 31);
            label4.TabIndex = 122;
            label4.Text = "Mã SP";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_anh);
            groupBox4.Controls.Add(pbhinhanh);
            groupBox4.Location = new Point(1108, 81);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(208, 268);
            groupBox4.TabIndex = 121;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hình ảnh";
            // 
            // btn_anh
            // 
            btn_anh.BackColor = Color.DarkOrange;
            btn_anh.Location = new Point(63, 222);
            btn_anh.Name = "btn_anh";
            btn_anh.Size = new Size(94, 39);
            btn_anh.TabIndex = 1;
            btn_anh.Text = "Ảnh";
            btn_anh.UseVisualStyleBackColor = false;
            btn_anh.Click += btn_anh_Click;
            // 
            // pbhinhanh
            // 
            pbhinhanh.BackColor = SystemColors.ActiveCaptionText;
            pbhinhanh.Location = new Point(24, 29);
            pbhinhanh.Name = "pbhinhanh";
            pbhinhanh.Size = new Size(164, 183);
            pbhinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbhinhanh.TabIndex = 0;
            pbhinhanh.TabStop = false;
            // 
            // btn_suaDU
            // 
            btn_suaDU.BackgroundImage = (Image)resources.GetObject("btn_suaDU.BackgroundImage");
            btn_suaDU.BackgroundImageLayout = ImageLayout.Stretch;
            btn_suaDU.Location = new Point(1363, 172);
            btn_suaDU.Margin = new Padding(3, 4, 3, 4);
            btn_suaDU.Name = "btn_suaDU";
            btn_suaDU.Size = new Size(72, 64);
            btn_suaDU.TabIndex = 115;
            btn_suaDU.UseVisualStyleBackColor = true;
            btn_suaDU.Click += btn_suaDU_Click;
            // 
            // btn_themDU
            // 
            btn_themDU.BackgroundImage = (Image)resources.GetObject("btn_themDU.BackgroundImage");
            btn_themDU.BackgroundImageLayout = ImageLayout.Stretch;
            btn_themDU.Location = new Point(1363, 88);
            btn_themDU.Margin = new Padding(3, 4, 3, 4);
            btn_themDU.Name = "btn_themDU";
            btn_themDU.Size = new Size(72, 61);
            btn_themDU.TabIndex = 114;
            btn_themDU.UseVisualStyleBackColor = true;
            btn_themDU.Click += btn_themDU_Click;
            // 
            // rbtngungbanDU
            // 
            rbtngungbanDU.AutoSize = true;
            rbtngungbanDU.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtngungbanDU.Location = new Point(918, 320);
            rbtngungbanDU.Name = "rbtngungbanDU";
            rbtngungbanDU.Size = new Size(152, 35);
            rbtngungbanDU.TabIndex = 113;
            rbtngungbanDU.TabStop = true;
            rbtngungbanDU.Text = "Ngừng bán";
            rbtngungbanDU.UseVisualStyleBackColor = true;
            // 
            // lbtrangthai
            // 
            lbtrangthai.AutoSize = true;
            lbtrangthai.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbtrangthai.Location = new Point(594, 322);
            lbtrangthai.Name = "lbtrangthai";
            lbtrangthai.Size = new Size(116, 31);
            lbtrangthai.TabIndex = 111;
            lbtrangthai.Text = "Trạng thái";
            // 
            // txtmotaDU
            // 
            txtmotaDU.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtmotaDU.Location = new Point(720, 201);
            txtmotaDU.Name = "txtmotaDU";
            txtmotaDU.Size = new Size(360, 38);
            txtmotaDU.TabIndex = 110;
            // 
            // lbmota
            // 
            lbmota.AutoSize = true;
            lbmota.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbmota.Location = new Point(592, 205);
            lbmota.Name = "lbmota";
            lbmota.Size = new Size(74, 31);
            lbmota.TabIndex = 109;
            lbmota.Text = "Mô tả";
            // 
            // txtdongia
            // 
            txtdongia.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtdongia.Location = new Point(168, 258);
            txtdongia.Name = "txtdongia";
            txtdongia.Size = new Size(369, 38);
            txtdongia.TabIndex = 108;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 263);
            label1.Name = "label1";
            label1.Size = new Size(95, 31);
            label1.TabIndex = 107;
            label1.Text = "Đơn giá";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Lavender;
            groupBox1.Controls.Add(btn_LuuQR);
            groupBox1.Controls.Add(btn_qr);
            groupBox1.Controls.Add(cbomakm);
            groupBox1.Controls.Add(btn_Reset);
            groupBox1.Controls.Add(txtmasp);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(txttensp);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtsoluong);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btn_LoadDU);
            groupBox1.Controls.Add(btn_suaDU);
            groupBox1.Controls.Add(btn_themDU);
            groupBox1.Controls.Add(rbtngungbanDU);
            groupBox1.Controls.Add(rbtdangbanDU);
            groupBox1.Controls.Add(lbtrangthai);
            groupBox1.Controls.Add(txtmotaDU);
            groupBox1.Controls.Add(lbmota);
            groupBox1.Controls.Add(txtdongia);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1476, 449);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản Phẩm";
            // 
            // btn_LuuQR
            // 
            btn_LuuQR.BackColor = Color.Turquoise;
            btn_LuuQR.Location = new Point(1224, 364);
            btn_LuuQR.Name = "btn_LuuQR";
            btn_LuuQR.Size = new Size(92, 46);
            btn_LuuQR.TabIndex = 129;
            btn_LuuQR.Text = "Lưu QR";
            btn_LuuQR.UseVisualStyleBackColor = false;
            btn_LuuQR.Click += btn_LuuQR_Click;
            // 
            // rbtdangbanDU
            // 
            rbtdangbanDU.AutoSize = true;
            rbtdangbanDU.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtdangbanDU.Location = new Point(732, 320);
            rbtdangbanDU.Name = "rbtdangbanDU";
            rbtdangbanDU.Size = new Size(135, 35);
            rbtdangbanDU.TabIndex = 112;
            rbtdangbanDU.TabStop = true;
            rbtdangbanDU.Text = "Đang bán";
            rbtdangbanDU.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1476, 449);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvsanpham);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 497);
            panel3.Name = "panel3";
            panel3.Size = new Size(1476, 243);
            panel3.TabIndex = 5;
            // 
            // dgvsanpham
            // 
            dgvsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsanpham.BackgroundColor = SystemColors.ButtonHighlight;
            dgvsanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsanpham.Dock = DockStyle.Fill;
            dgvsanpham.Location = new Point(0, 0);
            dgvsanpham.Name = "dgvsanpham";
            dgvsanpham.RowHeadersWidth = 51;
            dgvsanpham.RowTemplate.Height = 80;
            dgvsanpham.Size = new Size(1476, 243);
            dgvsanpham.TabIndex = 0;
            dgvsanpham.CellClick += dgvsanpham_CellClick_1;
            // 
            // Form_SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 740);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form_SanPham";
            Text = "Form_SanPham";
            Load += Form_SanPham_Load;
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbhinhanh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvsanpham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private GroupBox groupBox2;
        private TextBox txttimkimdouong;
        private ComboBox cbolocDU;
        private TextBox txttensp;
        private Label label3;
        private TextBox txtsoluong;
        private Label label2;
        private Button btn_LoadDU;
        private Button btn_qr;
        private ComboBox cbomakm;
        private Button btn_Reset;
        private TextBox txtmasp;
        private Label label4;
        private GroupBox groupBox4;
        private Button btn_anh;
        private PictureBox pbhinhanh;
        private Button btn_suaDU;
        private Button btn_themDU;
        private RadioButton rbtngungbanDU;
        private Label lbtrangthai;
        private TextBox txtmotaDU;
        private Label lbmota;
        private TextBox txtdongia;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbtdangbanDU;
        private Panel panel1;
        private Panel panel3;
        private DataGridView dgvsanpham;
        private Button btn_LuuQR;
    }
}