namespace PRL.Form
{
    partial class Giay_Frm
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
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            txtTen = new TextBox();
            dgv_Objects = new DataGridView();
            btnTimKiem = new Button();
            cbbTimKiem = new ComboBox();
            txtTimKiem = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(14, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 92);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(281, 15);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(165, 71);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 50);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 65;
            label1.Text = "Tên:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(14, 72);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(513, 33);
            txtTen.TabIndex = 63;
            // 
            // dgv_Objects
            // 
            dgv_Objects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Objects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Objects.Location = new Point(14, 209);
            dgv_Objects.Name = "dgv_Objects";
            dgv_Objects.RowTemplate.Height = 25;
            dgv_Objects.Size = new Size(513, 194);
            dgv_Objects.TabIndex = 61;
            dgv_Objects.CellClick += dgv_Objects_CellClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.Location = new Point(424, 17);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(103, 30);
            btnTimKiem.TabIndex = 69;
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
            cbbTimKiem.TabIndex = 68;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(14, 17);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm...";
            txtTimKiem.Size = new Size(246, 30);
            txtTimKiem.TabIndex = 67;
            // 
            // Giay_Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 420);
            Controls.Add(btnTimKiem);
            Controls.Add(cbbTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtTen);
            Controls.Add(dgv_Objects);
            Name = "Giay_Frm";
            Text = "Giay_Form";
            Load += Giay_Frm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private TextBox txtTen;
        private DataGridView dgv_Objects;
        private Button btnTimKiem;
        private ComboBox cbbTimKiem;
        private TextBox txtTimKiem;
    }
}