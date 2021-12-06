using HotelFinder.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Abstract
{
    public interface IHotelRepository
    {
        List<Hotel> GetAllHotels();
        Hotel GetById(int id);
        Hotel Create(Hotel hotel);
        Hotel Update(Hotel hotel);
        void Delete(int id);
    }
}
