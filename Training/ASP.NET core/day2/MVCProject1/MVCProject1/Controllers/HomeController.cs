using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCProject1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject1.Controllers
{
    public class HomeController : Controller
    {
        ILog _log;

        public HomeController(ILog Log)  //MyConsoleLogger
        {
            _log = Log;
        }

        public IActionResult Index()
        {
            _log.info("Executing /home/index");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
