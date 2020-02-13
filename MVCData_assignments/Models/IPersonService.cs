using System.Collections.Generic;

namespace MVCData_assignments.Models
{
    public interface IPersonService
    {
        List<Person> CreatePerson(string name, string city, string phonenumber);
        List<Person> FilterPerson(string filterP);
        List<Person> GetAll();
        Person GetById(int id);
        bool RemovePerson(int id);
        bool UpdatePerson(Person person);
    }
}