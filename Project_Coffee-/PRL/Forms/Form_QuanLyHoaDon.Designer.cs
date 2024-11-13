namespace DuAn1_Coffe.PRL.Forms
{
    partial class Form_QuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QuanLyHoaDon));
            groupBox2 = new GroupBox();
            dgvhoadonchitiet = new DataGridView();
            groupBox1 = new GroupBox();
            dgvhoadon = new DataGridView();
            panel1 = new Panel();
            btn_load = new Button();
            txttimkiemnguoitao = new TextBox();
            label4 = new Label();
            txttimkiemmahoadon = new TextBox();
            label3 = new Label();
            cbolochoadon = new ComboBox();
            btn_timNgay = new Button();
            dtpDen = new DateTimePicker();
            label2 = new Label();
            dtpTu = new DateTimePicker();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoadonchitiet).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvhoadonchitiet);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 712);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1454, 102);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa Đơn Chi tiết";
            // 
            // dgvhoadonchitiet
            // 
            dgvhoadonchitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvhoadonchitiet.BackgroundColor = SystemColors.Control;
            dgvhoadonchitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoadonchitiet.Dock = DockStyle.Fill;
            dgvhoadonchitiet.Location = new Point(3, 26);
            dgvhoadonchitiet.Name = "dgvhoadonchitiet";
            dgvhoadonchitiet.RowHeadersWidth = 51;
            dgvhoadonchitiet.Size = new Size(1448, 73);
            dgvhoadonchitiet.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvhoadon);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 282);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1454, 430);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa Đơn";
            // 
            // dgvhoadon
            // 
            dgvhoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvhoadon.BackgroundColor = SystemColors.ButtonHighlight;
            dgvhoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoadon.Dock = DockStyle.Fill;
            dgvhoadon.Location = new Point(3, 26);
            dgvhoadon.Name = "dgvhoadon";
            dgvhoadon.RowHeadersWidth = 51;
            dgvhoadon.RowTemplate.Height = 80;
            dgvhoadon.Size = new Size(1448, 401);
            dgvhoadon.TabIndex = 0;
            dgvhoadon.CellClick += dgvhoadon_CellClick;
            dgvhoadon.CellDoubleClick += dgvhoadon_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(btn_load);
            panel1.Controls.Add(txttimkiemnguoitao);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txttimkiemmahoadon);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbolochoadon);
            panel1.Controls.Add(btn_timNgay);
            panel1.Controls.Add(dtpDen);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpTu);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1454, 282);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // btn_load
            // 
            btn_load.BackColor = Color.White;
            btn_load.BackgroundImage = (Image)resources.GetObject("btn_load.BackgroundImage");
            btn_load.BackgroundImageLayout = ImageLayout.Zoom;
            btn_load.Location = new Point(1120, 155);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(70, 57);
            btn_load.TabIndex = 59;
            btn_load.UseVisualStyleBackColor = false;
            btn_load.Click += btn_load_Click;
            // 
            // txttimkiemnguoitao
            // 
            txttimkiemnguoitao.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkiemnguoitao.Location = new Point(177, 210);
            txttimkiemnguoitao.Name = "txttimkiemnguoitao";
            txttimkiemnguoitao.PlaceholderText = "Tìm kiếm";
            txttimkiemnguoitao.Size = new Size(258, 34);
            txttimkiemnguoitao.TabIndex = 19;
            txttimkiemnguoitao.TextChanged += txttimkiemnguoitao_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 210);
            label4.Name = "label4";
            label4.Size = new Size(118, 31);
            label4.TabIndex = 18;
            label4.Text = "Người tạo";
            // 
            // txttimkiemmahoadon
            // 
            txttimkiemmahoadon.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txttimkiemmahoadon.Location = new Point(177, 129);
            txttimkiemmahoadon.Name = "txttimkiemmahoadon";
            txttimkiemmahoadon.PlaceholderText = "Tìm kiếm";
            txttimkiemmahoadon.Size = new Size(258, 34);
            txttimkiemmahoadon.TabIndex = 17;
            txttimkiemmahoadon.TextChanged += txttimkiemmahoadon_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 131);
            label3.Name = "label3";
            label3.Size = new Size(85, 31);
            label3.TabIndex = 16;
            label3.Text = "Mã HD";
            // 
            // cbolochoadon
            // 
            cbolochoadon.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbolochoadon.FormattingEnabled = true;
            cbolochoadon.Items.AddRange(new object[] { "Đã thanh toán", "Chưa Thanh Toán", "Đã Hủy" });
            cbolochoadon.Location = new Point(639, 129);
            cbolochoadon.Name = "cbolochoadon";
            cbolochoadon.Size = new Size(250, 34);
            cbolochoadon.TabIndex = 15;
            cbolochoadon.Text = "Lọc";
            cbolochoadon.SelectedIndexChanged += cbolochoadon_SelectedIndexChanged;
            // 
            // btn_timNgay
            // 
            btn_timNgay.BackColor = Color.White;
            btn_timNgay.BackgroundImage = (Image)resources.GetObject("btn_timNgay.BackgroundImage");
            btn_timNgay.BackgroundImageLayout = ImageLayout.Zoom;
            btn_timNgay.ForeColor = SystemColors.ActiveCaptionText;
            btn_timNgay.Location = new Point(1120, 56);
            btn_timNgay.Name = "btn_timNgay";
            btn_timNgay.Size = new Size(70, 62);
            btn_timNgay.TabIndex = 14;
            btn_timNgay.UseVisualStyleBackColor = false;
            btn_timNgay.Click += btn_timNgay_Click;
            // 
            // dtpDen
            // 
            dtpDen.CustomFormat = "dd/MM/yyyy";
            dtpDen.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDen.Format = DateTimePickerFormat.Custom;
            dtpDen.Location = new Point(639, 56);
            dtpDen.Name = "dtpDen";
            dtpDen.Size = new Size(250, 34);
            dtpDen.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(479, 57);
            label2.Name = "label2";
            label2.Size = new Size(55, 31);
            label2.TabIndex = 12;
            label2.Text = "Đến";
            // 
            // dtpTu
            // 
            dtpTu.CustomFormat = "dd/MM/yyyy";
            dtpTu.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTu.Format = DateTimePickerFormat.Custom;
            dtpTu.Location = new Point(177, 54);
            dtpTu.Name = "dtpTu";
            dtpTu.Size = new Size(258, 34);
            dtpTu.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(102, 57);
            label1.Name = "label1";
            label1.Size = new Size(40, 31);
            label1.TabIndex = 10;
            label1.Text = "Từ";
            // 
            // Form_QuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 814);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form_QuanLyHoaDon";
            Text = "Form_QuanLyHoaDon";
            Load += Form_QuanLyHoaDon_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhoadonchitiet).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvhoadonchitiet;
        private GroupBox groupBox1;
        private DataGridView dgvhoadon;
        private Panel panel1;
        private Button btn_load;
        private TextBox txttimkiemnguoitao;
        private Label label4;
        private TextBox txttimkiemmahoadon;
        private Label label3;
        private ComboBox cbolochoadon;
        private Button btn_timNgay;
        private DateTimePicker dtpDen;
        private Label label2;
        private DateTimePicker dtpTu;
        private Label label1;
    }
}