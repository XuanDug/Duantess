namespace BanGiay.Form.US
{
    partial class Frm_US_GiaoCa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            panel4 = new Panel();
            btnSua = new Button();
            panel6 = new Panel();
            btnHuyca = new Button();
            panel5 = new Panel();
            btnThem_BangCa = new Button();
            cmbnhanvien = new ComboBox();
            dateGiaoca = new DateTimePicker();
            label9 = new Label();
            dateVe = new DateTimePicker();
            dateDen = new DateTimePicker();
            btnThem_TenCa = new Button();
            cmbTenca = new ComboBox();
            txtTienbangiao = new TextBox();
            txtSanpham = new TextBox();
            txtGhichu = new RichTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBox2 = new GroupBox();
            dgv_GiaoCa = new DataGridView();
            panel1 = new Panel();
            txtTimKiem_GiaoCa = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dgvNhanVien = new DataGridView();
            panel3 = new Panel();
            txtTimKiem_NhanVien = new TextBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            dgvGCCT = new DataGridView();
            panel2 = new Panel();
            btnExcel = new Button();
            txtTimKiem_GCCT = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_GiaoCa).BeginInit();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGCCT).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(cmbnhanvien);
            groupBox1.Controls.Add(dateGiaoca);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dateVe);
            groupBox1.Controls.Add(dateDen);
            groupBox1.Controls.Add(btnThem_TenCa);
            groupBox1.Controls.Add(cmbTenca);
            groupBox1.Controls.Add(txtTienbangiao);
            groupBox1.Controls.Add(txtSanpham);
            groupBox1.Controls.Add(txtGhichu);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(920, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(330, 977);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bảng ca";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSua);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(btnHuyca);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(btnThem_BangCa);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 904);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(324, 69);
            panel4.TabIndex = 52;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(64, 79, 105);
            btnSua.Cursor = Cursors.Hand;
            btnSua.Dock = DockStyle.Fill;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(123, 0);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(83, 69);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(206, 0);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(32, 69);
            panel6.TabIndex = 6;
            // 
            // btnHuyca
            // 
            btnHuyca.BackColor = Color.FromArgb(64, 79, 105);
            btnHuyca.Cursor = Cursors.Hand;
            btnHuyca.Dock = DockStyle.Right;
            btnHuyca.FlatAppearance.BorderSize = 0;
            btnHuyca.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnHuyca.FlatStyle = FlatStyle.Flat;
            btnHuyca.ForeColor = Color.White;
            btnHuyca.Location = new Point(238, 0);
            btnHuyca.Margin = new Padding(3, 4, 3, 4);
            btnHuyca.Name = "btnHuyca";
            btnHuyca.Size = new Size(86, 69);
            btnHuyca.TabIndex = 5;
            btnHuyca.Text = "Hủy ca";
            btnHuyca.UseVisualStyleBackColor = false;
            btnHuyca.Click += btnHuy_Click;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(86, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(37, 69);
            panel5.TabIndex = 4;
            // 
            // btnThem_BangCa
            // 
            btnThem_BangCa.BackColor = Color.FromArgb(64, 79, 105);
            btnThem_BangCa.Cursor = Cursors.Hand;
            btnThem_BangCa.Dock = DockStyle.Left;
            btnThem_BangCa.FlatAppearance.BorderSize = 0;
            btnThem_BangCa.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnThem_BangCa.FlatStyle = FlatStyle.Flat;
            btnThem_BangCa.ForeColor = Color.White;
            btnThem_BangCa.Location = new Point(0, 0);
            btnThem_BangCa.Margin = new Padding(3, 4, 3, 4);
            btnThem_BangCa.Name = "btnThem_BangCa";
            btnThem_BangCa.Size = new Size(86, 69);
            btnThem_BangCa.TabIndex = 0;
            btnThem_BangCa.Text = "Thêm";
            btnThem_BangCa.UseVisualStyleBackColor = false;
            btnThem_BangCa.Click += button3_Click;
            // 
            // cmbnhanvien
            // 
            cmbnhanvien.FormattingEnabled = true;
            cmbnhanvien.Location = new Point(126, 113);
            cmbnhanvien.Name = "cmbnhanvien";
            cmbnhanvien.Size = new Size(177, 28);
            cmbnhanvien.TabIndex = 51;
            // 
            // dateGiaoca
            // 
            dateGiaoca.Location = new Point(126, 182);
            dateGiaoca.Name = "dateGiaoca";
            dateGiaoca.Size = new Size(178, 27);
            dateGiaoca.TabIndex = 50;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 177);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 49;
            label9.Text = "Ngày giao ca:";
            // 
            // dateVe
            // 
            dateVe.Location = new Point(126, 305);
            dateVe.Name = "dateVe";
            dateVe.Size = new Size(178, 27);
            dateVe.TabIndex = 48;
            // 
            // dateDen
            // 
            dateDen.Location = new Point(126, 241);
            dateDen.Name = "dateDen";
            dateDen.Size = new Size(178, 27);
            dateDen.TabIndex = 47;
            // 
            // btnThem_TenCa
            // 
            btnThem_TenCa.BackColor = Color.FromArgb(64, 79, 105);
            btnThem_TenCa.Cursor = Cursors.Hand;
            btnThem_TenCa.FlatAppearance.BorderSize = 0;
            btnThem_TenCa.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnThem_TenCa.FlatStyle = FlatStyle.Flat;
            btnThem_TenCa.ForeColor = Color.White;
            btnThem_TenCa.Location = new Point(245, 41);
            btnThem_TenCa.Name = "btnThem_TenCa";
            btnThem_TenCa.Size = new Size(39, 32);
            btnThem_TenCa.TabIndex = 46;
            btnThem_TenCa.Text = "+";
            btnThem_TenCa.UseVisualStyleBackColor = false;
            btnThem_TenCa.Click += button1_Click;
            // 
            // cmbTenca
            // 
            cmbTenca.FormattingEnabled = true;
            cmbTenca.Location = new Point(61, 44);
            cmbTenca.Name = "cmbTenca";
            cmbTenca.Size = new Size(177, 28);
            cmbTenca.TabIndex = 45;
            // 
            // txtTienbangiao
            // 
            txtTienbangiao.BorderStyle = BorderStyle.FixedSingle;
            txtTienbangiao.Location = new Point(123, 426);
            txtTienbangiao.Name = "txtTienbangiao";
            txtTienbangiao.Size = new Size(177, 27);
            txtTienbangiao.TabIndex = 44;
            // 
            // txtSanpham
            // 
            txtSanpham.BorderStyle = BorderStyle.FixedSingle;
            txtSanpham.Location = new Point(123, 364);
            txtSanpham.Name = "txtSanpham";
            txtSanpham.Size = new Size(177, 27);
            txtSanpham.TabIndex = 43;
            // 
            // txtGhichu
            // 
            txtGhichu.BorderStyle = BorderStyle.FixedSingle;
            txtGhichu.Location = new Point(2, 521);
            txtGhichu.Margin = new Padding(2, 3, 2, 3);
            txtGhichu.Name = "txtGhichu";
            txtGhichu.Size = new Size(322, 137);
            txtGhichu.TabIndex = 42;
            txtGhichu.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 497);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 41;
            label7.Text = "Ghi chú:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 433);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 40;
            label6.Text = "Tiền đã giao:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 369);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 39;
            label5.Text = "Sản phẩm đã giao:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 305);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 38;
            label4.Text = "Thời gian về:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 241);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 37;
            label8.Text = "Thời gian đến:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 113);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(102, 20);
            label10.TabIndex = 36;
            label10.Text = "Tên nhân viên:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 49);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(54, 20);
            label11.TabIndex = 35;
            label11.Text = "Tên ca:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_GiaoCa);
            groupBox2.Controls.Add(panel1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(920, 296);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giao ca";
            // 
            // dgv_GiaoCa
            // 
            dgv_GiaoCa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_GiaoCa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_GiaoCa.Dock = DockStyle.Fill;
            dgv_GiaoCa.Location = new Point(3, 75);
            dgv_GiaoCa.Margin = new Padding(3, 4, 3, 4);
            dgv_GiaoCa.Name = "dgv_GiaoCa";
            dgv_GiaoCa.RowHeadersWidth = 51;
            dgv_GiaoCa.RowTemplate.Height = 25;
            dgv_GiaoCa.Size = new Size(914, 217);
            dgv_GiaoCa.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTimKiem_GiaoCa);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 24);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 51);
            panel1.TabIndex = 0;
            // 
            // txtTimKiem_GiaoCa
            // 
            txtTimKiem_GiaoCa.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem_GiaoCa.Location = new Point(74, 16);
            txtTimKiem_GiaoCa.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem_GiaoCa.Name = "txtTimKiem_GiaoCa";
            txtTimKiem_GiaoCa.Size = new Size(291, 27);
            txtTimKiem_GiaoCa.TabIndex = 1;
            txtTimKiem_GiaoCa.TextChanged += txtTimkiemGiaoca_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvNhanVien);
            groupBox3.Controls.Add(panel3);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 636);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(920, 341);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 75);
            dgvNhanVien.Margin = new Padding(3, 4, 3, 4);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 25;
            dgvNhanVien.Size = new Size(914, 262);
            dgvNhanVien.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTimKiem_NhanVien);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 24);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(914, 51);
            panel3.TabIndex = 2;
            // 
            // txtTimKiem_NhanVien
            // 
            txtTimKiem_NhanVien.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem_NhanVien.Location = new Point(74, 16);
            txtTimKiem_NhanVien.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem_NhanVien.Name = "txtTimKiem_NhanVien";
            txtTimKiem_NhanVien.Size = new Size(291, 27);
            txtTimKiem_NhanVien.TabIndex = 1;
            txtTimKiem_NhanVien.TextChanged += txtTimkiemnv_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 21);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Tìm kiếm:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvGCCT);
            groupBox4.Controls.Add(panel2);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 296);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(920, 340);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Giao ca chi tiết";
            // 
            // dgvGCCT
            // 
            dgvGCCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvGCCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGCCT.Dock = DockStyle.Fill;
            dgvGCCT.Location = new Point(3, 75);
            dgvGCCT.Margin = new Padding(3, 4, 3, 4);
            dgvGCCT.Name = "dgvGCCT";
            dgvGCCT.RowHeadersWidth = 51;
            dgvGCCT.RowTemplate.Height = 25;
            dgvGCCT.Size = new Size(914, 261);
            dgvGCCT.TabIndex = 2;
            dgvGCCT.CellClick += dgvGCCT_CellClick_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExcel);
            panel2.Controls.Add(txtTimKiem_GCCT);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 24);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 51);
            panel2.TabIndex = 1;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.FromArgb(64, 79, 105);
            btnExcel.Cursor = Cursors.Hand;
            btnExcel.Dock = DockStyle.Right;
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.ForeColor = Color.White;
            btnExcel.Location = new Point(772, 0);
            btnExcel.Margin = new Padding(3, 4, 3, 4);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(142, 51);
            btnExcel.TabIndex = 2;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnexcel_Click;
            // 
            // txtTimKiem_GCCT
            // 
            txtTimKiem_GCCT.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem_GCCT.Location = new Point(74, 16);
            txtTimKiem_GCCT.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem_GCCT.Name = "txtTimKiem_GCCT";
            txtTimKiem_GCCT.Size = new Size(291, 27);
            txtTimKiem_GCCT.TabIndex = 1;
            txtTimKiem_GCCT.TextChanged += txtTimkiemCt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 21);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Tìm kiếm:";
            // 
            // Frm_US_GiaoCa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_US_GiaoCa";
            Size = new Size(1250, 977);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_GiaoCa).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGCCT).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox cmbnhanvien;
        private DateTimePicker dateGiaoca;
        private Label label9;
        private DateTimePicker dateVe;
        private DateTimePicker dateDen;
        private Button btnThem_TenCa;
        private ComboBox cmbTenca;
        private TextBox txtTienbangiao;
        private TextBox txtSanpham;
        private RichTextBox txtGhichu;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label10;
        private Label label11;
        private DataGridView dgv_GiaoCa;
        private Panel panel1;
        private TextBox txtTimKiem_GiaoCa;
        private Label label1;
        private DataGridView dgvNhanVien;
        private Panel panel3;
        private TextBox txtTimKiem_NhanVien;
        private Label label3;
        private DataGridView dgvGCCT;
        private Panel panel2;
        private Button btnExcel;
        private TextBox txtTimKiem_GCCT;
        private Label label2;
        private Panel panel4;
        private Button btnSua;
        private Panel panel6;
        private Button btnHuyca;
        private Panel panel5;
        private Button btnThem_BangCa;
    }
}
