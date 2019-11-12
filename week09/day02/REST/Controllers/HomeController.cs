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
                return BadRequest(new { error = "Please provide a name and a title!"});
            }
            else if (name == null)
            {
                return BadRequest(new { error = "Please provide a name!"});
            }
            else if (title == null)
            {
                return BadRequest(new { error = "Please provide a title!"});
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [HttpGet("/appenda/{appendable}")]
        public IActionResult AppendA([FromRoute] string appendable)
        {
            return Json(new { appended = $"{appendable}a" });
        }
    }
}