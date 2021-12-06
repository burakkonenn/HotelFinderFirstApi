﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelFinder.entities
{
    public class Hotel
    {
        
        
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Cities { get; set; }

    }
}
