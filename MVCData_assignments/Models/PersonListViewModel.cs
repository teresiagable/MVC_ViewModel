using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCData_assignments.Models
{
    public class PersonListViewModel
    {
        public List<Person> PersonList { get; set; }
        public string Filter { get; set; }
    }
}
