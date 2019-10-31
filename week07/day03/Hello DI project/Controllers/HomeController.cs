using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello_DI_project.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hello_DI_project.Controllers
{
    [Route("useful")]
    public class HomeController : Controller
    {
        private UtilityService utilityService;

        public HomeController(UtilityService utilityService)
        {
            this.utilityService = utilityService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("colored")]
        public IActionResult Colored()
        {
            return View(utilityService);
        }

        [HttpGet("email")]
        public IActionResult Email()
        {
            return View();
        }
    }
}