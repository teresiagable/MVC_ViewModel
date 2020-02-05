using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCData_assignments.Models;

namespace MVCData_assignments.Controllers
{
    public class PersonController : Controller
    {

        IPersonService _personService;
        List<Person> _personsList = new List<Person>();
        public PersonController()
        {
            _personService = new PersonService();
        }

        public IActionResult Index()
        {
            return View("Person", _personService.getAll());
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonViewModel personVM)
        {
            if (ModelState.IsValid)
            {
                _personsList = _personService.addPerson(personVM.Name, personVM.City, personVM.Phonenumber);
            }

            return View("Person", _personsList);
        }


        public IActionResult Delete(int id)
        {
            if (_personService.removePerson(id))
            {
                _personsList = _personService.getAll();
                ViewBag.DeleteMsg = "Successfully deleted";
            }
            else ViewBag.DeleteMsg = "Delete failed";
            return View("Person", _personsList);
        }

        [HttpPost]
        public IActionResult Filter(string filterString)
        {

            List<Person> _filteredList = _personService.filterPerson(filterString);
            return View("Person", _filteredList);
        }
    }
}