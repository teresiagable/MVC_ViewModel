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
        public IActionResult Index()
        {
            return View("Person", Person.personsList);
        }

        [HttpGet]
        public IActionResult People()
        {
            return View("Person", Person.personsList);
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
                Person.personsList.Add(new Person(personVM.Name, personVM.City, personVM.Phonenumber));
            }

            return View("Person", Person.personsList);
        }
        //[HttpPost]
        //public IActionResult Delete(Person person)
        //{
        //    return View(person);
        //}
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Person pelle = Person.personsList.Find(p => p.Id == id);
            return View("Person");
        }

        //[HttpPost]
        //public IActionResult Filter(string searchString)
        //{

        //    return View("Person", person);
        //}
    }
}