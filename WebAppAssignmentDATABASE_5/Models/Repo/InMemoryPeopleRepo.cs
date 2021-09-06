using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAssignmentDATABASE_5.Models
{
    public class InMemoryPeopleRepo : IPeopleRepo
    {
        private static List<Person> _personList = new List<Person>();
        private static int _idCounter = 0;




        public Person Create(string PersonName, string PersonPhoneNumber, string PersonCity)
        {
            Person newPerson = new Person(_idCounter, PersonName, PersonPhoneNumber, PersonCity);
            _idCounter++;
            _personList.Add(newPerson);
            return newPerson;
        }

        public bool Delete(Person person)
        {
            bool delete = _personList.Remove(person);
            
            return delete;
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
            foreach(Person item in _personList)
            {
                if(item.PersonId == person.PersonId)
                {
                    item.PersonName = person.PersonName;
                    item.PersonPhoneNumber = person.PersonPhoneNumber;
                    //item.PersonCity = person.PersonCity;
                }
            }
            return person;
        }
        public void CreateBasePersons()
          {
            InMemoryPeopleRepo pDataBase = new InMemoryPeopleRepo();
            pDataBase.Create("Ramya Talagavadi Kalegowda", "08236 75578", "Bengalore");
            pDataBase.Create("Rekha Gowda", "0¨989 897657 ", "Bengalore");
            pDataBase.Create("Sowmya Sri", "0888 469879", "Malmö");
            pDataBase.Create("Naga chithanya Sri", "0888 469879", "Malmö");
            pDataBase.Create("Saranya", "0888 469879", "Malmö");
            pDataBase.Create("Vijaya", "0888 469879", "Malmö");

        }
    }
}
