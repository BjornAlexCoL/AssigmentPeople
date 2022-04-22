using System.Collections.Generic;
using AssignmentPeople.Models;
using AssignmentPeople.Repos;

namespace AssignmentPeople.Services
{
    public class PeopleService : IPeopleService
    {
        InMemoryPeopleRepo people = new InMemoryPeopleRepo();

        public Person Add(CreatePersonViewModel person)
        {
            return people.Create(new Person { Name = person.Name, PhoneNumber = person.PhoneNumber, CityName = person.CityName });
        }

        public List<Person> All()
        {
            return people.Read();
        }

        public bool Edit(int id, CreatePersonViewModel person)
        {
            bool success = Remove(id);           
            if (success) Add(person);
            return success;
        }

        public Person FindById(int id)
        {
            return people.Read(id);
        }

        public bool Remove(int id)
        {
            return people.Delete(FindById(id));

        }

        public List<Person> Search(string search)
        {
           // persons.
            throw new System.NotImplementedException();
        }
    }
}
