using Microsoft.AspNetCore.Mvc;

namespace AssignmentPeople.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
