using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAssignmentDATABASE_5.Models;
using WebAppAssignmentDATABASE_5.Models.ViewModel;

namespace WebAppAssignmentDATABASE_5.Controllers
{
    public class PeopleController : Controller
    {

 
        [HttpGet]
        public IActionResult Index()
        {
     
           PeopleService checkListView = new PeopleService();
            PeopleViewModel peopleList = new PeopleViewModel();

            InMemoryPeopleRepo makeBaseList = new InMemoryPeopleRepo();

            peopleList.PeopleListView = checkListView.All().PeopleListView;

            if (peopleList.PeopleListView.Count == 0 || peopleList.PeopleListView == null)
            {
                makeBaseList.CreateBasePersons();
            }

            return View(peopleList);
        }



        [HttpPost]
        public IActionResult Index(PeopleViewModel peopleviewModel)
        {
            PeopleService filterString = new PeopleService();

            peopleviewModel = filterString.FindBy(peopleviewModel);
            return View(peopleviewModel);
        }

        [HttpGet]
        public IActionResult CreatePerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePerson(CreatePersonViewModel personViewModel) 
        {
            var newPersonModel = new PeopleViewModel();
            PeopleService peopleService = new PeopleService();

            if (ModelState.IsValid)
            {
                 

                newPersonModel.PersonName = personViewModel.PersonName;
                newPersonModel.PersonPhoneNumber = personViewModel.PersonPhoneNumber;
                newPersonModel.PersonCity = personViewModel.PersonCity;

                newPersonModel.PeopleListView = peopleService.All().PeopleListView;


                peopleService.Add(personViewModel);

                ViewBag.Mess = "Person Added!";

                return View("Index", newPersonModel);
            }         

            return View("index", newPersonModel);
        }


        public IActionResult DeletePerson(int id)
        {
            PeopleService deleteById = new PeopleService();
            deleteById.Remove(id);

            return RedirectToAction("Index");
        }
    

    }
}
