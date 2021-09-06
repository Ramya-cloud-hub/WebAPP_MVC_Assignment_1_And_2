using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Models.ViewModel;

namespace WebAppAssignmentDATABASE_5.Models
{
    public class PeopleService : IPeopleService
    {    
   

        public Person Add(CreatePersonViewModel person)
        {
            InMemoryPeopleRepo createAndStorePerson = new InMemoryPeopleRepo();
            Person madePerson = createAndStorePerson.Create(person.PersonName, person.PersonPhoneNumber, person.PersonCity);

            return madePerson;
        }

      

        public PeopleViewModel FindBy(PeopleViewModel search)
        {
            InMemoryPeopleRepo loadListForSearch = new InMemoryPeopleRepo();
            search.PeopleListView.Clear();

            foreach (Person item in loadListForSearch.Read())
            {
                if (item.PersonName.Contains(search.FilterString, StringComparison.OrdinalIgnoreCase) || item.PersonCity.Contains(search.FilterString, StringComparison.OrdinalIgnoreCase))
                {
                    search.PeopleListView.Add(item);
                }
            }
            if (search.PeopleListView.Count == 0)
            {
                search.SearchResultEmpty = $"No Person or City could be found, matching \"{search.FilterString}\" ";
            }
            else
            {
                search.SearchResultEmpty = "";
            }
            return search;
        }

        public Person FindBy(int id)
        {
            throw new NotImplementedException();
        }



        public PeopleViewModel All()
        {
            InMemoryPeopleRepo inMemoryPeopleRepo = new InMemoryPeopleRepo();

            PeopleViewModel peopleViewModel = new PeopleViewModel() { PeopleListView = inMemoryPeopleRepo.Read() };

            return peopleViewModel;
        }


        public bool Remove(int id)
        {

            InMemoryPeopleRepo deletePerson = new InMemoryPeopleRepo();
            Person personToDelete = deletePerson.Read(id);
            deletePerson.Delete(personToDelete);

            return true;

        }

        public Person Edit(int id, Person person)
        {
            throw new NotImplementedException();
        }
    }
}
