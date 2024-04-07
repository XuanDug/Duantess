using BUS.IServices;
using DAL.Models.DomainClass;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS.Services
{
	public class KhachHangService : IKhachHangService
	{
		private KhachHangRepository _repos;
		public KhachHangService()
		{
			_repos = new KhachHangRepository();
		}
		public string AddKhachHang(Khachhang khachhang)
		{
			// Kiểm tra Tenkhachhang
			if (string.IsNullOrEmpty(khachhang.Tenkhachhang) || khachhang.Tenkhachhang.Length > 30 || !Regex.IsMatch(khachhang.Tenkhachhang, @"^[a-zA-Z\s]+$"))
			{
				throw new ArgumentException("Tên khách hàng không hợp lệ");
			}

			// Kiểm tra Sdt
			if (string.IsNullOrEmpty(khachhang.Sdt) || khachhang.Sdt.Length != 10 || !Regex.IsMatch(khachhang.Sdt, @"^0[0-9]{9}$"))
			{
				throw new ArgumentException("Số điện thoại không hợp lệ");
			}

			// Kiểm tra trùng Sdt
			var SDTTrungKhachhang = _repos.GetAllKhachhang(null).FirstOrDefault(x => x.Sdt == khachhang.Sdt);
			if (SDTTrungKhachhang != null)
			{
				throw new ArgumentException("Số điện thoại đã tồn tại");
			}

			var MaTrungKhachhang = _repos.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == khachhang.Makhachhang);
			if (MaTrungKhachhang != null)
			{
				throw new ArgumentException("Mã khách hàng đã tồn tại");
			}

			// Kiểm tra Diemkhachhang
			if (khachhang.Diemkhachhang < 0)
			{
				throw new ArgumentException("Điểm khách hàng không hợp lệ");
			}

			// Thực hiện thêm khách hàng nếu tất cả các điều kiện đều thỏa mãn
			try
			{
				_repos.AddKhachHang(khachhang);
				return "Thêm thành công";
			}
			catch (Exception ex)
			{
				throw new ArgumentException("Thêm thất bại", ex);
			}
		}

		public List<Hoadon> GetAllHoadon()
		{
			return _repos.GetAllHoadon();
		}

		public List<Khachhang> GetAllKhachhang(string search)
		{
			return _repos.GetAllKhachhang(search);
		}

		public List<Hinhthucthanhtoan> GetHinhthucthanhtoans()
		{
			return _repos.GetHinhthucthanhtoans();
		}

		public string Khoa_MoKhoa(Khachhang khachhang)
		{
			var cloer = _repos.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == khachhang.Makhachhang);
			if (cloer == null)
			{
				return "Sửa thất bại";
			}
			else
			{
				if (cloer.Trangthai == true)
				{
					cloer.Trangthai = false;
					_repos.UpdateKhachHang(cloer);
					return "Khoá thành công";
				}
				else if (cloer.Trangthai == false)
				{
					cloer.Trangthai = true;
					_repos.UpdateKhachHang(cloer);
					return "Mở Khoá thành công";
				}
				return "";
			}
		}
		public string UpdateKhachHang(Khachhang khachhang)
		{
			if (string.IsNullOrEmpty(khachhang.Tenkhachhang) || khachhang.Tenkhachhang.Length > 30 || !Regex.IsMatch(khachhang.Tenkhachhang, @"^[a-zA-Z\s]+$"))
			{
				throw new ArgumentException("Tên khách hàng không hợp lệ");
			}

			// Kiểm tra Sdt
			if (string.IsNullOrEmpty(khachhang.Sdt) || khachhang.Sdt.Length != 10 || !Regex.IsMatch(khachhang.Sdt, @"^0[0-9]{9}$"))
			{
				throw new ArgumentException("Số điện thoại không hợp lệ");
			}

			// Kiểm tra Diemkhachhang
			if (khachhang.Diemkhachhang < 0)
			{
				throw new ArgumentException("Điểm khách hàng không hợp lệ");
			}

			// Thực hiện cập nhật khách hàng nếu tất cả các điều kiện đều thỏa mãn

			var cloer = _repos.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == khachhang.Makhachhang);
			try
			{
				if (cloer == null)
				{
					throw new ArgumentException("Sửa thất bại");
				}
				else
				{
					cloer.Tenkhachhang = khachhang.Tenkhachhang;
					cloer.Sdt = khachhang.Sdt;
					cloer.Diemkhachhang = khachhang.Diemkhachhang;
					cloer.Trangthai = khachhang.Trangthai;
					_repos.UpdateKhachHang(cloer);
					return "Sửa thành công";
				}
			}
			catch
			{
				throw new ArgumentException("Có lỗi xảy ra");
			}
		}
	}
}
