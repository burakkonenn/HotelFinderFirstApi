using HotelFinder.DataAccess.Abstract;
using HotelFinder.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public Hotel Create(Hotel hotel)
        {
            using (var context = new HotelDbContext())
            {
                context.Hotels.Add(hotel);
                context.SaveChanges();
                return hotel;
            }
        }

        public void Delete(int id)
        {
            using (var context = new HotelDbContext())
            {
                var deletedHotel = GetById(id);
                context.Hotels.Remove(deletedHotel);
                context.SaveChanges();
            }
        }

        public List<Hotel> GetAllHotels()
        {
            using (var context = new HotelDbContext())
            {
                return context.Hotels.ToList();
            }
        }

        public Hotel GetById(int id)
        {
            using(var context = new HotelDbContext())
            {
                return context.Hotels.Find(id);
            }
        }

        public Hotel Update(Hotel hotel)
        {
            using (var context = new HotelDbContext())
            {
                context.Hotels.Update(hotel);
                context.SaveChanges();
                return hotel;
            }
        }
    }
}
