﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasicsAssignment1.Models
{
    public class PersonViewModel
    {
        [Required]
        [StringLength(32, ErrorMessage = "The name is too long", MinimumLength = 1)]
        public string Name { get; set; }
        public string City { get; set; }
        public string Phonenumber { get; set; }

    }
}
