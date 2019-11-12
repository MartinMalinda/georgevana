using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace REST.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/doubling")]
        public IActionResult Double(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input, result = input * 2 });
            }
        }

        [HttpGet("/greeter")]
        public IActionResult Greet(string name, string title)
        {
            if (name == null && title == null)
            {
                return Json(new { error = "Please provide a name and a title!", status = 400 });
            }
            else if (name == null)
            {
                return Json(new { error = "Please provide a name!", status = 400 });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!", status = 400});
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }
    }
}