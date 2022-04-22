using AssignmentPeople.Models;
using AssignmentPeople.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentPeople.Controllers
{
    public class PeopleController : Controller
    {
        IPeopleService peopleService;

        public PeopleController()
        {
            peopleService = new PeopleService();
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Message = "Search";
            return View(peopleService.All());
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            return View(peopleService.Search(search));
        }

        [HttpGet]
        public IActionResult Create()
        {
            CreatePersonViewModel createPerson = new CreatePersonViewModel();

            return View(createPerson);
        }
        [HttpPost]
        public IActionResult Create(CreatePersonViewModel createPerson)
        {
            if (ModelState.IsValid)
            {
                peopleService.Add(createPerson);
                return RedirectToAction("Index");
            }
            return View(createPerson);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(peopleService.FindById(id));
        }

        [HttpPost]
        public IActionResult Details(Person person)
        {
            if (peopleService.Remove(person.Id))
            {
            ViewBag.Message = "Person deleted from list";
            }

            return View();
        }
        
    }

}
