using System.Collections.Generic;

namespace MVCData_assignments.Models
{
    public interface IPersonService
    {
        List<Person> AddPerson(string name, string city, string phonenumber);
        List<Person> FilterPerson(string filterP);
        List<Person> GetAll();
        Person GetById(int id);
        bool RemovePerson(int id);
        bool EditPerson(Person person);
    }
}