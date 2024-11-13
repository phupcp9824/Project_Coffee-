namespace DuAn1_Coffe.PRL.Forms
{
    partial class Form_DanhSachKH
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
            btn_Reset = new Button();
            btn_Thêm = new Button();
            rbtNu = new RadioButton();
            rbtNam = new RadioButton();
            lbtrangthaii = new Label();
            lbdiachi = new Label();
            txtdiachi = new TextBox();
            lbsdt = new Label();
            txtsdt = new TextBox();
            label2 = new Label();
            txttenkh = new TextBox();
            lbmakh = new Label();
            txtmakh = new TextBox();
            tpthemkh = new TabPage();
            groupBox2 = new GroupBox();
            label1 = new Label();
            txttimkiem = new TextBox();
            groupBox1 = new GroupBox();
            btn_chonn = new Button();
            dgvDSkhachhang = new DataGridView();
            tpthongtinkhachhang = new TabPage();
            tabdskhachhang = new TabControl();
            tpthemkh.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSkhachhang).BeginInit();
            tpthongtinkhachhang.SuspendLayout();
            tabdskhachhang.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Reset
            // 
            btn_Reset.BackColor = Color.LightSeaGreen;
            btn_Reset.Location = new Point(438, 459);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(109, 46);
            btn_Reset.TabIndex = 91;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = false;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Thêm
            // 
            btn_Thêm.BackColor = Color.LightSeaGreen;
            btn_Thêm.Location = new Point(285, 459);
            btn_Thêm.Name = "btn_Thêm";
            btn_Thêm.Size = new Size(109, 46);
            btn_Thêm.TabIndex = 90;
            btn_Thêm.Text = "Thêm";
            btn_Thêm.UseVisualStyleBackColor = false;
            btn_Thêm.Click += btn_Thêm_Click;
            // 
            // rbtNu
            // 
            rbtNu.AutoSize = true;
            rbtNu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtNu.Location = new Point(388, 378);
            rbtNu.Name = "rbtNu";
            rbtNu.Size = new Size(66, 35);
            rbtNu.TabIndex = 89;
            rbtNu.TabStop = true;
            rbtNu.Text = "Nữ";
            rbtNu.UseVisualStyleBackColor = true;
            // 
            // rbtNam
            // 
            rbtNam.AutoSize = true;
            rbtNam.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rbtNam.Location = new Point(270, 378);
            rbtNam.Name = "rbtNam";
            rbtNam.Size = new Size(84, 35);
            rbtNam.TabIndex = 88;
            rbtNam.TabStop = true;
            rbtNam.Text = "Nam";
            rbtNam.UseVisualStyleBackColor = true;
            // 
            // lbtrangthaii
            // 
            lbtrangthaii.AutoSize = true;
            lbtrangthaii.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbtrangthaii.Location = new Point(128, 378);
            lbtrangthaii.Name = "lbtrangthaii";
            lbtrangthaii.Size = new Size(102, 31);
            lbtrangthaii.TabIndex = 87;
            lbtrangthaii.Text = "Giới tính";
            // 
            // lbdiachi
            // 
            lbdiachi.AutoSize = true;
            lbdiachi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbdiachi.Location = new Point(130, 295);
            lbdiachi.Name = "lbdiachi";
            lbdiachi.Size = new Size(84, 31);
            lbdiachi.TabIndex = 86;
            lbdiachi.Text = "Địa chỉ";
            // 
            // txtdiachi
            // 
            txtdiachi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtdiachi.Location = new Point(259, 290);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(367, 38);
            txtdiachi.TabIndex = 85;
            // 
            // lbsdt
            // 
            lbsdt.AutoSize = true;
            lbsdt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbsdt.Location = new Point(130, 198);
            lbsdt.Name = "lbsdt";
            lbsdt.Size = new Size(54, 31);
            lbsdt.TabIndex = 84;
            lbsdt.Text = "SĐT";
            // 
            // txtsdt
            // 
            txtsdt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtsdt.Location = new Point(259, 193);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(367, 38);
            txtsdt.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(128, 126);
            label2.Name = "label2";
            label2.Size = new Size(84, 31);
            label2.TabIndex = 82;
            label2.Text = "Tên KH";
            // 
            // txttenkh
            // 
            txttenkh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttenkh.Location = new Point(257, 121);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(369, 38);
            txttenkh.TabIndex = 81;
            // 
            // lbmakh
            // 
            lbmakh.AutoSize = true;
            lbmakh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbmakh.Location = new Point(128, 48);
            lbmakh.Name = "lbmakh";
            lbmakh.Size = new Size(82, 31);
            lbmakh.TabIndex = 80;
            lbmakh.Text = "Mã KH";
            // 
            // txtmakh
            // 
            txtmakh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtmakh.Location = new Point(257, 42);
            txtmakh.Name = "txtmakh";
            txtmakh.Size = new Size(369, 38);
            txtmakh.TabIndex = 79;
            // 
            // tpthemkh
            // 
            tpthemkh.Controls.Add(groupBox2);
            tpthemkh.Location = new Point(4, 28);
            tpthemkh.Name = "tpthemkh";
            tpthemkh.Padding = new Padding(3);
            tpthemkh.Size = new Size(799, 554);
            tpthemkh.TabIndex = 1;
            tpthemkh.Text = "Thêm khách hàng";
            tpthemkh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btn_Reset);
            groupBox2.Controls.Add(btn_Thêm);
            groupBox2.Controls.Add(rbtNu);
            groupBox2.Controls.Add(rbtNam);
            groupBox2.Controls.Add(lbtrangthaii);
            groupBox2.Controls.Add(lbdiachi);
            groupBox2.Controls.Add(txtdiachi);
            groupBox2.Controls.Add(lbsdt);
            groupBox2.Controls.Add(txtsdt);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txttenkh);
            groupBox2.Controls.Add(lbmakh);
            groupBox2.Controls.Add(txtmakh);
            groupBox2.Location = new Point(-7, -1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(812, 554);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 2;
            label1.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkiem.Location = new Point(110, 22);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(264, 34);
            txttimkiem.TabIndex = 1;
            txttimkiem.TextChanged += txttimkiem_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btn_chonn);
            groupBox1.Controls.Add(dgvDSkhachhang);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txttimkiem);
            groupBox1.Location = new Point(-1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 548);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btn_chonn
            // 
            btn_chonn.BackColor = Color.MediumTurquoise;
            btn_chonn.Location = new Point(337, 490);
            btn_chonn.Name = "btn_chonn";
            btn_chonn.Size = new Size(110, 52);
            btn_chonn.TabIndex = 5;
            btn_chonn.Text = "Chọn";
            btn_chonn.UseVisualStyleBackColor = false;
            btn_chonn.Click += btn_chonn_Click;
            // 
            // dgvDSkhachhang
            // 
            dgvDSkhachhang.BackgroundColor = SystemColors.Control;
            dgvDSkhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSkhachhang.Location = new Point(20, 78);
            dgvDSkhachhang.Name = "dgvDSkhachhang";
            dgvDSkhachhang.RowHeadersWidth = 51;
            dgvDSkhachhang.RowTemplate.Height = 29;
            dgvDSkhachhang.Size = new Size(759, 389);
            dgvDSkhachhang.TabIndex = 4;
            // 
            // tpthongtinkhachhang
            // 
            tpthongtinkhachhang.Controls.Add(groupBox1);
            tpthongtinkhachhang.Location = new Point(4, 28);
            tpthongtinkhachhang.Name = "tpthongtinkhachhang";
            tpthongtinkhachhang.Padding = new Padding(3);
            tpthongtinkhachhang.Size = new Size(799, 554);
            tpthongtinkhachhang.TabIndex = 0;
            tpthongtinkhachhang.Text = "Thông tin khách hàng";
            tpthongtinkhachhang.UseVisualStyleBackColor = true;
            // 
            // tabdskhachhang
            // 
            tabdskhachhang.Controls.Add(tpthongtinkhachhang);
            tabdskhachhang.Controls.Add(tpthemkh);
            tabdskhachhang.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tabdskhachhang.Location = new Point(9, 9);
            tabdskhachhang.Name = "tabdskhachhang";
            tabdskhachhang.SelectedIndex = 0;
            tabdskhachhang.Size = new Size(807, 586);
            tabdskhachhang.TabIndex = 1;
            // 
            // Form_DanhSachKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 597);
            Controls.Add(tabdskhachhang);
            Margin = new Padding(2);
            Name = "Form_DanhSachKH";
            Text = "Form_DanhSachKH";
            Load += Form_DanhSachKH_Load;
            tpthemkh.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSkhachhang).EndInit();
            tpthongtinkhachhang.ResumeLayout(false);
            tabdskhachhang.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Reset;
        private Button btn_Thêm;
        private RadioButton rbtNu;
        private RadioButton rbtNam;
        private Label lbtrangthaii;
        private Label lbdiachi;
        private TextBox txtdiachi;
        private Label lbsdt;
        private TextBox txtsdt;
        private Label label2;
        private TextBox txttenkh;
        private Label lbmakh;
        private TextBox txtmakh;
        private TabPage tpthemkh;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txttimkiem;
        private GroupBox groupBox1;
        private TabPage tpthongtinkhachhang;
        private TabControl tabdskhachhang;
        private DataGridView dgvDSkhachhang;
        private Button btn_chonn;
    }
}