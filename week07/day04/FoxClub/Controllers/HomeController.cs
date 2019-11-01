﻿using System;
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
        public IActionResult Index()
        {
            return View(foxService);
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View(foxService);
        }

        [HttpPost("login")]
        public IActionResult Login(string name)
        {
            foxService.foxes.Add(new Fox(name));
            return RedirectToAction("index", "home", new { name });
        }
    }
}