using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseIntegration.Models;
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
            using (var context = applicationContext)
            {
                context.Todos.Remove(context.Todos.Find(id));
                context.SaveChanges();
                return RedirectToAction("List");
            }
        }

        [HttpGet("EditToDo")]
        public IActionResult EditToDo(long id)
        {
            using (var context = applicationContext)
            {
                ViewData["id"] = id;
                ToDo currentToDo = context.Todos.Find(id);
                ViewData["currentToDo"] = currentToDo.Title;
                return View();
            }
        }

        [HttpPost("EditToDo")]
        public IActionResult EditToDo(long id, string title, bool isDone, bool isUrgent)
        {
            using (var context = applicationContext)
            {
                ToDo updateToDo = context.Todos.Find(id);
                updateToDo.Title = title;
                updateToDo.IsDone = isDone;
                updateToDo.IsUrgent = isUrgent;
                context.Todos.Update(updateToDo);
                context.SaveChanges();
            }
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