using BUS.Services;
using DAL.Models.DomainClass;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Tests
    {
        private ThuongHieuServices _services;
        bool exception;
        bool actual;
        private bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length >= 50 || !System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Vui lòng nhập tên hợp lệ!");
            }
            else
            {
                return true;
            }
        }
        private bool IsValidID(int id)
        {
            if (1 > id || id > 10)
            {
                throw new ArgumentException("Vui lòng nhập id hợp lệ!");
            }
            else
            {
                return true;
            }
        }
        [SetUp]
        public void Setup()
        {
            _services = new ThuongHieuServices();
        }

        [Test]
        public void AddThuongHieu1()
        {
            var ThuongHieu = new Thuonghieu
            {
                Mathuonghieu = 1,
                Tenthuonghieu = "dior",
                Email = "tranha10112004@gmail.com",
                Sdt = "0969293263",
                Trangthai = true,
                Mota = "gggggggggg",
                Mataikhoan = 1,
            };
            _services.Them(ThuongHieu);
            var TH = _services.GetAll(null, null);
            Assert.AreEqual(4, TH.Count);
        }
        [Test]
        public void AddThuongHieu2()
        {
            var ThuongHieu = new Thuonghieu
            {
                Mathuonghieu = 2,
                Tenthuonghieu = "aelimited",
                Email = "tranha1011@gmail.com",
                Sdt = "0969293263",
                Trangthai = true,
                Mota = "gggggggggg",
                Mataikhoan = 1,
            };
            _services.Them(ThuongHieu);
            var TH = _services.GetAll(null, null);
            Assert.AreEqual(4, TH.Count);
        }
        [Test]
        public void AddThuongHieu3()
        {
            var ThuongHieu = new Thuonghieu
            {
                Mathuonghieu = 3,
                Tenthuonghieu = "lv",
                Email = "tranha18tuoi@gmail.com",
                Sdt = "0969293263",
                Trangthai = false,
                Mota = "ggg",
                Mataikhoan = 1,
            };
            _services.Them(ThuongHieu);
            var TH = _services.GetAll(null, null);
            Assert.AreEqual(4, TH.Count);
        }
        [Test]
        public void AddThuongHieu4()
        {
            var ThuongHieu = new Thuonghieu
            {
                Mathuonghieu = 4,
                Tenthuonghieu = "quang chau",
                Email = "tranha@gmail.com",
                Sdt = "0969293263",
                Trangthai = true,
                Mota = "ggg",
                Mataikhoan = 1,
            };
            _services.Them(ThuongHieu);
            var TH = _services.GetAll(null, null);
            Assert.AreEqual(4, TH.Count);
        }
        [Test]
        public void AddThuongHieu5()
        {
            var ThuongHieu = new Thuonghieu
            {
                Mathuonghieu = 5,
                Tenthuonghieu = "dior,lv",
                Email = "tranha1011@gmail.com",
                Sdt = "0969293263",
                Trangthai = true,
                Mota = "hhhhhhh",
                Mataikhoan = 1,
            };
            _services.Them(ThuongHieu);
            var TH = _services.GetAll(null, null);
            Assert.AreEqual(4, TH.Count);
        }

        [TestCase(1)]
        public void upDate1(int id)
        {
            var ThuongHieu = new Thuonghieu();
            ThuongHieu.Mathuonghieu = id;
            ThuongHieu.Tenthuonghieu = "dior";
            ThuongHieu.Email = "tranha10112004@gmail.com";
            ThuongHieu.Sdt = "0969293263";
            ThuongHieu.Trangthai = true;
            ThuongHieu.Mota = "gggggggggg";
            ThuongHieu.Mataikhoan = 1;
            _services.Sua(id, ThuongHieu);
            exception = _services.Sua(id, ThuongHieu);
            actual = false;
            Assert.AreEqual(exception, actual);
        }
        [TestCase(2)]
        public void upDate2(int id)
        {
            var ThuongHieu = new Thuonghieu();
            ThuongHieu.Mathuonghieu = id;
            ThuongHieu.Tenthuonghieu = "dior";
            ThuongHieu.Email = "tranha10112004@gmail.com";
            ThuongHieu.Sdt = "0969293263";
            ThuongHieu.Trangthai = true;
            ThuongHieu.Mota = "gggggggggg";
            ThuongHieu.Mataikhoan = 1;
            _services.Sua(id, ThuongHieu);
            exception = _services.Sua(id, ThuongHieu);
            actual = true;
            Assert.AreEqual(exception, actual);
        }
        [TestCase("100")]
        public void upDate3(int id)
        {
            var ThuongHieu = new Thuonghieu();
            ThuongHieu.Mathuonghieu = id;
            ThuongHieu.Tenthuonghieu = "dior";
            ThuongHieu.Email = "tranha10112004@gmail.com";
            ThuongHieu.Sdt = "0969293263";
            ThuongHieu.Trangthai = true;
            ThuongHieu.Mota = "gggggggggg";
            ThuongHieu.Mataikhoan = 1;
            _services.Sua(id, ThuongHieu);
            exception = _services.Sua(id, ThuongHieu);
            actual = false;
            Assert.AreEqual(exception, actual);
        }

        [TestCase("diorrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr")]
        public void upDate4(string name)
        {
            var ThuongHieu = new Thuonghieu();
            ThuongHieu.Mathuonghieu = 1;
            ThuongHieu.Tenthuonghieu = name;
            ThuongHieu.Email = "tranha10112004@gmail.com";
            ThuongHieu.Sdt = "0969293263";
            ThuongHieu.Trangthai = true;
            ThuongHieu.Mota = "gggggggggg";
            ThuongHieu.Mataikhoan = 1;
            _services.Sua(1, ThuongHieu);
            actual = false;
            Assert.AreEqual(exception, actual);
            Assert.Throws(typeof(ArgumentException), () => IsValidName(ThuongHieu.Tenthuonghieu));
        }
        [TestCase("lvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv")]
        public void upDate5(string name)
        {
            var ThuongHieu = new Thuonghieu();
            ThuongHieu.Mathuonghieu = 1;
            ThuongHieu.Tenthuonghieu = name;
            ThuongHieu.Email = "tranha10112004@gmail.com";
            ThuongHieu.Sdt = "0969293263";
            ThuongHieu.Trangthai = true;
            ThuongHieu.Mota = "gggggggggg";
            ThuongHieu.Mataikhoan = 1;
            _services.Sua(1, ThuongHieu);
            actual = false;
            Assert.AreEqual(exception, actual);
            Assert.Throws(typeof(ArgumentException), () => IsValidName(ThuongHieu.Tenthuonghieu));
        }
        [TestCase("tranha101120044444444444444444444444444444444444444444444444444444444444444444444444@gmail.com")]
        public void upDate6(string Email)
        {
            var ThuongHieu = new Thuonghieu();
            ThuongHieu.Mathuonghieu = 1;
            ThuongHieu.Tenthuonghieu = "dior";
            ThuongHieu.Email = Email;
            ThuongHieu.Sdt = "0969293263";
            ThuongHieu.Trangthai = true;
            ThuongHieu.Mota = "gggggggggg";
            ThuongHieu.Mataikhoan = 1;
            _services.Sua(1, ThuongHieu);
            actual = false;
            Assert.AreEqual(exception, actual);
            Assert.Throws(typeof(ArgumentException), () => IsValidName(ThuongHieu.Email));
        }
        [TestCase(0)]
        public void Khoa_MoKhoa1(int id)
        {
            _services.Khoa_MoKhoa(id);
            exception = _services.Khoa_MoKhoa(id);
            actual = false;
            Assert.AreEqual(exception, actual);
        }
        [TestCase(4)]
        public void Khoa_MoKhoa2(int id)
        {
            _services.Khoa_MoKhoa(id);
            exception = _services.Khoa_MoKhoa(id);
            actual = true;
            Assert.AreEqual(exception, actual);
        }
        [TestCase(2)]
        public void Khoa_MoKhoa3(int id)
        {
            _services.Khoa_MoKhoa(id);
            exception = _services.Khoa_MoKhoa(id);
            actual = true;
            Assert.AreEqual(exception, actual);
        }
        [TestCase(6)]
        public void Khoa_MoKhoa4(int id)
        {
            _services.Khoa_MoKhoa(id);
            exception = _services.Khoa_MoKhoa(id);
            actual = true;
            Assert.AreEqual(exception, actual);
        }
        [TestCase(5)]
        public void Khoa_MoKhoa5(int id)
        {
            _services.Khoa_MoKhoa(id);
            exception = _services.Khoa_MoKhoa(id);
            actual = true;
            Assert.AreEqual(exception, actual);
        }
        [TestCase("50")]
        public void upDate7(int id)
        {
            var ThuongHieu = new Thuonghieu();
            ThuongHieu.Mathuonghieu = id;
            ThuongHieu.Tenthuonghieu = "dior";
            ThuongHieu.Email = "tranha10112004@gmail.com";
            ThuongHieu.Sdt = "0969293263";
            ThuongHieu.Trangthai = true;
            ThuongHieu.Mota = "gggggggggg";
            ThuongHieu.Mataikhoan = 1;
            _services.Sua(id, ThuongHieu);
            exception = _services.Sua(id, ThuongHieu);
            actual = false;
            Assert.AreEqual(exception, actual);
        }
        [TestCase("100000")]
        public void upDate8(int id)
        {
            var ThuongHieu = new Thuonghieu();
            ThuongHieu.Mathuonghieu = id;
            ThuongHieu.Tenthuonghieu = "dior";
            ThuongHieu.Email = "tranha10112004@gmail.com";
            ThuongHieu.Sdt = "0969293263";
            ThuongHieu.Trangthai = true;
            ThuongHieu.Mota = "gggggggggg";
            ThuongHieu.Mataikhoan = 1;
            _services.Sua(id, ThuongHieu);
            exception = _services.Sua(id, ThuongHieu);
            actual = false;
            Assert.AreEqual(exception, actual);
        }
        [Test]
        public void AddThuongHieu6()
        {
            var ThuongHieu = new Thuonghieu
            {
                Mathuonghieu = 5,
                Tenthuonghieu = "dior,lv.aelimited",
                Email = "tranha1011@gmail.com",
                Sdt = "0969293263",
                Trangthai = true,
                Mota = "hhhhhhh",
                Mataikhoan = 1,
            };
            _services.Them(ThuongHieu);
            var TH = _services.GetAll(null, null);
            Assert.AreEqual(4, TH.Count);
        }
        [Test]
        public void AddThuongHieu7()
        {
            var ThuongHieu = new Thuonghieu
            {
                Mathuonghieu = 5,
                Tenthuonghieu = "diorrrrrrrrrrrrrrr",
                Email = "tranha1011@gmail.com",
                Sdt = "0969293263",
                Trangthai = false,
                Mota = "hhhhhhh",
                Mataikhoan = 1,
            };
            _services.Them(ThuongHieu);
            var TH = _services.GetAll(null, null);
            Assert.AreEqual(4, TH.Count);
        }
        [Test]
        public void AddThuongHieu9()
        {
            var ThuongHieu = new Thuonghieu
            {
                Mathuonghieu = 5,
                Tenthuonghieu = "dior,lvvvvvvvvvvvvvvvvv",
                Email = "tranha1011@gmail.com",
                Sdt = "096929333",
                Trangthai = true,
                Mota = "hhhhhhh",
                Mataikhoan = 1,
            };
            _services.Them(ThuongHieu);
            var TH = _services.GetAll(null, null);
            Assert.AreEqual(4, TH.Count);
        }
        [TestCase(3)]
        public void Khoa_MoKhoa6(int id)
        {
            _services.Khoa_MoKhoa(id);
            exception = _services.Khoa_MoKhoa(id);
            actual = false;
            Assert.AreEqual(exception, actual);
        }
        [TestCase("tranha101120044444444444444444444444444444444444444444444444444444444444444444444444@gmail.com")]
        public void upDate7(string Mota)
        {
            var ThuongHieu = new Thuonghieu();
            ThuongHieu.Mathuonghieu = 1;
            ThuongHieu.Tenthuonghieu = "dior";
            ThuongHieu.Email = "tranha10112004";
            ThuongHieu.Sdt = "0969293263";
            ThuongHieu.Trangthai = true;
            ThuongHieu.Mota = Mota;
            ThuongHieu.Mataikhoan = 1;
            _services.Sua(1, ThuongHieu);
            actual = false;
            Assert.AreEqual(exception, actual);
            Assert.Throws(typeof(ArgumentException), () => IsValidName(ThuongHieu.Mota));
        }
        [TestCase("154")]
        public void upDate9(int id)
        {
            var ThuongHieu = new Thuonghieu();
            ThuongHieu.Mathuonghieu = id;
            ThuongHieu.Tenthuonghieu = "dior";
            ThuongHieu.Email = "tranha10112004@gmail.com";
            ThuongHieu.Sdt = "0969293263";
            ThuongHieu.Trangthai = false;
            ThuongHieu.Mota = "gggggggggg";
            ThuongHieu.Mataikhoan = 1;
            _services.Sua(id, ThuongHieu);
            exception = _services.Sua(id, ThuongHieu);
            actual = false;
            Assert.AreEqual(exception, actual);
        }
        [TestCase(123)]
        public void Khoa_MoKhoa8(int id)
        {
            _services.Khoa_MoKhoa(id);
            exception = _services.Khoa_MoKhoa(id);
            actual = false;
            Assert.AreEqual(exception, actual);
        }
    }
}