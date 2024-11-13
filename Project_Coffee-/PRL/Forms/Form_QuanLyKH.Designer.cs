namespace DuAn1_Coffe.PRL.Forms
{
    partial class Form_QuanLyKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyKH));
            txttimkiemkhachhang = new TextBox();
            dgvkhachhang = new DataGridView();
            btn_Reset = new Button();
            btn_Load = new Button();
            rbtNu = new RadioButton();
            rbtNam = new RadioButton();
            lbtrangthaii = new Label();
            btn_suaKH = new Button();
            btn_themKH = new Button();
            lbdiachi = new Label();
            groupBox3 = new GroupBox();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            txtdiachi = new TextBox();
            lbsdt = new Label();
            label2 = new Label();
            txttenkh = new TextBox();
            lbmakh = new Label();
            txtmakh = new TextBox();
            groupBox1 = new GroupBox();
            txtsdt = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvkhachhang).BeginInit();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txttimkiemkhachhang
            // 
            txttimkiemkhachhang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkiemkhachhang.Location = new Point(94, 21);
            txttimkiemkhachhang.Name = "txttimkiemkhachhang";
            txttimkiemkhachhang.PlaceholderText = "Tìm kiếm";
            txttimkiemkhachhang.Size = new Size(234, 30);
            txttimkiemkhachhang.TabIndex = 67;
            txttimkiemkhachhang.TextChanged += txttimkiemkhachhang_TextChanged;
            // 
            // dgvkhachhang
            // 
            dgvkhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvkhachhang.BackgroundColor = SystemColors.ButtonHighlight;
            dgvkhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvkhachhang.Dock = DockStyle.Fill;
            dgvkhachhang.Location = new Point(3, 26);
            dgvkhachhang.Name = "dgvkhachhang";
            dgvkhachhang.RowHeadersWidth = 51;
            dgvkhachhang.RowTemplate.Height = 80;
            dgvkhachhang.Size = new Size(1462, 268);
            dgvkhachhang.TabIndex = 0;
            dgvkhachhang.CellClick += dgvkhachhang_CellClick;
            dgvkhachhang.CellContentClick += dgvkhachhang_CellContentClick;
            // 
            // btn_Reset
            // 
            btn_Reset.BackgroundImage = (Image)resources.GetObject("btn_Reset.BackgroundImage");
            btn_Reset.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Reset.Location = new Point(1339, 201);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(67, 61);
            btn_Reset.TabIndex = 80;
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Load
            // 
            btn_Load.BackgroundImage = (Image)resources.GetObject("btn_Load.BackgroundImage");
            btn_Load.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Load.Location = new Point(1341, 291);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(67, 56);
            btn_Load.TabIndex = 79;
            btn_Load.UseVisualStyleBackColor = true;
            btn_Load.Click += btn_Load_Click;
            // 
            // rbtNu
            // 
            rbtNu.AutoSize = true;
            rbtNu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtNu.Location = new Point(1118, 251);
            rbtNu.Name = "rbtNu";
            rbtNu.Size = new Size(66, 35);
            rbtNu.TabIndex = 78;
            rbtNu.TabStop = true;
            rbtNu.Text = "Nữ";
            rbtNu.UseVisualStyleBackColor = true;
            // 
            // rbtNam
            // 
            rbtNam.AutoSize = true;
            rbtNam.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtNam.Location = new Point(905, 253);
            rbtNam.Name = "rbtNam";
            rbtNam.Size = new Size(84, 35);
            rbtNam.TabIndex = 77;
            rbtNam.TabStop = true;
            rbtNam.Text = "Nam";
            rbtNam.UseVisualStyleBackColor = true;
            // 
            // lbtrangthaii
            // 
            lbtrangthaii.AutoSize = true;
            lbtrangthaii.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbtrangthaii.Location = new Point(715, 255);
            lbtrangthaii.Name = "lbtrangthaii";
            lbtrangthaii.Size = new Size(102, 31);
            lbtrangthaii.TabIndex = 76;
            lbtrangthaii.Text = "Giới tính";
            // 
            // btn_suaKH
            // 
            btn_suaKH.BackgroundImage = (Image)resources.GetObject("btn_suaKH.BackgroundImage");
            btn_suaKH.BackgroundImageLayout = ImageLayout.Stretch;
            btn_suaKH.Location = new Point(1339, 112);
            btn_suaKH.Margin = new Padding(3, 4, 3, 4);
            btn_suaKH.Name = "btn_suaKH";
            btn_suaKH.Size = new Size(69, 58);
            btn_suaKH.TabIndex = 66;
            btn_suaKH.UseVisualStyleBackColor = true;
            btn_suaKH.Click += btn_suaKH_Click;
            // 
            // btn_themKH
            // 
            btn_themKH.BackgroundImage = (Image)resources.GetObject("btn_themKH.BackgroundImage");
            btn_themKH.BackgroundImageLayout = ImageLayout.Stretch;
            btn_themKH.Location = new Point(1339, 29);
            btn_themKH.Margin = new Padding(3, 4, 3, 4);
            btn_themKH.Name = "btn_themKH";
            btn_themKH.Size = new Size(69, 60);
            btn_themKH.TabIndex = 65;
            btn_themKH.UseVisualStyleBackColor = true;
            btn_themKH.Click += btn_themKH_Click;
            // 
            // lbdiachi
            // 
            lbdiachi.AutoSize = true;
            lbdiachi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbdiachi.Location = new Point(715, 154);
            lbdiachi.Name = "lbdiachi";
            lbdiachi.Size = new Size(84, 31);
            lbdiachi.TabIndex = 64;
            lbdiachi.Text = "Địa chỉ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvkhachhang);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 57);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1468, 297);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin khách hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 380);
            panel2.Name = "panel2";
            panel2.Size = new Size(1468, 354);
            panel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(txttimkiemkhachhang);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1468, 57);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // txtdiachi
            // 
            txtdiachi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtdiachi.Location = new Point(844, 149);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(367, 38);
            txtdiachi.TabIndex = 63;
            // 
            // lbsdt
            // 
            lbsdt.AutoSize = true;
            lbsdt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbsdt.Location = new Point(715, 58);
            lbsdt.Name = "lbsdt";
            lbsdt.Size = new Size(54, 31);
            lbsdt.TabIndex = 62;
            lbsdt.Text = "SĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(94, 150);
            label2.Name = "label2";
            label2.Size = new Size(84, 31);
            label2.TabIndex = 60;
            label2.Text = "Tên KH";
            // 
            // txttenkh
            // 
            txttenkh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttenkh.Location = new Point(222, 145);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(369, 38);
            txttenkh.TabIndex = 59;
            // 
            // lbmakh
            // 
            lbmakh.AutoSize = true;
            lbmakh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbmakh.Location = new Point(94, 58);
            lbmakh.Name = "lbmakh";
            lbmakh.Size = new Size(82, 31);
            lbmakh.TabIndex = 58;
            lbmakh.Text = "Mã KH";
            // 
            // txtmakh
            // 
            txtmakh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtmakh.Location = new Point(222, 52);
            txtmakh.Name = "txtmakh";
            txtmakh.Size = new Size(369, 38);
            txtmakh.TabIndex = 57;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PapayaWhip;
            groupBox1.Controls.Add(btn_Reset);
            groupBox1.Controls.Add(btn_Load);
            groupBox1.Controls.Add(rbtNu);
            groupBox1.Controls.Add(rbtNam);
            groupBox1.Controls.Add(lbtrangthaii);
            groupBox1.Controls.Add(btn_suaKH);
            groupBox1.Controls.Add(btn_themKH);
            groupBox1.Controls.Add(lbdiachi);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(lbsdt);
            groupBox1.Controls.Add(txtsdt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txttenkh);
            groupBox1.Controls.Add(lbmakh);
            groupBox1.Controls.Add(txtmakh);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1468, 377);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Khách hàng";
            // 
            // txtsdt
            // 
            txtsdt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtsdt.Location = new Point(844, 52);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(367, 38);
            txtsdt.TabIndex = 61;
            txtsdt.TextChanged += txtsdt_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1468, 380);
            panel1.TabIndex = 2;
            // 
            // Form_QuanLyKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 734);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form_QuanLyKH";
            Text = "Form_QuanLyKH";
            Load += Form_QuanLyKH_Load;
            ((System.ComponentModel.ISupportInitialize)dgvkhachhang).EndInit();
            groupBox3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txttimkiemkhachhang;
        private DataGridView dgvkhachhang;
        private Button btn_Reset;
        private Button btn_Load;
        private RadioButton rbtNu;
        private RadioButton rbtNam;
        private Label lbtrangthaii;
        private Button btn_suaKH;
        private Button btn_themKH;
        private Label lbdiachi;
        private GroupBox groupBox3;
        private Panel panel2;
        private GroupBox groupBox2;
        private TextBox txtdiachi;
        private Label lbsdt;
        private Label label2;
        private TextBox txttenkh;
        private Label lbmakh;
        private TextBox txtmakh;
        private GroupBox groupBox1;
        private TextBox txtsdt;
        private Panel panel1;
    }
}