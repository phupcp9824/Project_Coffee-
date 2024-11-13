namespace DuAn1_Coffe.PRL.Forms
{
    partial class Form_ThongKe
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
            panel7 = new Panel();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            dgvdoanhthusp = new DataGridView();
            tabPage2 = new TabPage();
            dgvsphethang = new DataGridView();
            tabPage1 = new TabPage();
            dgvspbanchay = new DataGridView();
            panel6 = new Panel();
            btnThongKe = new Button();
            dtpDenNgay = new DateTimePicker();
            dtptungay = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            panel5 = new Panel();
            lbtongdonhang = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            panel4 = new Panel();
            lbspban = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            label6 = new Label();
            lbdoanhthu = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            btn_All = new Button();
            panel7.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdoanhthusp).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsphethang).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvspbanchay).BeginInit();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel5.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(tabControl1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 408);
            panel7.Name = "panel7";
            panel7.Size = new Size(1536, 326);
            panel7.TabIndex = 7;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1536, 326);
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvdoanhthusp);
            tabPage3.Location = new Point(4, 35);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1528, 287);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Doanh thu sản phẩm";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvdoanhthusp
            // 
            dgvdoanhthusp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdoanhthusp.BackgroundColor = SystemColors.Control;
            dgvdoanhthusp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdoanhthusp.Dock = DockStyle.Fill;
            dgvdoanhthusp.Location = new Point(0, 0);
            dgvdoanhthusp.Name = "dgvdoanhthusp";
            dgvdoanhthusp.RowHeadersWidth = 51;
            dgvdoanhthusp.RowTemplate.Height = 80;
            dgvdoanhthusp.Size = new Size(1528, 287);
            dgvdoanhthusp.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvsphethang);
            tabPage2.Location = new Point(4, 35);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1528, 287);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Danh sách sản phẩm sắp hết hàng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvsphethang
            // 
            dgvsphethang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsphethang.BackgroundColor = SystemColors.Control;
            dgvsphethang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsphethang.Dock = DockStyle.Fill;
            dgvsphethang.Location = new Point(3, 3);
            dgvsphethang.Name = "dgvsphethang";
            dgvsphethang.RowHeadersWidth = 51;
            dgvsphethang.RowTemplate.Height = 80;
            dgvsphethang.Size = new Size(1522, 281);
            dgvsphethang.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvspbanchay);
            tabPage1.Location = new Point(4, 35);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1528, 287);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Danh sách sản phẩm bán chạy";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvspbanchay
            // 
            dgvspbanchay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvspbanchay.BackgroundColor = SystemColors.Control;
            dgvspbanchay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvspbanchay.Dock = DockStyle.Fill;
            dgvspbanchay.Location = new Point(3, 3);
            dgvspbanchay.Name = "dgvspbanchay";
            dgvspbanchay.RowHeadersWidth = 51;
            dgvspbanchay.RowTemplate.Height = 80;
            dgvspbanchay.Size = new Size(1522, 281);
            dgvspbanchay.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(btn_All);
            panel6.Controls.Add(btnThongKe);
            panel6.Controls.Add(dtpDenNgay);
            panel6.Controls.Add(dtptungay);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label9);
            panel6.Dock = DockStyle.Top;
            panel6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel6.ForeColor = SystemColors.ControlText;
            panel6.Location = new Point(0, 303);
            panel6.Name = "panel6";
            panel6.Size = new Size(1536, 105);
            panel6.TabIndex = 6;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.DarkCyan;
            btnThongKe.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThongKe.Location = new Point(1203, 29);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(131, 58);
            btnThongKe.TabIndex = 9;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(819, 34);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(246, 38);
            dtpDenNgay.TabIndex = 8;
            // 
            // dtptungay
            // 
            dtptungay.CustomFormat = "dd/MM/yyyy";
            dtptungay.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtptungay.Format = DateTimePickerFormat.Custom;
            dtptungay.Location = new Point(322, 34);
            dtptungay.Name = "dtptungay";
            dtptungay.Size = new Size(246, 38);
            dtptungay.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(656, 34);
            label10.Name = "label10";
            label10.Size = new Size(135, 33);
            label10.TabIndex = 6;
            label10.Text = "Đến ngày :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(196, 34);
            label9.Name = "label9";
            label9.Size = new Size(120, 33);
            label9.TabIndex = 5;
            label9.Text = "Từ ngày :";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(1536, 217);
            panel2.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel5);
            groupBox3.Location = new Point(1200, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(324, 214);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gold;
            panel5.Controls.Add(lbtongdonhang);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 23);
            panel5.Name = "panel5";
            panel5.Size = new Size(318, 188);
            panel5.TabIndex = 3;
            // 
            // lbtongdonhang
            // 
            lbtongdonhang.AutoSize = true;
            lbtongdonhang.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbtongdonhang.Location = new Point(124, 75);
            lbtongdonhang.Name = "lbtongdonhang";
            lbtongdonhang.Size = new Size(27, 32);
            lbtongdonhang.TabIndex = 4;
            lbtongdonhang.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 14);
            label4.Name = "label4";
            label4.Size = new Size(165, 26);
            label4.TabIndex = 1;
            label4.Text = "Tổng đơn hàng";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel4);
            groupBox2.Location = new Point(620, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 211);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.ForestGreen;
            panel4.Controls.Add(lbspban);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(328, 185);
            panel4.TabIndex = 2;
            // 
            // lbspban
            // 
            lbspban.AutoSize = true;
            lbspban.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbspban.Location = new Point(124, 75);
            lbspban.Name = "lbspban";
            lbspban.Size = new Size(27, 32);
            lbspban.TabIndex = 3;
            lbspban.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 14);
            label3.Name = "label3";
            label3.Size = new Size(242, 26);
            label3.TabIndex = 1;
            label3.Text = "Tổng sản phẩm đã bán";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Location = new Point(54, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 211);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.IndianRed;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lbdoanhthu);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(319, 185);
            panel3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(182, 75);
            label6.Name = "label6";
            label6.Size = new Size(51, 22);
            label6.TabIndex = 2;
            label6.Text = "VNĐ";
            // 
            // lbdoanhthu
            // 
            lbdoanhthu.AutoSize = true;
            lbdoanhthu.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbdoanhthu.Location = new Point(71, 65);
            lbdoanhthu.Name = "lbdoanhthu";
            lbdoanhthu.Size = new Size(27, 32);
            lbdoanhthu.TabIndex = 1;
            lbdoanhthu.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 14);
            label2.Name = "label2";
            label2.Size = new Size(173, 26);
            label2.TabIndex = 0;
            label2.Text = "Tổng doanh thu";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1536, 86);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(682, 18);
            label1.Name = "label1";
            label1.Size = new Size(196, 51);
            label1.TabIndex = 1;
            label1.Text = "Thống kê";
            // 
            // btn_All
            // 
            btn_All.BackColor = Color.DarkCyan;
            btn_All.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_All.Location = new Point(1365, 29);
            btn_All.Name = "btn_All";
            btn_All.Size = new Size(131, 58);
            btn_All.TabIndex = 10;
            btn_All.Text = "All";
            btn_All.UseVisualStyleBackColor = false;
            btn_All.Click += btn_All_Click;
            // 
            // Form_ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 734);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form_ThongKe";
            Text = "Form_ThongKe";
            Load += Form_ThongKe_Load;
            panel7.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdoanhthusp).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvsphethang).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvspbanchay).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private DataGridView dgvdoanhthusp;
        private TabPage tabPage2;
        private DataGridView dgvsphethang;
        private TabPage tabPage1;
        private DataGridView dgvspbanchay;
        private Panel panel6;
        private Button btnThongKe;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtptungay;
        private Label label10;
        private Label label9;
        private Panel panel2;
        private GroupBox groupBox3;
        private Panel panel5;
        private Label lbtongdonhang;
        private Label label4;
        private GroupBox groupBox2;
        private Panel panel4;
        private Label lbspban;
        private Label label3;
        private GroupBox groupBox1;
        private Panel panel3;
        private Label label6;
        private Label lbdoanhthu;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button btn_All;
    }
}