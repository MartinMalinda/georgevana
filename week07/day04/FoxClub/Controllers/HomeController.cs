using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Models;
using FoxClub.Service;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private readonly FoxService foxService;

        public HomeController(FoxService foxService)
        {
            this.foxService = foxService;
        }

        [HttpGet("home")]
        public IActionResult Index(string name)
        {
            return View(foxService.FindFoxByName(name));
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(string name)
        {
            foxService.foxes.Add(new Fox(name));
            return RedirectToAction("Index", "Home", new { name });
        }

        [Route("nutritionstore")]

        public IActionResult NutritionStore(string name)
        {
            ViewBag.foodTypes = foxService.foodTypes;
            ViewBag.drinkTypes = foxService.drinkTypes;

            return View(foxService.FindFoxByName(name));
        }

        [Route("nutritionstore")]
        [HttpPost]
        public IActionResult NutritionStore(string name, string food, string drink)
        {
            foxService.FindFoxByName(name).Drink = drink;
            foxService.FindFoxByName(name).Food = food;
            return RedirectToAction("Index", "Home", new { name });
        }

        [Route("trickcenter")]

        public IActionResult TrickCenter(string name)
        {
            ViewBag.tricks = foxService.tricks;
            return View(foxService.FindFoxByName(name));
        }

        [Route("trickcenter")]
        [HttpPost]
        public IActionResult TrickCenter(string name, string trick)
        {
            foxService.FindFoxByName(name).Tricks.Add(trick);
            return RedirectToAction("Index", "Home", new { name });
        }
    }
}