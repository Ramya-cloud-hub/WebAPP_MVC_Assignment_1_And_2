using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Controllers;

namespace WebAppAssignmentDATABASE_5.Models
{
   public interface IPeopleRepo
    {
        public Person Create(string PersonName, string PersonPhoneNumber, string PersonCity);
        public List<Person> Read();
        public Person Read(int id);
        public Person Update(Person person);
        public bool Delete(Person person);
    }
}