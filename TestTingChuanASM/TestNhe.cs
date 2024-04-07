using NUnit.Framework;
using BUS.IServices;
using DAL.Models.DomainClass;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using BUS.Services;

namespace Test
{
	public class TestNhe
	{
		private KhachHangService _khachHangService;

		[SetUp]
		public void SetUp()
		{
			_khachHangService = new KhachHangService();
		}
		#region Serch
		//1
		[TestCase("0291111221")]
		public void getBySDT(string SDT)
		{
			var listSDT = _khachHangService.GetAllKhachhang(SDT); //có 1 sdt là 0291111221
			Assert.AreEqual(1, listSDT.Count);
		}
		//2
		[TestCase("9")]
		public void getBySDT9(string SDT)
		{
			var listSDT = _khachHangService.GetAllKhachhang(SDT); //Vì không có SDT nào số đầu tiên là 9
			Assert.AreEqual(0, listSDT.Count);
		}
		//3
		[TestCase("E")]
		public void getBySDTChu(string SDT)
		{
			var listSDT = _khachHangService.GetAllKhachhang(SDT); //Vì sdt là số không nhận chữ
			Assert.AreEqual(0, listSDT.Count);
		}
		#endregion
		#region Add
		//4
		[Test]
		public void TestAddKhachHangThemThanhCong()//Thêm thành công
		{
			var khachhang = new Khachhang
			{
				Tenkhachhang = "Chun",
				Sdt = "0291111221",
				Diemkhachhang = 0,
				Trangthai = true
			};

			_khachHangService.AddKhachHang(khachhang);
			var kh = _khachHangService.GetAllKhachhang(null);
			Assert.AreEqual(11, kh.Count); //Kiểm tra xem giá trị có bằng 1 hay không
			Assert.IsTrue(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
		}
		//5 Test
		[Test]
		public void TestAddKhachHangCheckTenChuaSo()
		{
			var khachhang = new Khachhang()
			{
				Tenkhachhang = "123", // Tên khách hàng chỉ chứa số
				Sdt = "0123456789",
				Diemkhachhang = 0,
				Trangthai = true
			};
			Assert.Throws<ArgumentException>(() => _khachHangService.AddKhachHang(khachhang));
			var kh = _khachHangService.GetAllKhachhang(null);
			Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
		}
		//6
		[Test]
		public void TestAddKhachHangCheckTenChuaKyTuDacBiet()
		{
			var khachhang = new Khachhang()
			{
				Tenkhachhang = "Chuan@", // Tên khách hàng chứa ký tự đặc biệt
				Sdt = "0123456789",
				Diemkhachhang = 0,
				Trangthai = true
			};

			Assert.Throws<ArgumentException>(() => _khachHangService.AddKhachHang(khachhang));
			var kh = _khachHangService.GetAllKhachhang(null);
			Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
		}
		//7
		[Test]
		public void TestAddKhachHangCheckTenQua30KyTu()
		{
			var khachhang = new Khachhang()
			{
				Tenkhachhang = "ChuanNguyenChuanNguyenChuanNguyenChuanNguyenChuan", // Tên khách hàng quá 30 ký tự
				Sdt = "0123456789",
				Diemkhachhang = 0,
				Trangthai = true
			};
			Assert.Throws<ArgumentException>(() => _khachHangService.AddKhachHang(khachhang));
			var kh = _khachHangService.GetAllKhachhang(null);
			Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
		}
		//8
		[Test]
		public void TestAddKhachHangCheckSDT()
		{
			var khachhang = new Khachhang
			{
				Tenkhachhang = "Chuan",
				Sdt = "1234567890", // Số điện thoại không bắt đầu bằng số 0
				Diemkhachhang = 0,
				Trangthai = true
			};

			Assert.Throws<ArgumentException>(() => _khachHangService.AddKhachHang(khachhang));
			var kh = _khachHangService.GetAllKhachhang(null);
			Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
		}
		//9
		[Test]
		public void TestAddKhachHangCheckSDTduoi10sovasodau0phailaso0()
		{
			var khachhang = new Khachhang
			{
				Tenkhachhang = "Chuan",
				Sdt = "123456", // Số điện thoại dưới 10 số và số đầu không phải là số 0
				Diemkhachhang = 0,
				Trangthai = true
			};

			Assert.Throws<ArgumentException>(() => _khachHangService.AddKhachHang(khachhang));
			var kh = _khachHangService.GetAllKhachhang(null);
			Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
		}
		//10
		[Test]
		public void TestAddKhachHangCheckSDTduoi10sovasodaulaso0()
		{
			var khachhang = new Khachhang
			{
				Tenkhachhang = "Chuan",
				Sdt = "0123456", // Số điện thoại dưới 10 số và số đầu là số 0
				Diemkhachhang = 0,
				Trangthai = true
			};

			Assert.Throws<ArgumentException>(() => _khachHangService.AddKhachHang(khachhang));
			var kh = _khachHangService.GetAllKhachhang(null);
			Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
		}
		//11
		[Test]
		public void TestAddKhachHangCheckSDTtren10sovasodaulaso0()
		{
			var khachhang = new Khachhang
			{
				Tenkhachhang = "Chuan",
				Sdt = "01234567891123", // Số điện thoại trên 10 số và số đầu là số 0
				Diemkhachhang = 0,
				Trangthai = true
			};

			Assert.Throws<ArgumentException>(() => _khachHangService.AddKhachHang(khachhang));
			var kh = _khachHangService.GetAllKhachhang(null);
			Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
		}
		//12
		[Test]
		public void TestAddKhachHangCheckSDTtren10sovasodau0phailaso0()
		{
			var khachhang = new Khachhang
			{
				Tenkhachhang = "Chuan",
				Sdt = "12345678911230", // Số điện thoại trên 10 số và số đầu không phải là số 0
				Diemkhachhang = 0,
				Trangthai = true
			};

			Assert.Throws<ArgumentException>(() => _khachHangService.AddKhachHang(khachhang));
			var kh = _khachHangService.GetAllKhachhang(null);
			Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
		}
		//13
		[Test]
		public void TestAddKhachHangCheckSDTChuachucai()
		{
			var khachhang = new Khachhang
			{
				Tenkhachhang = "Chuan",
				Sdt = "012345678a", // Số điện thoại chứa chữ cái 
				Diemkhachhang = 0,
				Trangthai = true
			};

			Assert.Throws<ArgumentException>(() => _khachHangService.AddKhachHang(khachhang));
			var kh = _khachHangService.GetAllKhachhang(null);
			Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
		}
		//14
		[Test]
		public void TestAddKhachHangCheckSDTChuaKyTuDacBiet()
		{
			var khachhang = new Khachhang
			{
				Tenkhachhang = "Chuan",
				Sdt = "012345678@", // Số điện thoại chứa ký tự đặc biệt
				Diemkhachhang = 0,
				Trangthai = true
			};

			Assert.Throws<ArgumentException>(() => _khachHangService.AddKhachHang(khachhang));
			var kh = _khachHangService.GetAllKhachhang(null);
			Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
		}
		//15
		[Test]
		public void TestAddKhachHangSDTdatontai()
		{
			var khachhang = new Khachhang
			{
				Tenkhachhang = "Chuan",
				Sdt = "0291111221", // Số điện thoại tồn tại
				Diemkhachhang = 0,
				Trangthai = true
			};

			Assert.Throws<ArgumentException>(() => _khachHangService.AddKhachHang(khachhang));
			var kh = _khachHangService.GetAllKhachhang(null);
			Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
		}
		//16
		[Test]
		public void TestAddKhachHangDiemKhachHangAm()
		{
			var khachhang = new Khachhang
			{
				Tenkhachhang = "Chuan",
				Sdt = "0600000000", // Số điện thoại tồn tại
				Diemkhachhang = -4,
				Trangthai = true
			};

			Assert.Throws<ArgumentException>(() => _khachHangService.AddKhachHang(khachhang));
			var kh = _khachHangService.GetAllKhachhang(null);
			Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
		}
		#endregion
		#region update
		//17
		[Test]
		public void TestUpdateKhachHangTenChiChuaSo()
		{
			int IDKhachHang = 6;

			// Lấy thông tin của khách hàng từ cơ sở dữ liệu sử dụng ID đã chọn
			var KhachHang = _khachHangService.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == IDKhachHang);

			if (KhachHang != null)
			{
				var khachhang = new Khachhang
				{
					Makhachhang = KhachHang.Makhachhang,
					Tenkhachhang = "123", // Tên khách hàng chỉ chứa số
					Sdt = KhachHang.Sdt,
					Diemkhachhang = KhachHang.Diemkhachhang,
					Trangthai = KhachHang.Trangthai
				};
				Assert.Throws<ArgumentException>(() => _khachHangService.UpdateKhachHang(khachhang));
				var kh = _khachHangService.GetAllKhachhang(null);
				Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
			}
			else
			{
				Assert.Inconclusive("Không tìm thấy khách hàng có ID được chỉ định.");
			}
		}
		//18
		[Test]
		public void TestUpdateKhachHangTenChuaKyTuDacBiet()
		{
			int IDKhachHang = 6;

			var KhachHang = _khachHangService.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == IDKhachHang);

