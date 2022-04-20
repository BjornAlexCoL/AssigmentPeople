using System;
using System.Collections.Generic;
using AssignmentPeople.Models;

namespace AssignmentPeople.Repos
{
    public class InMemoryPeopleRepo : IPeopleRepo
    {
        private static List<Person> persons;
        private static int idCounter;
        public Person Create(Person person)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> read()
        {
            throw new NotImplementedException();
        }

        public Person Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
