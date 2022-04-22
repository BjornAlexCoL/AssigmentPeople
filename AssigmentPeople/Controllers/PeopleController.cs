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
            return View(peopleService.All());
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
    }

}
