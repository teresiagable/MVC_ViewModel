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

        public List<Person> filterPerson(string FieldToFilter, string searchString)
        {
            List<Person> filteredList = new List<Person>();
            switch (FieldToFilter.ToLower())
            {

                case "city":
                    filteredList = personsList.FindAll(p => p.City.Contains(searchString));
                    break;
                case "phonenumber":
                    filteredList = personsList.FindAll(p => p.Phonenumber.Contains(searchString));
                    break;
                case "name":
                default:
                    filteredList = personsList.FindAll(p => p.Name.Contains(searchString));
                    break;
            }

            return filteredList;
        }
    }
}
