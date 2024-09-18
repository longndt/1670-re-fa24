using Microsoft.AspNetCore.Mvc;
using System.Collections;
using Web01.Models;

namespace Web01.Controllers
{
    public class LaptopController : Controller
    {
        public IActionResult Index()
        {
            var macbook = new Laptop
            {
                Brand = "Apple",
                Model = "Macbook Pro",
                Price = 1234.56,
                Quantity = 15
            };
            var xps = new Laptop
            {
                Brand = "Dell",
                Model = "XPS 13",
                Price = 999.99,
                Quantity = 25
            };
            List<Laptop> laptops = [
                macbook, xps,
                new Laptop
            {
                Brand = "LG",
                Model = "Gram 17",
                Price = 1111.11,
                Quantity = 20
            }
            ];
            //pass data by "model"
            return View(laptops);
        }
    }
}
