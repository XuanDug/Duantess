using BUS.IServices;
using BUS.Services;
using DAL.Models.DomainClass;
using NUnit.Framework.Interfaces;

namespace Tesst
{
    public class Tests
    {
        GiayService _service;
        bool actual, expected;
        public void CheckIDContain(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id không được phép là số âm");
            }
            List<Giay> giays = _service.GetAll(null, null);
            foreach (var item in giays)
            {
                if(item.Magiay == id)
                {
                    throw new ArgumentException("Sản phẩm đã tồn tại!");
                }
            }
        }
        private bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length > 251 || !System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Vui lòng nhập tên hợp lệ!");
            }
            else
            {
                return true;
            }
        }

        [SetUp] 
        public void Setup()
        {
            _service = new GiayService();
        }
        #region getbyID
        [TestCase(-1)]
        public void getGiayById1(int id)
        {
            var Giay = _service.GetByID(id);
            Assert.IsNull(Giay); // vì nhập id  không có trong db => không tìm thấy => trả ra null 
        }
        [TestCase(4)]
        public void getGiayById4(int id)
        {
            var Giay = _service.GetByID(id);
            Assert.AreEqual(id, Giay.Magiay); // kiểm tra xem id truyền vào và mã giày get ra có giống nhau không 
            // giống nhau rồi thì nó sẽ get được ra => sẽ tìm thấy 
            Assert.IsNotNull(Giay); // vì nhập id  có trong db => tìm thấy => không được null 
        }
        [TestCase(0)]
        public void getGiayById0(int id)
        {
            var Giay = _service.GetByID(id);
            Assert.IsNull(Giay); // vì nhập id = 0 không có trong db => không tìm thấy => trả ra null 
        }
        #endregion

        #region getAll
        [TestCase("a", "tenGiay")]
        public void getAllBySearchName(string textSearch, string searchType)
        {
            var lstSearch = _service.GetAll(textSearch, searchType);
            Assert.AreEqual(17, lstSearch.Count); // có 1 đôi Nike Air Force
        }
        [TestCase("1", "maGiay")]
        public void getAllBySearchmaGiay(string textSearch, string searchType)
        {
            var lstSearch = _service.GetAll(textSearch, searchType);
            // vì không có mã nào là 1 nên sẽ count sẽ bằng 0
            Assert.AreEqual(0, lstSearch.Count);
        }
        [TestCase("s", "All")]
        public void getAllBySearchAll(string textSearch, string searchType)
        {
            var lstSearch = _service.GetAll(textSearch, searchType);
            // có 6 đôi chứa chữ s 
            Assert.AreEqual(10, lstSearch.Count);
        }
        [TestCase("null", "null")]
        public void getAll(string textSearch, string searchType)
        {
            var lstSearch = _service.GetAll(textSearch, searchType);
            // truyền vào null => trả về all
            Assert.AreEqual(17, lstSearch.Count);
        }
        #endregion

        #region Add
        [TestCase("adidas")]
        public void AddGiay1(string name)
        {
            var giay = new Giay()
            {
                Tengiay = name
            };
            expected = _service.Them(giay);
            actual = true;
            List<Giay> giays = _service.GetAll(null, null);
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(giays.Contains(giay)); // check nó được phép tồn tại cái tên đó trong list
        }
        [TestCase("nike")]
        public void AddGiay6(string name)
        {
            var giay = new Giay()
            {
                Tengiay = name
            };
            expected = _service.Them(giay);
            actual = true;
            List<Giay> giays = _service.GetAll(null, null);
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(giays.Contains(giay)); // check nó được phép tồn tại cái tên đó trong list
        }

        [TestCase("puma")]
        public void AddGiay7(string name)
        {
            var giay = new Giay()
            {
                Tengiay = name
            };
            expected = _service.Them(giay);
            actual = true;
            List<Giay> giays = _service.GetAll(null, null);
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(giays.Contains(giay)); // check nó được phép tồn tại cái tên đó trong list
        }

        [TestCase("reebok")]
        public void AddGiay8(string name)
        {
            var giay = new Giay()
            {
                Tengiay = name
            };
            expected = _service.Them(giay);
            actual = true;
            List<Giay> giays = _service.GetAll(null, null);
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(giays.Contains(giay)); // check nó được phép tồn tại cái tên đó trong list
        }

        [TestCase("new balance")]
        public void AddGiay9(string name)
        {
            var giay = new Giay()
            {
                Tengiay = name
            };
            expected = _service.Them(giay);
            actual = true;
            List<Giay> giays = _service.GetAll(null, null);
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(giays.Contains(giay)); // check nó được phép tồn tại cái tên đó trong list
        }
        [TestCase("adidassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")]
        public void AddGiay2(string name)
        {
            var giay = new Giay()
            {
                Tengiay = name
            };
            expected = _service.Them(giay);
            actual = false;
            Assert.AreEqual(expected, actual);

            Assert.Throws(typeof(ArgumentException), () => IsValidName(giay.Tengiay));
        }
        [TestCase("")]
        public void AddGiay3(string name)
        {
            var giay = new Giay();
            giay.Magiay = 10;
            giay.Tengiay = name;
            expected = _service.Them(giay);
            actual = false;
            Assert.AreEqual(expected, actual);
            Assert.Throws(typeof(ArgumentException), () => IsValidName(giay.Tengiay));
            Assert.Throws(typeof(ArgumentException), () => CheckIDContain(giay.Magiay));
        }
        [TestCase(-1)]
        public void AddGiay4(int id)
        {
            var giay = new Giay();
            giay.Magiay = id;
            giay.Tengiay = "adidas";
            expected = _service.Them(giay);
            actual = false;
            Assert.AreEqual(expected, actual);
            Assert.Throws(typeof(ArgumentException), () => CheckIDContain(giay.Magiay));
        }
        [TestCase(12)]
        public void AddGiay5(int id)
        {
            var giay = new Giay();
            giay.Magiay = id;
            giay.Tengiay = "adidas";
            expected = _service.Them(giay);
            actual = false;
            Assert.AreEqual(expected, actual);
            Assert.Throws(typeof(ArgumentException), () => CheckIDContain(giay.Magiay));
        }

        #endregion

        #region Update 
        [TestCase(1)]
        public void Update1(int id)
        {
            var giay = new Giay();
            giay.Magiay = id;
            giay.Tengiay = "adidas";
            List<Giay> giays = _service.GetAll(null, null);
            expected = _service.Sua(id,giay);
            actual = false;
            Assert.AreEqual(expected, actual);
            Assert.IsFalse(giays.Contains(giay)); // check xem có ăn id không ? 
        }
        [TestCase(12)]
        public void Update2(int id)
        {
            var giay = new Giay();
            giay.Magiay = id;
            giay.Tengiay = "adidas";
            _service.Sua(id,giay);
            expected = _service.Sua(id, giay);
            actual = true;
            Assert.AreEqual(expected, actual);
        }
        [TestCase("adidassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")]
        public void Update3(string name)
        {
            var giay = new Giay();
            giay.Magiay = 12;
            giay.Tengiay = name;
            expected = _service.Sua(12, giay);
            actual = false;
            Assert.AreEqual(expected, actual);

            Assert.Throws(typeof(ArgumentException), () => IsValidName(giay.Tengiay));
        }
        [TestCase("")]
        public void Update4(string name)
        {
            var giay = new Giay();
            giay.Magiay = 12;
            giay.Tengiay = name;
            expected = _service.Sua(12, giay);
            actual = false;
            Assert.AreEqual(expected, actual);
            Assert.Throws(typeof(ArgumentException), () => IsValidName(giay.Tengiay));
        }
        [TestCase("qqqadidassssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")]
        public void Update5(string name)
        {
            var giay = new Giay();
            giay.Magiay = 12;
            giay.Tengiay = name;
            expected = _service.Sua(12, giay);
            actual = false;
            Assert.AreEqual(expected, actual);
            Assert.Throws(typeof(ArgumentException), () => IsValidName(giay.Tengiay));
        }

        #endregion

        #region Khoa_MoKhoa
        [TestCase(0)]
        public void Khoa_MoKhoa(int id)
        {
            _service.Khoa_MoKhoa(id);
            expected = _service.Khoa_MoKhoa(id);
            actual = false;
            Assert.AreEqual(expected, actual);
        }
          [TestCase(11)]
        public void Khoa_MoKhoa2(int id)
        {
            _service.Khoa_MoKhoa(id);
            expected = _service.Khoa_MoKhoa(id);
            actual = true;
            Assert.AreEqual(expected, actual);
        }
           [TestCase(26)]
        public void Khoa_MoKhoa3(int id)
        {
            _service.Khoa_MoKhoa(id);
            expected = _service.Khoa_MoKhoa(id);
            actual = true;
            Assert.AreEqual(expected, actual);
        }
        [TestCase(21)]

        public void Khoa_MoKhoa4(int id)
        {
            _service.Khoa_MoKhoa(id);
            expected = _service.Khoa_MoKhoa(id);
            actual = true;
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}