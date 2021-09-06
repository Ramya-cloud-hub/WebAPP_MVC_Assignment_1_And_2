using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Controllers;
using WebAppAssignmentDATABASE_5.Models.ViewModel;

namespace WebAppAssignmentDATABASE_5.Models
{
    public interface IPeopleService
    {
         Person Add(CreatePersonViewModel person);

         PeopleViewModel All();

         PeopleViewModel FindBy(PeopleViewModel search);

        Person FindBy(int id);

         Person Edit(int id, Person person);

        bool Remove(int id);
       
    }
}
