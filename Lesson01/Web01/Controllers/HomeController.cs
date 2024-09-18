using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web01.Models;

namespace Web01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        //URL: localhost:PORT/Home/Greenwich
        public IActionResult Greenwich()
        {
            //Location: Views/Home/Greenwich.cshtml
            return View();
        }

        //Default URL: localhost:PORT/Home/FPT
        //Custom URL: localhost:PORT/VinGroup
        [Route("/VinGroup")]
        public IActionResult FPT()
        {
            //Default Location: Views/Home/FPT.cshtml
            //Custome Location: Views/Home/Viettel.cshtml
            return View("~/Views/Home/Viettel.cshtml");
        }
    }
}
