using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aeh.uber.Models;
using aeh.uber.Interfaces;

namespace aeh.uber.Controllers
{
    public class HController : Controller
    {
        public HController()
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return Ok();
        }

        public IActionResult Impressum()
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
