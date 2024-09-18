using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web01.Models;

namespace Web01.Controllers
{
    public class DemoController : Controller
    {
        //localhost:PORT/Demo/Index
        public IActionResult Index()
        {
            //pass data from backend (Controller) to frontend (View)
            //method 1: ViewBag
            ViewBag.Country = "Việt Nam";
            List<string> clubs = ["Manchester", "Real Madrid", "Chelsea", "Barcelona"];
            ViewBag.Clubs = clubs;

            //method 2: ViewData
            ViewData["Year"] = 2024;

            //Views/Demo/Index.cshtml
            return View();
        }

        //localhost:PORT/Demo/Test
        public IActionResult Test()
        {
            return View("~/Views/Demo/Index.cshtml");
        }
    }
}
