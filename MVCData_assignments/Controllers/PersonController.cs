using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCBasicsAssignment1.Models;

namespace MVCBasicsAssignment1.Controllers
{
    public class PersonController : Controller
    {
        Person _person = new Person();
        List<Person> _personsList = Person.personsList;


        public IActionResult Index()
        {
            return View("Person", _personsList);
        }

        [HttpGet]
        public IActionResult People()
        {
            return View("Person", _personsList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonViewModel personVM)
        {
            if (ModelState.IsValid)
            {
                _personsList = Person.addPerson(personVM.Name, personVM.City, personVM.Phonenumber);
            }

            return View("Person", _personsList);
        }
        //[HttpPost]
        //public IActionResult Delete(Person person)
        //{
        //    return View(person);
        //}
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (Person.removePerson(id))
            {
                _personsList = Person.personsList;
                ViewBag.DeleteMsg = "Successfully deleted";
            }
            else ViewBag.DeleteMsg = "Delete failed";
            return View("Person", _personsList);
        }

        [HttpPost]
        public IActionResult Filter(Person person)
        {
            Console.Write(person);

            List<Person> _filteredList = _person.filterPerson(person);
            return View("Person", _filteredList);
        }
    }
}