			if (KhachHang != null)
			{
				var khachhang = new Khachhang
				{
					Makhachhang = KhachHang.Makhachhang,
					Tenkhachhang = "chuan@", // Tên khách hàng chỉ chứa số
					Sdt = KhachHang.Sdt,
					Diemkhachhang = KhachHang.Diemkhachhang,
					Trangthai = KhachHang.Trangthai
				};
				Assert.Throws<ArgumentException>(() => _khachHangService.UpdateKhachHang(khachhang));
				var kh = _khachHangService.GetAllKhachhang(null);
				Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
			}
			else
			{
				Assert.Inconclusive("Không tìm thấy khách hàng có ID được chỉ định.");
			}
		}
		//19
		[Test]
		public void TestUpdateKhachHangTenQua30KyTu()
		{
			int IDKhachHang = 6;

			var KhachHang = _khachHangService.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == IDKhachHang);

			if (KhachHang != null)
			{
				var khachhang = new Khachhang
				{
					Makhachhang = KhachHang.Makhachhang,
					Tenkhachhang = "ChuanNguyenChuanNguyenChuanNguyenChuanNguyenChuan", // Tên khách hàng quá 30 ký tự
					Sdt = KhachHang.Sdt,
					Diemkhachhang = KhachHang.Diemkhachhang,
					Trangthai = KhachHang.Trangthai
				};
				Assert.Throws<ArgumentException>(() => _khachHangService.UpdateKhachHang(khachhang));
				var kh = _khachHangService.GetAllKhachhang(null);
				Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
			}
			else
			{
				Assert.Inconclusive("Không tìm thấy khách hàng có ID được chỉ định.");
			}
		}
		//20 Sửa tên thành công
		[Test]
		public void TestUpdateKhachHangTenThanhCong()
		{
			int IDKhachHang = 6;

			var KhachHang = _khachHangService.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == IDKhachHang);

			if (KhachHang != null)
			{
				var khachhang = new Khachhang
				{
					Makhachhang = KhachHang.Makhachhang,
					Tenkhachhang = "ChuanNguyen", // Tên khách hàng hợp lệ
					Sdt = KhachHang.Sdt,
					Diemkhachhang = KhachHang.Diemkhachhang,
					Trangthai = KhachHang.Trangthai
				};
				_khachHangService.UpdateKhachHang(khachhang);
				var updatedKhachHangDB = _khachHangService.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == IDKhachHang);

				Assert.IsNotNull(updatedKhachHangDB); // Kiểm tra xem khách hàng đã tồn tại trong cơ sở dữ liệu
				Assert.AreEqual("ChuanNguyen", updatedKhachHangDB.Tenkhachhang); // Kiểm tra xem tên khách hàng đã được cập nhật chính xác trong cơ sở dữ liệu
			}
			else
			{
				Assert.Inconclusive("Không tìm thấy khách hàng có ID được chỉ định.");
			}
		}
		//21
		[Test]
		public void TestUpdateKhachHangSDTItHon10So()
		{
			int IDKhachHang = 6;

			var KhachHang = _khachHangService.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == IDKhachHang);

			if (KhachHang != null)
			{
				var khachhang = new Khachhang
				{
					Makhachhang = KhachHang.Makhachhang,
					Tenkhachhang = KhachHang.Tenkhachhang,
					Sdt = "02345678", //SDT ít hơn 10 số
					Diemkhachhang = KhachHang.Diemkhachhang,
					Trangthai = KhachHang.Trangthai
				};
				Assert.Throws<ArgumentException>(() => _khachHangService.UpdateKhachHang(khachhang));
				var kh = _khachHangService.GetAllKhachhang(null);
				Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
			}
			else
			{
				Assert.Inconclusive("Không tìm thấy khách hàng có ID được chỉ định.");
			}
		}
		//22
		[Test]
		public void TestUpdateKhachHangSDTNhieuHon10So()
		{
			int IDKhachHang = 6;

			var KhachHang = _khachHangService.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == IDKhachHang);

			if (KhachHang != null)
			{
				var khachhang = new Khachhang
				{
					Makhachhang = KhachHang.Makhachhang,
					Tenkhachhang = KhachHang.Tenkhachhang,
					Sdt = "0934567887654", //SDT nhiều hơn 10 số
					Diemkhachhang = KhachHang.Diemkhachhang,
					Trangthai = KhachHang.Trangthai
				};
				Assert.Throws<ArgumentException>(() => _khachHangService.UpdateKhachHang(khachhang));
				var kh = _khachHangService.GetAllKhachhang(null);
				Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
			}
			else
			{
				Assert.Inconclusive("Không tìm thấy khách hàng có ID được chỉ định.");
			}
		}
		//23
		[Test]
		public void TestUpdateKhachHangSDTChuaChuCai()
		{
			int IDKhachHang = 6;

			var KhachHang = _khachHangService.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == IDKhachHang);

			if (KhachHang != null)
			{
				var khachhang = new Khachhang
				{
					Makhachhang = KhachHang.Makhachhang,
					Tenkhachhang = KhachHang.Tenkhachhang,
					Sdt = "034391942a", //SDT chứa chữ cái
					Diemkhachhang = KhachHang.Diemkhachhang,
					Trangthai = KhachHang.Trangthai
				};
				Assert.Throws<ArgumentException>(() => _khachHangService.UpdateKhachHang(khachhang));
				var kh = _khachHangService.GetAllKhachhang(null);
				Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
			}
			else
			{
				Assert.Inconclusive("Không tìm thấy khách hàng có ID được chỉ định.");
			}
		}
		//24
		[Test]
		public void TestUpdateKhachHangSDTChuaKyTuDacBiet()
		{
			int IDKhachHang = 6;

			var KhachHang = _khachHangService.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == IDKhachHang);

			if (KhachHang != null)
			{
				var khachhang = new Khachhang
				{
					Makhachhang = KhachHang.Makhachhang,
					Tenkhachhang = KhachHang.Tenkhachhang,
					Sdt = "034391942@", //SDT chứa ký tự đặc biệt
					Diemkhachhang = KhachHang.Diemkhachhang,
					Trangthai = KhachHang.Trangthai
				};
				Assert.Throws<ArgumentException>(() => _khachHangService.UpdateKhachHang(khachhang));
				var kh = _khachHangService.GetAllKhachhang(null);
				Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
			}
			else
			{
				Assert.Inconclusive("Không tìm thấy khách hàng có ID được chỉ định.");
			}
		}
		//25Sửa SDT thành công
		[Test]
		public void TestUpdateKhachHangSDTThanhCong()
		{
			int IDKhachHang = 6;

			var KhachHang = _khachHangService.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == IDKhachHang);

			if (KhachHang != null)
			{
				var khachhang = new Khachhang
				{
					Makhachhang = KhachHang.Makhachhang,
					Tenkhachhang = KhachHang.Tenkhachhang,
					Sdt = "0343019422", //SDT hợp lệ
					Diemkhachhang = KhachHang.Diemkhachhang,
					Trangthai = KhachHang.Trangthai
				};
				_khachHangService.UpdateKhachHang(khachhang);
				var updatedKhachHangDB = _khachHangService.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == IDKhachHang);

				Assert.IsNotNull(updatedKhachHangDB); // Kiểm tra xem khách hàng đã tồn tại trong cơ sở dữ liệu
				Assert.AreEqual("0343019422", updatedKhachHangDB.Sdt); // Kiểm tra xem tên khách hàng đã được cập nhật chính xác trong cơ sở dữ liệu
			}
			else
			{
				Assert.Inconclusive("Không tìm thấy khách hàng có ID được chỉ định.");
			}
		}
		//26
		[Test]
		public void TestUpdateKhachHangDiemAm()
		{
			int IDKhachHang = 6;

			var KhachHang = _khachHangService.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == IDKhachHang);

			if (KhachHang != null)
			{
				var khachhang = new Khachhang
				{
					Makhachhang = KhachHang.Makhachhang,
					Tenkhachhang = KhachHang.Tenkhachhang,
					Sdt = KhachHang.Sdt,
					Diemkhachhang = -4, //điểm khách hàng âm
					Trangthai = KhachHang.Trangthai
				};
				Assert.Throws<ArgumentException>(() => _khachHangService.UpdateKhachHang(khachhang));
				var kh = _khachHangService.GetAllKhachhang(null);
				Assert.IsFalse(kh.Contains(khachhang));//Kiểm tra xem KH có tồn tại trong db KhachHang hay không
			}
			else
			{
				Assert.Inconclusive("Không tìm thấy khách hàng có ID được chỉ định.");
			}
		}
		//27Sửa điểm thành công
		[Test]
		public void TestUpdateKhachHangDiemThanhCong()
		{
			int IDKhachHang = 6;

			var KhachHang = _khachHangService.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == IDKhachHang);

			if (KhachHang != null)
			{
				var khachhang = new Khachhang
				{
					Makhachhang = KhachHang.Makhachhang,
					Tenkhachhang = KhachHang.Tenkhachhang,
					Sdt = KhachHang.Sdt,
					Diemkhachhang = 6,
					Trangthai = KhachHang.Trangthai
				};
				_khachHangService.UpdateKhachHang(khachhang);
				var updatedKhachHangDB = _khachHangService.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == IDKhachHang);

				Assert.IsNotNull(updatedKhachHangDB); // Kiểm tra xem khách hàng đã tồn tại trong cơ sở dữ liệu
				Assert.AreEqual(6, updatedKhachHangDB.Diemkhachhang); // Kiểm tra xem tên khách hàng đã được cập nhật chính xác trong cơ sở dữ liệu
			}
			else
			{
				Assert.Inconclusive("Không tìm thấy khách hàng có ID được chỉ định.");
			}
		}
		#endregion
	}
}
