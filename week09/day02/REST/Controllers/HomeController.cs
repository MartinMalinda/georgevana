using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

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
            if (string.IsNullOrEmpty(name) && title == null)
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

        [HttpPost("/dountil/{action}")]
        public IActionResult DoUntil([FromRoute] string action, [FromBody]JObject until)
        {
            if (action == "sum")
            {
                int result = 0;
                for (int j = 1; j <= until.Value<int>("until"); j++)
                {
                    result += 1;
                }
                return Json(new { result, status = 200 });
            }

            if (action == "factor")
            {
                int result = 1;
                for (int i = 1; i <= until.Value<int>("until"); i++)
                {
                    result *= i;
                }
                return Json(new { result, status = 200 });
            }
            return Json(new { error = "Please provide a number!" });
        }
    }
}