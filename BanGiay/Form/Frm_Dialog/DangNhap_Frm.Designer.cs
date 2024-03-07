namespace PRL.Frm_Main
{
    partial class DangNhap_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap_Frm));
            txtQuenMatKhau = new Label();
            txtMatKhau = new TextBox();
            txt2 = new Label();
            txt1 = new Label();
            pictureBox1 = new PictureBox();
            btnDangnhap = new Button();
            txt4 = new Label();
            txt3 = new Label();
            txtTaiKhoan = new TextBox();
            ptbTat = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbTat).BeginInit();
            SuspendLayout();
            // 
            // txtQuenMatKhau
            // 
            txtQuenMatKhau.AutoSize = true;
            txtQuenMatKhau.Cursor = Cursors.Hand;
            txtQuenMatKhau.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtQuenMatKhau.Location = new Point(457, 321);
            txtQuenMatKhau.Name = "txtQuenMatKhau";
            txtQuenMatKhau.Size = new Size(108, 17);
            txtQuenMatKhau.TabIndex = 32;
            txtQuenMatKhau.Text = "Quên mật khẩu?";
            txtQuenMatKhau.Click += btnQuenmk_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(318, 207);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(277, 23);
            txtMatKhau.TabIndex = 25;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txt2
            // 
            txt2.AutoSize = true;
            txt2.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt2.Location = new Point(318, 70);
            txt2.Margin = new Padding(2, 0, 2, 0);
            txt2.Name = "txt2";
            txt2.Size = new Size(251, 18);
            txt2.TabIndex = 31;
            txt2.Text = "Vui lòng nhập thông tin chi tiết của bạn!";
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.FlatStyle = FlatStyle.Popup;
            txt1.Font = new Font("Calibri", 30F, FontStyle.Bold, GraphicsUnit.Point);
            txt1.Location = new Point(310, 21);
            txt1.Margin = new Padding(2, 0, 2, 0);
            txt1.Name = "txt1";
            txt1.Size = new Size(285, 49);
            txt1.TabIndex = 30;
            txt1.Text = "Chào mừng bạn";
            txt1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, -1);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // btnDangnhap
            // 
            btnDangnhap.FlatAppearance.BorderSize = 0;
            btnDangnhap.FlatStyle = FlatStyle.Flat;
            btnDangnhap.Font = new Font("Calibri", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangnhap.Location = new Point(307, 257);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(398, 49);
            btnDangnhap.TabIndex = 26;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // txt4
            // 
            txt4.AutoSize = true;
            txt4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt4.Location = new Point(318, 185);
            txt4.Name = "txt4";
            txt4.Size = new Size(79, 19);
            txt4.TabIndex = 27;
            txt4.Text = "Mật khẩu:";
            // 
            // txt3
            // 
            txt3.AutoSize = true;
            txt3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt3.Location = new Point(318, 110);
            txt3.Name = "txt3";
            txt3.Size = new Size(106, 19);
            txt3.TabIndex = 28;
            txt3.Text = "Tên tài khoản:";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaiKhoan.Location = new Point(318, 132);
            txtTaiKhoan.Margin = new Padding(10);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(277, 26);
            txtTaiKhoan.TabIndex = 24;
            // 
            // ptbTat
            // 
            ptbTat.Cursor = Cursors.Hand;
            ptbTat.Image = BanGiay.Properties.Resources.power_switch;
            ptbTat.Location = new Point(671, 12);
            ptbTat.Name = "ptbTat";
            ptbTat.Size = new Size(34, 28);
            ptbTat.SizeMode = PictureBoxSizeMode.Zoom;
            ptbTat.TabIndex = 33;
            ptbTat.TabStop = false;
            ptbTat.Click += ptbTat_Click;
            // 
            // DangNhap_Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 398);
            Controls.Add(ptbTat);
            Controls.Add(txtQuenMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(pictureBox1);
            Controls.Add(btnDangnhap);
            Controls.Add(txt4);
            Controls.Add(txt3);
            Controls.Add(txtTaiKhoan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DangNhap_Frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap_Form";
            Load += DangNhap_Frm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbTat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtQuenMatKhau;
        private TextBox txtMatKhau;
        private Label txt2;
        private Label txt1;
        private PictureBox pictureBox1;
        private Button btnDangnhap;
        private Label txt4;
        private Label txt3;
        private TextBox txtTaiKhoan;
        private PictureBox ptbTat;
    }
}