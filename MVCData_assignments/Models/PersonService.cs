using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCData_assignments.Models;

namespace MVCData_assignments.Models
{
    public class PersonService : IPersonService
    {
        public static List<Person> personList = new List<Person>();


        public PersonService()
        {
            //personList.Add(new Person("Anna Andersson", "Anderstorp", "111-2222333"));
            //personList.Add(new Person("Bosse Bildoktorn", "Bollebygd", "222-223344"));
            //personList.Add(new Person("Ceasar Carlsson", "Cöpenhamn", "333-2224455"));
            //personList.Add(new Person("Daniel Doppsko", "Sålundastad", "444-2255667"));
        }

        public List<Person> getAll()
        {
            return personList;
        }

        public List<Person> addPerson(string name, string city, string phonenumber)
        {
            Person per = new Person(name, city, phonenumber);
            personList.Add(per);
            return personList;
        }

        public bool removePerson(int id)
        {
            Person per = personList.Find(p => p.Id == id);
            return personList.Remove(per);
        }

        public List<Person> filterPerson(string filterP)
        {
            List<Person> filteredList = new List<Person>();
            List<Person> returnList = new List<Person>();

            if (!string.IsNullOrEmpty(filterP))
                filteredList = personList.FindAll(p => p.Name.Contains(filterP));
            returnList = filteredList;

            if (!string.IsNullOrEmpty(filterP))
                filteredList = personList.FindAll(p => p.City.Contains(filterP));

            var templist = returnList.Concat(filteredList);
            returnList = templist.ToList();

            if (!string.IsNullOrEmpty(filterP))
                filteredList = personList.FindAll(p => p.Phonenumber.Contains(filterP));

            templist = returnList.Concat(filteredList);
            returnList = templist.Distinct().ToList();

            return returnList;
        }
    }
}
