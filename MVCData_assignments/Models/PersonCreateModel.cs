using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCData_assignments.Models
{
    public class PersonCreateModel
    {
        [Required]
        [StringLength(32, ErrorMessage = "The name is too long", MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [StringLength(32, ErrorMessage = "The city name is too long", MinimumLength = 1)]
        public string City { get; set; }
        public string Phonenumber { get; set; }
    }
}
