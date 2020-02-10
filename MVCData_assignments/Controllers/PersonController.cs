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
        PersonListViewModel personListVM = new PersonListViewModel();

        public PersonController()
        {
            _personService = new PersonService();
        }

        public IActionResult Index()
        {
            personListVM.PersonList = _personService.getAll();
            return View(personListVM);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonCreateModel personVM)
        {
            if (ModelState.IsValid)
            {
                personListVM.PersonList = _personService.addPerson(personVM.Name, personVM.City, personVM.Phonenumber);
                return RedirectToAction("Index", personListVM);

            }

            return View();
        }


        public IActionResult Delete(int id)
        {
            if (_personService.removePerson(id))
            {
                personListVM.PersonList = _personService.getAll();
                ViewBag.DeleteMsg = "Successfully deleted";
            }
            else ViewBag.DeleteMsg = "Delete failed";
            return View("Index", personListVM);
        }

        [HttpPost]
        public IActionResult Filter(string filter)
        {
            personListVM.Filter = filter;
            personListVM.PersonList = _personService.filterPerson(filter);
            return View("Index", personListVM);
        }
    }
}