using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day1ASP.NETcore.Controllers
{
    public class Sample : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetFirstName()
        {
            ViewBag.Firstname = "Manoj";
            return View();

        }
        public IActionResult GetLastName()
        {
            ViewBag.LastName = "Birajdar";
            ViewBag.Location = "Pune";
            return View();

        }
    }
}
