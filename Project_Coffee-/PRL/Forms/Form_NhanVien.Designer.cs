namespace DuAn1_Coffe.PRL.Forms
{
    partial class Form_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NhanVien));
            panelchucang = new Panel();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            btn_khachhang = new Button();
            btn_hoadon = new Button();
            btn_banhang = new Button();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panelchucang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelchucang
            // 
            panelchucang.BackColor = Color.PeachPuff;
            panelchucang.Controls.Add(label4);
            panelchucang.Controls.Add(pictureBox3);
            panelchucang.Dock = DockStyle.Fill;
            panelchucang.Location = new Point(332, 41);
            panelchucang.Name = "panelchucang";
            panelchucang.Size = new Size(1237, 693);
            panelchucang.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.PeachPuff;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1492, 1250);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(429, 95);
            label4.TabIndex = 14;
            label4.Text = "Ngon đến giọt cuối cùng";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(331, 107);
            pictureBox3.Margin = new Padding(2, 3, 2, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(503, 448);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGoldenrodYellow;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(332, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1237, 41);
            panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 0);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGoldenrodYellow;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 13, 38);
            label3.Location = new Point(56, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(196, 20);
            label3.TabIndex = 4;
            label3.Text = "TRANG CHỦ - ADMIN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGoldenrodYellow;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_khachhang);
            panel1.Controls.Add(btn_hoadon);
            panel1.Controls.Add(btn_banhang);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 734);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 577);
            button1.Name = "button1";
            button1.Size = new Size(332, 109);
            button1.TabIndex = 9;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_khachhang
            // 
            btn_khachhang.BackColor = Color.DarkOrange;
            btn_khachhang.Dock = DockStyle.Top;
            btn_khachhang.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_khachhang.Location = new Point(0, 468);
            btn_khachhang.Name = "btn_khachhang";
            btn_khachhang.Size = new Size(332, 109);
            btn_khachhang.TabIndex = 5;
            btn_khachhang.Text = "Khách Hàng";
            btn_khachhang.UseVisualStyleBackColor = false;
            btn_khachhang.Click += btn_khachhang_Click;
            // 
            // btn_hoadon
            // 
            btn_hoadon.BackColor = Color.DarkOrange;
            btn_hoadon.Dock = DockStyle.Top;
            btn_hoadon.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_hoadon.Location = new Point(0, 359);
            btn_hoadon.Name = "btn_hoadon";
            btn_hoadon.Size = new Size(332, 109);
            btn_hoadon.TabIndex = 2;
            btn_hoadon.Text = "Hóa Đơn";
            btn_hoadon.UseVisualStyleBackColor = false;
            btn_hoadon.Click += btn_hoadon_Click;
            // 
            // btn_banhang
            // 
            btn_banhang.BackColor = Color.DarkOrange;
            btn_banhang.Dock = DockStyle.Top;
            btn_banhang.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_banhang.Location = new Point(0, 250);
            btn_banhang.Name = "btn_banhang";
            btn_banhang.Size = new Size(332, 109);
            btn_banhang.TabIndex = 1;
            btn_banhang.Text = "Bán Hàng";
            btn_banhang.UseVisualStyleBackColor = false;
            btn_banhang.Click += btn_banhang_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(332, 250);
            panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 9);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form_NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1569, 734);
            Controls.Add(panelchucang);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form_NhanVien";
            Text = "Form2_NhanVien";
            WindowState = FormWindowState.Maximized;
            Load += Form_NhanVien_Load;
            panelchucang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelchucang;
        private Label label4;
        private PictureBox pictureBox3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label3;
        private Panel panel1;
        private Button button1;
        private Button btn_khachhang;
        private Button btn_hoadon;
        private Button btn_banhang;
        private Panel panel4;
        private PictureBox pictureBox1;
    }
}