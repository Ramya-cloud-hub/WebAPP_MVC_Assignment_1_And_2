using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models
{
    public class DatabasePeopleRepo : IPeopleRepo
    {
        private static List<Person> _personList = new List<Person>();
        private static int _idCounter;
     

        //Extra Code Added Last
        public Person Create(string PersonName, string PersonPhoneNumber, string PersonCity)
        {
            Person newPerson = new Person(_idCounter, PersonName, PersonPhoneNumber, PersonCity);
            _personList.Add(newPerson);

            _idCounter++;

            return newPerson;
        }

        public bool Delete(Person person)
        {
            _personList.Remove(person);
            return true;
        }

        public List<Person> Read()
        {
            return _personList;
        }

        public Person Read(int id)
        {
            Person findPersonById = _personList.Find(idNr => idNr.PersonId == id);

            return findPersonById;
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
