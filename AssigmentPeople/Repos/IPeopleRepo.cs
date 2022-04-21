using System.Collections.Generic;
using AssignmentPeople.Models;

namespace AssignmentPeople.Repos
{
    interface IPeopleRepo
    {
        Person Create(Person person);
        List<Person> Read();
        Person Read(int id);
        bool Update(Person person);
        bool Delete(Person person);
    }
}
