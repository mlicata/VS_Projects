﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.API
{
    public class POICreationDto
    {
        [Required(ErrorMessage = "A 'Name' is required")]
        [MaxLength(50, ErrorMessage = "Your 'Name' is too long, max length is 200 characters.")]
        public string Name { get; set; }
        [MaxLength(200, ErrorMessage = "Your 'Description' is too long, max length is 200 characters.")]
        public string Desc { get; set; }
    }
}
