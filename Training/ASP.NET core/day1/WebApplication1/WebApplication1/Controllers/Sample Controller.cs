using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Sample_Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetFirstName()
        {
            return View();
        }
        public IActionResult GetLastName()
        {
            return View();
        }

    }
}
