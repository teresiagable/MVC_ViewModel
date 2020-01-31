using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasicsAssignment1.Models
{
    public class Person
    {

        static int PersonId = 0;

        [Key]
        public int Id { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Phonenumber { get; set; }

        public static List<Person> personsList = new List<Person>();

        public Person()
        {
            Id = ++PersonId;
        }

        public Person(string name, string city, string phonenumber)
        {
            Id = ++PersonId;
            Name = name;
            City = city;
            Phonenumber = phonenumber;
        }

        public static List<Person> addPerson(string name, string city, string phonenumber)
        {
            Person pelle = new Person(name, city, phonenumber);
            personsList.Add(pelle);
            return personsList;
        }

        public static bool removePerson(int id)
        {
            Person pelle = personsList.Find(p => p.Id == id);

            return personsList.Remove(pelle);
        }

        public List<Person> filterPerson(Person filterP)
        {
            List<Person> filteredList = new List<Person>();

            //fix overwrite propblem
            if (!string.IsNullOrEmpty(filterP.Name))
                filteredList = personsList.FindAll(p => p.Name.Contains(filterP.Name));
            //if (!string.IsNullOrEmpty(filterP.City))
            //    filteredList = personsList.FindAll(p => p.Name.Contains(filterP.City));
            //if (!string.IsNullOrEmpty(filterP.Phonenumber))
            //    filteredList = personsList.FindAll(p => p.Name.Contains(filterP.Phonenumber));

            return filteredList;
        }
    }
}
