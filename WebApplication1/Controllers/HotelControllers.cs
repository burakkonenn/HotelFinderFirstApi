using HotelFinder.Busines.Abstract;
using HotelFinder.entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelControllers : ControllerBase
    {
        private IHotelService _hotelService;
        public HotelControllers(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }


        [HttpGet]
        public List<Hotel> Get()
        {
            return _hotelService.GetAllHotels();
        }

        [HttpGet("{id}")]
        public Hotel Get(int id)
        {
            return _hotelService.GetById(id);
        }

        
    }
}
