using HotelFinder.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Busines.Abstract
{
    public interface IHotelService
    {
        List<Hotel> GetAllHotels();
        Hotel GetById(int id);
        Hotel Create(Hotel hotel);
        Hotel Update(Hotel hotel);
        void Delete(int id);
    }
}
