namespace PRL
{
    partial class ThuongHieu_Frm
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
            btnTimKiem = new Button();
            cbbTimKiem = new ComboBox();
            txtTimKiem = new TextBox();
            groupBox1 = new GroupBox();
            btnKhoa_MoKhoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label2 = new Label();
            label1 = new Label();
            txtMoTa = new TextBox();
            txtTen = new TextBox();
            dgv_Objects = new DataGridView();
            txtSDT = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).BeginInit();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(424, 17);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(103, 30);
            btnTimKiem.TabIndex = 51;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(266, 19);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(150, 23);
            cbbTimKiem.TabIndex = 50;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(14, 17);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(246, 30);
            txtTimKiem.TabIndex = 49;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKhoa_MoKhoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(14, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 92);
            groupBox1.TabIndex = 48;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnKhoa_MoKhoa
            // 
            btnKhoa_MoKhoa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhoa_MoKhoa.Location = new Point(72, 51);
            btnKhoa_MoKhoa.Name = "btnKhoa_MoKhoa";
            btnKhoa_MoKhoa.Size = new Size(113, 35);
            btnKhoa_MoKhoa.TabIndex = 13;
            btnKhoa_MoKhoa.Text = "Khóa/Mở khóa";
            btnKhoa_MoKhoa.UseVisualStyleBackColor = true;
            btnKhoa_MoKhoa.Click += btnKhoaMoKhoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(133, 16);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 32);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(37, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 32);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 113);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 46;
            label2.Text = "Mô tả:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 50);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 47;
            label1.Text = "Tên:";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(281, 135);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(246, 128);
            txtMoTa.TabIndex = 44;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(14, 72);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(261, 33);
            txtTen.TabIndex = 45;
            // 
            // dgv_Objects
            // 
            dgv_Objects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Objects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Objects.Location = new Point(14, 272);
            dgv_Objects.Name = "dgv_Objects";
            dgv_Objects.RowTemplate.Height = 25;
            dgv_Objects.Size = new Size(513, 131);
            dgv_Objects.TabIndex = 43;
            dgv_Objects.CellClick += dgv_Objects_CellClick;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(14, 135);
            txtSDT.Multiline = true;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(261, 33);
            txtSDT.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 113);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 47;
            label3.Text = "Số điện thoại:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(281, 72);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 33);
            txtEmail.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 54);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 47;
            label4.Text = "Email:";
            // 
            // ThuongHieu_Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 420);
            Controls.Add(btnTimKiem);
            Controls.Add(cbbTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtMoTa);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(dgv_Objects);
            Name = "ThuongHieu_Frm";
            Text = "ThuongHieu";
            Load += ThuongHieu_Form_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTimKiem;
        private ComboBox cbbTimKiem;
        private TextBox txtTimKiem;
        private GroupBox groupBox1;
        private Button btnKhoa_MoKhoa;
        private Button btnSua;
        private Button btnThem;
        private Label label2;
        private Label label1;
        private TextBox txtMoTa;
        private TextBox txtTen;
        private DataGridView dgv_Objects;
        private TextBox txtSDT;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
    }
}