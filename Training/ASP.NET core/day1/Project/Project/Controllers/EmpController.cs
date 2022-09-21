using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Name()
        {
            ViewBag.FristName = "Manoj";
            ViewBag.LastName = "Birajdar";
            return View();
        }
    }
}

