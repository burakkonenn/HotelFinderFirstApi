using HotelFinder.Busines.Abstract;
using HotelFinder.Busines.Concrete;
using HotelFinder.entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private IHotelService _hotelService;
        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        /// <summary>
        /// GetAllHotels
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var hotels = _hotelService.GetAllHotels();

            return Ok(hotels);
        }
        /// <summary>
        /// Get with Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{action}/{id}")]
        public IActionResult Get(int id)
        {
            var hotels = _hotelService.GetById(id);
            if(hotels != null)
            {
                return Ok(hotels);
            }
            return NotFound();
        }
        [HttpGet]
        [Route("{action}/{name}")]
        public IActionResult Get(string name)
        {
            
            return Ok();
        }
        /// <summary>
        /// Post
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody]Hotel hotel)
        {
          
                var createdHotel = _hotelService.Create(hotel);
                return CreatedAtAction("Get", new { id = createdHotel.Id }, createdHotel);
       
        }
        /// <summary>
        /// For Update
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put([FromBody]Hotel hotel)
        {
            if(_hotelService.GetById(hotel.Id)!=null)
            {
                return Ok(_hotelService.Update(hotel));
            }
            return NotFound();

        }

        /// <summary>
        /// For Delete
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if(_hotelService.GetById(id)!=null)
            {;
                return Ok();
            };
            return NotFound();
        }


    }
}
