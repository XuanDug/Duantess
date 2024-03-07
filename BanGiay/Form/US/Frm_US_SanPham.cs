using BUS.Services;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using PRL.Form;
using PRL.Frm_Main;
using PRL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanGiay.Form.US
{
    public partial class Frm_US_SanPham : UserControl
    {
        public Frm_US_SanPham()
        {
            InitializeComponent();
        }
        ChiTietGiayService _Ser_ChiTietGiay = new ChiTietGiayService();
        ChatLieuService _Ser_ChatLieu = new ChatLieuService();
        GiayService _Ser_Giay = new GiayService();
        KichCoService _Ser_KichCo = new KichCoService();
        KieuDangService _Ser_KieuDang = new KieuDangService();
        MauSacService _Ser_MauSac = new MauSacService();
        ThuongHieuServices _Ser_ThuongHieu = new ThuongHieuServices();
        List<Giay> _lstGiay = new List<Giay>();
        List<Chatlieu> _lstChatLieu = new List<Chatlieu>();
        List<Kichco> _LstKichCo = new List<Kichco>();
        List<Kieudang> _lstKieuDang = new List<Kieudang>();
        List<Mausac> _lstMauSac = new List<Mausac>();
        List<Thuonghieu> _lstThuongHieu = new List<Thuonghieu>();
        List<Giaychitiet> _lstGiayChiTiet = new List<Giaychitiet>();
        DangNhap_Frm formDangNhap = new DangNhap_Frm();
        int idClicked;
        bool checkedTexbox;

        private void ptbChatLieu_Click(object sender, EventArgs e)
        {
            ChatLieu_Frm formChatLieu = new ChatLieu_Frm();
            formChatLieu.ShowDialog();
            LoadCBB_ChatLieu(null);
        }
        private void ptbThuongHieu_Click(object sender, EventArgs e)
        {
            ThuongHieu_Frm formThuongHieu = new ThuongHieu_Frm();
            formThuongHieu.ShowDialog();
            LoadCBB_ThuongHieu(null);
        }
        private void ptbGiay_Click(object sender, EventArgs e)
        {
            Giay_Frm formGiay = new Giay_Frm();
            formGiay.ShowDialog();
            LoadCBB_Giay(null);
        }
        private void ptbKieuDang_Click(object sender, EventArgs e)
        {
            KieuDang_Frm formKieuDang = new KieuDang_Frm();
            formKieuDang.ShowDialog();
            LoadCBB_KieuDang(null);
        }
        private void ptbMauSac_Click(object sender, EventArgs e)
        {
            MauSac_Frm formMauSac = new MauSac_Frm();
            formMauSac.ShowDialog();
            LoadCBB_MauSac(null);

        }
        private void ptbKichCo_Click(object sender, EventArgs e)
        {
            KichCo_Frm formKichCo = new KichCo_Frm();
            formKichCo.ShowDialog();
            LoadCBB_KichCo(null);

        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            LoadCBB_TimKiem();
            LoadCBB_Giay(idClicked);
            LoadCBB_ThuongHieu(idClicked);
            LoadCBB_KieuDang(idClicked);
            LoadCBB_ChatLieu(idClicked);
            LoadCBB_MauSac(idClicked);
            LoadCBB_KichCo(idClicked);
            LoadDataGridView(null, null);
            ClearTextBox();
        }
        public void ClearTextBox()
        {
            txtGia.Text = "";
            txtMoTa.Text = "";
            txtSoLuong.Text = "";
            txtTimKiem.Text = "";
            cbbTenGiay.Enabled = true;
            cbbTenThuongHieu.Enabled = true;
        }
        public void LoadCBB_TimKiem()
        {
            cbbTimKiem.Items.Clear();
            cbbTimKiem.Items.Add(SearchType.All);
            cbbTimKiem.Items.Add(SearchType.maGiay);
            cbbTimKiem.Items.Add(SearchType.maChatLieu);
            cbbTimKiem.Items.Add(SearchType.maMauSac);
            cbbTimKiem.Items.Add(SearchType.maKichCo);
            cbbTimKiem.Items.Add(SearchType.maThuongHieu);
            cbbTimKiem.Items.Add(SearchType.maKieuDang);
            cbbTimKiem.Items.Add(SearchType.soLuongTrongKhoNhoHon);
            cbbTimKiem.Items.Add(SearchType.soLuongTrongKhoLonHon);
            cbbTimKiem.Items.Add(SearchType.ngayTao_GiayChiTiet);
            cbbTimKiem.Items.Add(SearchType.ngaySua_GiayChiTiet);
            cbbTimKiem.Items.Add(SearchType.idNguoiTao_GiayChiTiet);
            cbbTimKiem.Items.Add(SearchType.idNguoiSua_GiayChiTiet);
            cbbTimKiem.Items.Add(SearchType.giaNhoHon_GiayChiTiet);
            cbbTimKiem.Items.Add(SearchType.giaLonHon_GiayChiTiet);
            cbbTimKiem.Items.Add(SearchType.moTa_GiayChiTiet);
            cbbTimKiem.Items.Add(SearchType.trangThai_GiayChiTiet);
            cbbTimKiem.SelectedIndex = 0;
        }
        public void LoadCBB_Giay(int? idClicked)
        {
            _lstGiay = _Ser_Giay.GetAll("true", "Trạng thái Giày");
            cbbTenGiay.DataSource = _lstGiay.ToList();
            cbbTenGiay.DisplayMember = "TENGIAY";
            cbbTenGiay.ValueMember = "MAGIAY";
        }
        public void LoadCBB_ThuongHieu(int? idClicked)
        {
            _lstThuongHieu = _Ser_ThuongHieu.GetAll("true", "Trạng thái Thương hiệu");
            cbbTenThuongHieu.DataSource = _lstThuongHieu.ToList();
            cbbTenThuongHieu.DisplayMember = "TENTHUONGHIEU";
            cbbTenThuongHieu.ValueMember = "MATHUONGHIEU";
        }
        public void LoadCBB_KieuDang(int? idClicked)
        {
            _lstKieuDang = _Ser_KieuDang.GetAll("true", "Trạng thái Kiểu dáng");
            cbbTenKieuDang.DataSource = _lstKieuDang.ToList();
            cbbTenKieuDang.DisplayMember = "TENKIEUDANG";
            cbbTenKieuDang.ValueMember = "MAKIEUDANG";
        }
        public void LoadCBB_ChatLieu(int? idClicked)
        {
            _lstChatLieu = _Ser_ChatLieu.GetAll("true", "Trạng thái Chất liệu");
            cbbTenChatLieu.DataSource = _lstChatLieu.ToList();
            cbbTenChatLieu.DisplayMember = "TENCHATLIEU";
            cbbTenChatLieu.ValueMember = "MACHATLIEU";
        }
        public void LoadCBB_MauSac(int? idClicked)
        {
            _lstMauSac = _Ser_MauSac.GetAll("true", "Trạng thái Màu sắc");
            cbbTenMauSac.DataSource = _lstMauSac.ToList();
            cbbTenMauSac.DisplayMember = "TENMAUSAC";
            cbbTenMauSac.ValueMember = "MAMAUSAC";

        }
        public void LoadCBB_KichCo(int? idClicked)
        {
            _LstKichCo = _Ser_KichCo.GetAll("true", "Trạng thái Kích cỡ");
            cbbTenKichCo.DataSource = _LstKichCo.ToList();
            cbbTenKichCo.DisplayMember = "TENKICHCO";
            cbbTenKichCo.ValueMember = "MAKICHCO";
        }
        public void LoadDataGridView(string? txtTimKiem, string? SearchType)
        {
            dgvSP.Rows.Clear();

            dgvSP.ColumnCount = 16;
            dgvSP.Columns[0].Name = "STT";
            dgvSP.Columns[1].Name = "Mã giày";
            dgvSP.Columns[2].Name = "Mã giày chi tiết";
            dgvSP.Columns[3].Name = "Mã chất liệu";
            dgvSP.Columns[4].Name = "Mã màu sắc";
            dgvSP.Columns[5].Name = "Mã kích cỡ";
            dgvSP.Columns[6].Name = "Mã thương hiệu";
            dgvSP.Columns[7].Name = "Mã kiểu dáng";
            dgvSP.Columns[8].Name = "Ngày tạo";
            dgvSP.Columns[9].Name = "Mã người tạo";
            dgvSP.Columns[10].Name = "Ngày sửa";
            dgvSP.Columns[11].Name = "Mã người sửa gần nhất";
            dgvSP.Columns[12].Name = "Giá";
            dgvSP.Columns[13].Name = "Mô tả";
            dgvSP.Columns[14].Name = "Số lượng trong kho";
            dgvSP.Columns[15].Name = "Trạng thái";

            _lstGiayChiTiet = _Ser_ChiTietGiay.GetAll(txtTimKiem, SearchType);

            foreach (var item in _lstGiayChiTiet)
            {
                int stt = _lstGiayChiTiet.IndexOf(item) + 1;

                dgvSP.Rows.Add(stt,
                    item.Magiay,
                    item.Magiaychitiet,
                    item.Machatlieu,
                    item.Mamausac,
                    item.Makichco,
                    item.Mathuonghieu,
                    item.Makieudang,
                    item.Ngaytao,
                    item.Nguoitao,
                    item.Ngaysua,
                    item.Nguoisua,
                    item.Gia,
                    item.Mota,
                    item.Soluongcon,
                    (item.Trangthai==true?"Đang hoạt động":"Ngừng hoạt động"));
            }

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDataGridView(txtTimKiem.Text, cbbTimKiem.Text);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            CheckTextbox();
            if (checkedTexbox)
            {

                try
                {
                    var confirmResult = MessageBox.Show("Xác nhận 'thêm' giày không?", "Xác nhận", MessageBoxButtons.OKCancel);

                    if (confirmResult == DialogResult.OK)
                    {
                        bool result;
                        var existingProduct = _Ser_ChiTietGiay.GetAll(null, null)
                                .FirstOrDefault(p =>
                                    p.Magiay == (int)cbbTenGiay.SelectedValue &&
                                    p.Machatlieu == (int)cbbTenChatLieu.SelectedValue &&
                                    p.Mamausac == (int)cbbTenMauSac.SelectedValue &&
                                    p.Makichco == (int)cbbTenKichCo.SelectedValue &&
                                    p.Mathuonghieu == (int)cbbTenThuongHieu.SelectedValue &&
                                    p.Makieudang == (int)cbbTenKieuDang.SelectedValue);
                        if (existingProduct == null)
                        {
                            result = _Ser_ChiTietGiay.Them(new Giaychitiet()
                            {
                                Magiay = (int)cbbTenGiay.SelectedValue,
                                Machatlieu = (int)cbbTenChatLieu.SelectedValue,
                                Mamausac = (int)cbbTenMauSac.SelectedValue,
                                Makichco = (int)cbbTenKichCo.SelectedValue,
                                Mathuonghieu = (int)cbbTenThuongHieu.SelectedValue,
                                Makieudang = (int)cbbTenKieuDang.SelectedValue,
                                Soluongcon = int.Parse(txtSoLuong.Text),
                                Ngaytao = dateTime,
                                Nguoitao = LoginManager.Instance.IdTaiKhoan,
                                Nguoisua = LoginManager.Instance.IdTaiKhoan,
                                Gia = double.Parse(txtGia.Text),
                                Mota = txtMoTa.Text,
                                Trangthai = true
                            });
                        }
                        else
                        {
                            MessageBox.Show("Đã tồn tại sản phẩm có các thuộc tính này");
                            result = false;
                        }

                        if (result)
                        {
                            MessageBox.Show("Đã 'thêm' thành công 1 giày mới");

                            LoadDataGridView(null, null);
                        }
                        else
                        {
                            MessageBox.Show("'Thêm' thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã hủy 'thêm' sản phẩm này");
                    }
                    ClearTextBox();
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            CheckTextbox();
            if (checkedTexbox)
            {
                var confirmResult = MessageBox.Show("Xác nhận 'sửa' giày này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var objGiay = _Ser_ChiTietGiay.GetByID(idClicked);
                    objGiay.Magiay = (int)cbbTenGiay.SelectedValue;
                    objGiay.Machatlieu = (int)cbbTenChatLieu.SelectedValue;
                    objGiay.Mamausac = (int)cbbTenMauSac.SelectedValue;
                    objGiay.Makichco = (int)cbbTenKichCo.SelectedValue;
                    objGiay.Mathuonghieu = (int)cbbTenThuongHieu.SelectedValue;
                    objGiay.Makieudang = (int)cbbTenKieuDang.SelectedValue;
                    objGiay.Soluongcon = int.Parse(txtSoLuong.Text);
                    objGiay.Nguoisua = LoginManager.Instance.IdTaiKhoan;
                    objGiay.Ngaysua = dateTime;
                    objGiay.Gia = double.Parse(txtGia.Text);
                    objGiay.Mota = txtMoTa.Text;

                    var result = _Ser_ChiTietGiay.Sua(idClicked, objGiay);

                    if (result)
                    {
                        MessageBox.Show("Đã 'sửa' giày này thành công");

                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Sửa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'sửa' giày này");
                }
                ClearTextBox();

            }


        }
        private void btnKhoaMoKhoa_Click(object sender, EventArgs e)
        {
            if (_Ser_ChiTietGiay.GetByID(idClicked).Trangthai == true)
            {
                var confirmResult = MessageBox.Show("Xác nhận 'khóa' giày này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser_ChiTietGiay.Khoa_MoKhoa(idClicked);

                    if (result)
                    {
                        MessageBox.Show("Đã 'khóa' giày này thành công");
                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Khóa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'khóa' giày này");
                }
            }
            else
            {
                var confirmResult = MessageBox.Show("Xác nhận 'mở khóa' giày này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser_ChiTietGiay.Khoa_MoKhoa(idClicked);

                    if (result)
                    {
                        MessageBox.Show("Đã 'mở khóa' giày này thành công");
                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Mở khóa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'mở khóa' giày này");
                }

            }
            ClearTextBox();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index < 0 || index >= _lstGiayChiTiet.Count)
            {
                ClearTextBox();
                return;
            }

            var objCellClick = _lstGiayChiTiet[index];

            idClicked = objCellClick.Magiaychitiet;

            cbbTenGiay.SelectedValue = objCellClick.Magiay;
            txtGia.Text = objCellClick.Gia.ToString();
            txtSoLuong.Text = objCellClick.Soluongcon.ToString();
            txtMoTa.Text = objCellClick.Mota;
            cbbTenThuongHieu.SelectedValue = objCellClick.Mathuonghieu;
            cbbTenKieuDang.SelectedValue = objCellClick.Makieudang;
            cbbTenChatLieu.SelectedValue = objCellClick.Machatlieu;
            cbbTenMauSac.SelectedValue = objCellClick.Mamausac;
            cbbTenKichCo.SelectedValue = objCellClick.Makichco;

            cbbTenGiay.Enabled = false;
            cbbTenThuongHieu.Enabled = false;
        }
        private void CheckTextbox()
        {
            if (!double.TryParse(txtGia.Text, out double result))
            {
                MessageBox.Show("Vui lòng nhập giá chỉ chứa số");
                checkedTexbox = false;
            }
            else if (txtMoTa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mô tả không quá 200 từ"); checkedTexbox = false;

            }
            else if (LoginManager.Instance.IdTaiKhoan == 0)
            {
                MessageBox.Show("Lỗi không nhận dạng được tài khoản đang sử dụng"); checkedTexbox = false;

            }
            else if (!int.TryParse(txtSoLuong.Text, out int result1))
            {
                MessageBox.Show("Vui lòng nhập số lượng chỉ chứa số"); checkedTexbox = false;

            }
            else
            {

                checkedTexbox = true;
            }

        }


    }
}
