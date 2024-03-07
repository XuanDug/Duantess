namespace BanGiay
{
    partial class Main
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
            panel1 = new Panel();
            txtTenTaiKhoan = new Label();
            label1 = new Label();
            btnDangXuat = new Button();
            btnGiaoCa = new Button();
            btnLuong = new Button();
            btnThongKe = new Button();
            btnKhachHang = new Button();
            btnNhanVien = new Button();
            benKhuyenMai = new Button();
            btnHoaDon = new Button();
            btnSanPham = new Button();
            btnBanHang = new Button();
            ptbLOGO = new PictureBox();
            panel_US = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLOGO).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 71, 92);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnDangXuat);
            panel1.Controls.Add(btnGiaoCa);
            panel1.Controls.Add(btnLuong);
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(btnKhachHang);
            panel1.Controls.Add(btnNhanVien);
            panel1.Controls.Add(benKhuyenMai);
            panel1.Controls.Add(btnHoaDon);
            panel1.Controls.Add(btnSanPham);
            panel1.Controls.Add(btnBanHang);
            panel1.Controls.Add(ptbLOGO);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 733);
            panel1.TabIndex = 0;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.AutoSize = true;
            txtTenTaiKhoan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTenTaiKhoan.ForeColor = Color.White;
            txtTenTaiKhoan.Location = new Point(74, 14);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(14, 15);
            txtTenTaiKhoan.TabIndex = 13;
            txtTenTaiKhoan.Text = "#";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 12;
            label1.Text = "Xin chào:";
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.ForeColor = SystemColors.Control;
            btnDangXuat.Location = new Point(0, 684);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(220, 49);
            btnDangXuat.TabIndex = 11;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnGiaoCa
            // 
            btnGiaoCa.Dock = DockStyle.Top;
            btnGiaoCa.FlatAppearance.BorderSize = 0;
            btnGiaoCa.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            btnGiaoCa.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnGiaoCa.FlatStyle = FlatStyle.Flat;
            btnGiaoCa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiaoCa.ForeColor = SystemColors.Control;
            btnGiaoCa.Location = new Point(0, 534);
            btnGiaoCa.Name = "btnGiaoCa";
            btnGiaoCa.Size = new Size(220, 49);
            btnGiaoCa.TabIndex = 9;
            btnGiaoCa.Text = "Giao ca";
            btnGiaoCa.UseVisualStyleBackColor = true;
            btnGiaoCa.Click += btnGiaoCa_Click;
            // 
            // btnLuong
            // 
            btnLuong.Dock = DockStyle.Top;
            btnLuong.FlatAppearance.BorderSize = 0;
            btnLuong.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            btnLuong.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnLuong.FlatStyle = FlatStyle.Flat;
            btnLuong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuong.ForeColor = SystemColors.Control;
            btnLuong.Location = new Point(0, 485);
            btnLuong.Name = "btnLuong";
            btnLuong.Size = new Size(220, 49);
            btnLuong.TabIndex = 8;
            btnLuong.Text = "Lương";
            btnLuong.UseVisualStyleBackColor = true;
            btnLuong.Click += btnLuong_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            btnThongKe.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnThongKe.ForeColor = SystemColors.Control;
            btnThongKe.Location = new Point(0, 436);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(220, 49);
            btnThongKe.TabIndex = 7;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            btnKhachHang.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhachHang.ForeColor = SystemColors.Control;
            btnKhachHang.Location = new Point(0, 387);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(220, 49);
            btnKhachHang.TabIndex = 6;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            btnNhanVien.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhanVien.ForeColor = SystemColors.Control;
            btnNhanVien.Location = new Point(0, 338);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(220, 49);
            btnNhanVien.TabIndex = 5;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // benKhuyenMai
            // 
            benKhuyenMai.Dock = DockStyle.Top;
            benKhuyenMai.FlatAppearance.BorderSize = 0;
            benKhuyenMai.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            benKhuyenMai.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            benKhuyenMai.FlatStyle = FlatStyle.Flat;
            benKhuyenMai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            benKhuyenMai.ForeColor = SystemColors.Control;
            benKhuyenMai.Location = new Point(0, 289);
            benKhuyenMai.Name = "benKhuyenMai";
            benKhuyenMai.Size = new Size(220, 49);
            benKhuyenMai.TabIndex = 4;
            benKhuyenMai.Text = "Khuyến mãi";
            benKhuyenMai.UseVisualStyleBackColor = true;
            benKhuyenMai.Click += benKhuyenMai_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            btnHoaDon.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnHoaDon.ForeColor = SystemColors.Control;
            btnHoaDon.Location = new Point(0, 240);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(220, 49);
            btnHoaDon.TabIndex = 3;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.Dock = DockStyle.Top;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            btnSanPham.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSanPham.ForeColor = SystemColors.Control;
            btnSanPham.Location = new Point(0, 191);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(220, 49);
            btnSanPham.TabIndex = 2;
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnBanHang
            // 
            btnBanHang.Dock = DockStyle.Top;
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBanHang.ForeColor = SystemColors.Control;
            btnBanHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanHang.Location = new Point(0, 142);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(220, 49);
            btnBanHang.TabIndex = 1;
            btnBanHang.Text = "Bán Hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // ptbLOGO
            // 
            ptbLOGO.Dock = DockStyle.Top;
            ptbLOGO.Image = Properties.Resources.OIG_removebg_preview;
            ptbLOGO.Location = new Point(0, 0);
            ptbLOGO.Name = "ptbLOGO";
            ptbLOGO.Size = new Size(220, 142);
            ptbLOGO.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLOGO.TabIndex = 0;
            ptbLOGO.TabStop = false;
            // 
            // panel_US
            // 
            panel_US.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_US.Location = new Point(220, 0);
            panel_US.Name = "panel_US";
            panel_US.Size = new Size(1094, 733);
            panel_US.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtTenTaiKhoan);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 634);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 50);
            panel2.TabIndex = 14;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1313, 733);
            Controls.Add(panel_US);
            Controls.Add(panel1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm bán giày";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbLOGO).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGiaoCa;
        private Button btnLuong;
        private Button btnThongKe;
        private Button btnKhachHang;
        private Button btnNhanVien;
        private Button benKhuyenMai;
        private Button btnHoaDon;
        private Button btnSanPham;
        private Button btnBanHang;
        private PictureBox ptbLOGO;
        private Panel panel_US;
        private Button btnDangXuat;
        private Label txtTenTaiKhoan;
        private Label label1;
        private Panel panel2;
    }
}