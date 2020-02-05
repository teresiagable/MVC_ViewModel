using System.Collections.Generic;

namespace MVCData_assignments.Models
{
    public interface IPersonService
    {
        List<Person> addPerson(string name, string city, string phonenumber);
        List<Person> filterPerson(string filterP);
        List<Person> getAll();
        bool removePerson(int id);
    }
}