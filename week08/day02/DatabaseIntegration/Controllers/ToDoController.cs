using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseIntegration.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseIntegration.Controllers
{
    [Route("/")]
    public class ToDoController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public ToDoController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        [Route("/")]
        [HttpGet("/list")]
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

        [HttpGet("/AddToDo")]
        public IActionResult AddToDo()
        {
            return View();
        }

        [HttpPost("/AddToDo")]
        public IActionResult AddToDo(ToDo newTodo)
        {
            using (var context = applicationContext)
            {
                context.Todos.Add(newTodo);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }

        [HttpGet("/RemoveToDo")]
        public IActionResult RemoveToDo(long id)
        {
            using (var context = applicationContext)
            {
                context.Todos.Remove(context.Todos.Find(id));
                context.SaveChanges();
                return RedirectToAction("List");
            }
        }

        [HttpGet("/{id}/edit")]
        public IActionResult EditToDo([FromRoute] long id)
        {
            using (var context = applicationContext)
            {
                ToDo currentToDo = context.Todos.Find(id);
                return View(currentToDo);
            }
        }

        [HttpPost("/{id}/edit")]
        public IActionResult SaveToDo([FromRoute] long id, string title, bool isDone, bool isUrgent)
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

        /*[HttpGet("/edit")]
        public IActionResult EditTodo(long id)
        {
            using (var context = applicationContext)
            {
                ViewData["id"] = id;
                ToDo currentTodo = context.Todos.Find(id);
                ViewData["currentTodo"] = currentTodo.Title;
                return View();
            }
        }

        [HttpPost("/edit")]
        public IActionResult SaveToDo(long id, string title, bool isDone, bool isUrgent)
        {
            using (var context = applicationContext)
            {
                ToDo updateTodo = context.Todos.Find(id);
                updateTodo.Title = title;
                updateTodo.IsDone = isDone;
                updateTodo.IsUrgent = isUrgent;
                context.Todos.Update(updateTodo);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }*/





        

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