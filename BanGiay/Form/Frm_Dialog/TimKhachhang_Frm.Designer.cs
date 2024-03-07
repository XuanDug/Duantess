namespace PRL.Frm_Main
{
    partial class TimKhachhang_Frm
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
            groupBox1 = new GroupBox();
            btnChon = new Button();
            btnThem = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label1 = new Label();
            txtTen = new TextBox();
            dgv_Objects = new DataGridView();
            txtSdt = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChon);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(12, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 92);
            groupBox1.TabIndex = 73;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnChon
            // 
            btnChon.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnChon.Location = new Point(281, 15);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(165, 71);
            btnChon.TabIndex = 14;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnChon_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(66, 15);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(165, 71);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(422, 12);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(103, 30);
            btnTimKiem.TabIndex = 76;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(12, 12);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm số điện thoại...";
            txtTimKiem.Size = new Size(404, 30);
            txtTimKiem.TabIndex = 74;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 72;
            label1.Text = "Tên:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(12, 67);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(246, 33);
            txtTen.TabIndex = 71;
            // 
            // dgv_Objects
            // 
            dgv_Objects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Objects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Objects.Location = new Point(12, 204);
            dgv_Objects.Name = "dgv_Objects";
            dgv_Objects.RowTemplate.Height = 25;
            dgv_Objects.Size = new Size(513, 194);
            dgv_Objects.TabIndex = 70;
            dgv_Objects.CellClick += dgv_Objects_CellClick;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(264, 67);
            txtSdt.Multiline = true;
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(261, 33);
            txtSdt.TabIndex = 71;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 45);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 72;
            label2.Text = "Số điện thoại:";
            // 
            // TimKhachhang_Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 408);
            Controls.Add(groupBox1);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSdt);
            Controls.Add(txtTen);
            Controls.Add(dgv_Objects);
            Name = "TimKhachhang_Frm";
            Text = "TimKhachhang_Frm";
            Load += TimKhachhang_Frm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnChon;
        private Button btnThem;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label1;
        private TextBox txtTen;
        private DataGridView dgv_Objects;
        private TextBox txtSdt;
        private Label label2;
    }
}