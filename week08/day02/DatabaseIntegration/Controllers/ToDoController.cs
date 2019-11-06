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
                return View(todos.Where(t => !t.IsDone).ToList());
            }
            return View(todos);
        }

        [HttpGet("AddToDo")]
        public IActionResult AddToDo()
        {
            return View();
        }

        [HttpPost("AddToDo")]
        public IActionResult AddToDo(string title, bool isUrgent)
        {
            using (var context = applicationContext)
            {
                var todo = new ToDo();
                todo.Title = title;
                todo.IsUrgent = isUrgent;
                context.Todos.Add(todo);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }

        [HttpGet("RemoveToDo")]
        public IActionResult RemoveToDo(long id)
        {
            ToDo removeToDo = applicationContext.Todos.FirstOrDefault(t => t.Id == id);
            applicationContext.Todos.Remove(removeToDo);
            applicationContext.SaveChanges();
            return RedirectToAction("List");
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