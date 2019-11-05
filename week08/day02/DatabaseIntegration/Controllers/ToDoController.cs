using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseIntegration.Controllers
{
    [Route("todo")]
    public class ToDoController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public ToDoController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        [Route("")]
        [HttpGet("list")]
        public IActionResult List(bool isActive)
        {
            // Create a SQL query in the background
            var todos = applicationContext.Todos.ToList();
            if (isActive)
            {
                return View(todos.Where(t => t.IsDone == true).ToList());
            }
            return View(todos);
        }

        /*public List<ToDo> Todos { get; set; } = new List<ToDo>
        {
            new ToDo { Title = "start the day" },
            new ToDo { Title = "Finish H2 workshop 1" },
            new ToDo { Title = "Finish JPA workshop 2" },
            new ToDo { Title = "Create a CRUD project" }
        };

        [HttpGet("")]
        [HttpGet("list")]
        public IActionResult List()
        {
            return View(Todos);
        }*/
    }
}