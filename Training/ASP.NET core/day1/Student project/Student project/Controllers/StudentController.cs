using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_project.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
 
            return View();
        }
        public IActionResult FirstName()
        {
            ViewBag.FirstName = "Manoj";
            return View();
        }
    }
}
