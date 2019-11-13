using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using REST.Models;

namespace REST.Controllers
{
    [Route("/")]
    [ApiController]
    public class HomeController : Controller
    {
        private ApplicationContext applicationContext;
        public HomeController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/doubling")]
        public ActionResult Double(int? input)
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
        public ActionResult Greet(string name, string title)
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
        public ActionResult AppendA([FromRoute] string appendable)
        {
            return Json(new { appended = $"{appendable}a" });
        }

        [HttpPost("/dountil/{operation}")]
        public ActionResult DoUntil([FromRoute] string operation, [FromBody]MathRequest request)
        {
            if (request == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            else
            {
                if (operation == "sum")
                {
                    int result = 0;
                    for (int j = 0; j <= request.Limit; j++)
                    {
                        result += j;
                    }
                    return Json(new { result });
                }
                if (operation == "factor")
                {
                    int result = 1;
                    for (int i = 1; i <= request.Limit; i++)
                    {
                        result *= i;
                    }
                    return Json(new { result });
                }
            }
            return Ok();
        }

        [HttpPost("/arrays")]
        public ActionResult DoMath([FromBody]MathRequest request)
        {
            if (request == null)
            {
                return Json(new { error = "Please provide what to do with the numbers!" });
            }
            else
            {
                object result = null;
                switch (request.Operation)
                {
                    case "sum":
                        result = request.Numbers.Sum();
                        break;
                    case "multiply":
                        result = request.Numbers.Aggregate((a, b)=> a * b);
                        break;
                    case "double":
                        result = request.Numbers.Select(n => n * 2).ToArray();
                        break;
                }
                return Ok(new { result });
            }
        }
    }
}