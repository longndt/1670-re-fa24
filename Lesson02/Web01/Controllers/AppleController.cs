using Microsoft.AspNetCore.Mvc;

namespace Web01.Controllers
{
    public class AppleController : Controller
    {
        //localhost:PORT/ControllerName/ActionName
        //localhost:PORT/Apple/Index
        //localhost:PORT/Apple
        [Route("/")]
        public IActionResult Index()
        {
            //Views/ControllerName/ActionName.cshtml
            //Views/Apple/Index.cshtml
            return View();
        }

        //localhost:PORT/Apple
        public IActionResult Iphone()
        {
            return View();
        }

        public IActionResult Ipad()
        {
            return View();
        }

        public IActionResult Macbook()
        {
            return View();
        }
    }
}
