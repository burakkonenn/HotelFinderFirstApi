using HotelFinder.Busines.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Busines.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository = new HotelRepository();

        public HotelManager()
        {
        }

        public HotelManager(IHotelRepository hotelRepository )
        {
            _hotelRepository = hotelRepository;
        }



        public Hotel Create(Hotel hotel)
        {
            return _hotelRepository.Create(hotel);
        }

        public void Delete(int id)
        {
            _hotelRepository.Delete(id);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetById(int id)
        {
            return _hotelRepository.GetById(id);
        }

        public Hotel Update(Hotel hotel)
        {
            return _hotelRepository.Update(hotel);
        }
    }
}
