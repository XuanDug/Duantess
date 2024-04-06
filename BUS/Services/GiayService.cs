using BUS.IServices;
using DAL.Models.DomainClass;
using DAL.Repositories;

namespace BUS.Services
{
    public class GiayService:IGiayService
    {
        GiayRepository _Rep;
        public GiayService()
        {
            _Rep = new GiayRepository();
        }
        public List<Giay> GetAll(string? txtSearch, string? searchType)
        {
            return _Rep.GetAll(txtSearch, searchType);
        }
        public Giay GetByID(int id)
        {
            return _Rep.GetByID(id);
        }
        public bool Khoa_MoKhoa(int id)
        {
            if (id == 0|| id == null)
            {
                return false;
            }
            return _Rep.Khoa_MoKhoa(id);
        }
        public bool Sua(int id, Giay Giay)
        {
            if(Giay.Tengiay == "") 
            {
                return false;
            }
            return _Rep.Sua(id, Giay);
        }
        public bool Them(Giay Giay)
        {
            if(Giay.Tengiay == "")
            {
                return false;
            }
            return _Rep.Them(Giay);
        }
    }
}
