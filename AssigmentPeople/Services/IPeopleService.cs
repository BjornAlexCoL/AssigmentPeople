using System.Collections.Generic;
using AssignmentPeople.Models;
using AssignmentPeople.Views.People;

namespace AssignmentPeople.Services
{
    interface IPeopleService
    {
        Person Add(CreatePersonViewModel person);
        List<Person> All();
        List<Person> Search(string search);
        Person FindById(int id);
        bool Edit(int id, CreatePersonViewModel person);
        bool Remove(int id);
    }
}
