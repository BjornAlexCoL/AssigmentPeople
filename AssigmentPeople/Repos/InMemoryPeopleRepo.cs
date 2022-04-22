using System;
using System.Collections.Generic;
using AssignmentPeople.Models;

namespace AssignmentPeople.Repos
{
    public class InMemoryPeopleRepo : IPeopleRepo
    {
        private static List<Person> persons = new List<Person>();
        private static int idCounter;

        public InMemoryPeopleRepo()
        {
            if (persons.Count == 0)
            {
                persons.Add(new Person() { Id = ++idCounter, Name = "Björn", PhoneNumber = "", CityName = "Karlskrona" });
                persons.Add(new Person() { Id = ++idCounter, Name = "Kalle", PhoneNumber = "", CityName = "Stockholm" });
                persons.Add(new Person() { Id = ++idCounter, Name = "Evert", PhoneNumber = "", CityName = "Karlskrona" });
                persons.Add(new Person() { Id = ++idCounter, Name = "Gunilla", PhoneNumber = "", CityName = "Karlskrona" });
                persons.Add(new Person() { Id = ++idCounter, Name = "Nisse", PhoneNumber = "", CityName = "Växjö" });
                persons.Add(new Person() { Id = ++idCounter, Name = "Robert", PhoneNumber = "", CityName = "Jönköping" });
                persons.Add(new Person() { Id = ++idCounter, Name = "Arne", PhoneNumber = "", CityName = "Rödeby" });
                persons.Add(new Person() { Id = ++idCounter, Name = "Barbie", PhoneNumber = "", CityName = "Malibu" });
            }
        }
        public Person Create(Person person)
        {
            Person newPerson = new Person() { Id = ++idCounter, Name = person.Name, PhoneNumber = person.PhoneNumber, CityName = person.CityName };
            persons.Add(newPerson);
            return newPerson;
        }

        public bool Delete(Person person)
        {
            return persons.Remove(person);
        }

        public List<Person> Read()
        {
            return persons;
        }

        public Person Read(int id)
        {
            return persons.Find(x => x.Id == id);
        }

        public bool Update(Person person)
        {
            bool success = persons.Remove(Read(person.Id));
            if (success) persons.Add(person);
            return success;
        }
    }
}
