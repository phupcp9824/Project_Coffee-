namespace DuAn1_Coffe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bt_dn = new Button();
            tb_mk = new TextBox();
            tb_tk = new TextBox();
            button1 = new Button();
            txtpass = new TextBox();
            txtuser = new TextBox();
            peye = new PictureBox();
            phide = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)peye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phide).BeginInit();
            SuspendLayout();
            // 
            // bt_dn
            // 
            bt_dn.BackColor = Color.MediumSeaGreen;
            bt_dn.Location = new Point(272, 310);
            bt_dn.Margin = new Padding(3, 4, 3, 4);
            bt_dn.Name = "bt_dn";
            bt_dn.Size = new Size(114, 53);
            bt_dn.TabIndex = 13;
            bt_dn.Text = "Đăng Nhập";
            bt_dn.UseVisualStyleBackColor = false;
            // 
            // tb_mk
            // 
            tb_mk.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_mk.Location = new Point(142, 221);
            tb_mk.Margin = new Padding(3, 4, 3, 4);
            tb_mk.Name = "tb_mk";
            tb_mk.PasswordChar = '●';
            tb_mk.PlaceholderText = "Password";
            tb_mk.Size = new Size(395, 34);
            tb_mk.TabIndex = 12;
            // 
            // tb_tk
            // 
            tb_tk.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_tk.Location = new Point(142, 119);
            tb_tk.Margin = new Padding(3, 4, 3, 4);
            tb_tk.Name = "tb_tk";
            tb_tk.PlaceholderText = "UserName";
            tb_tk.Size = new Size(395, 34);
            tb_tk.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Location = new Point(272, 310);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 53);
            button1.TabIndex = 16;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass.Location = new Point(142, 221);
            txtpass.Margin = new Padding(3, 4, 3, 4);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.PlaceholderText = "Password";
            txtpass.Size = new Size(395, 36);
            txtpass.TabIndex = 15;
            // 
            // txtuser
            // 
            txtuser.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtuser.Location = new Point(142, 119);
            txtuser.Margin = new Padding(3, 4, 3, 4);
            txtuser.Name = "txtuser";
            txtuser.PlaceholderText = "UserName";
            txtuser.Size = new Size(395, 34);
            txtuser.TabIndex = 14;
            // 
            // peye
            // 
            peye.Image = (Image)resources.GetObject("peye.Image");
            peye.Location = new Point(495, 223);
            peye.Name = "peye";
            peye.Size = new Size(31, 32);
            peye.SizeMode = PictureBoxSizeMode.Zoom;
            peye.TabIndex = 17;
            peye.TabStop = false;
            peye.Click += peye_Click_1;
            // 
            // phide
            // 
            phide.BackgroundImageLayout = ImageLayout.Zoom;
            phide.Image = (Image)resources.GetObject("phide.Image");
            phide.Location = new Point(494, 223);
            phide.Name = "phide";
            phide.Size = new Size(32, 32);
            phide.SizeMode = PictureBoxSizeMode.Zoom;
            phide.TabIndex = 18;
            phide.TabStop = false;
            phide.Click += phide_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(677, 483);
            Controls.Add(phide);
            Controls.Add(peye);
            Controls.Add(button1);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(bt_dn);
            Controls.Add(tb_mk);
            Controls.Add(tb_tk);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)peye).EndInit();
            ((System.ComponentModel.ISupportInitialize)phide).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_dn;
        private TextBox tb_mk;
        private TextBox tb_tk;
        private Button button1;
        private TextBox txtpass;
        private TextBox txtuser;
        private PictureBox peye;
        private PictureBox phide;
    }
}
