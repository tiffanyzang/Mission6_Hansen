using Microsoft.AspNetCore.Mvc;
using Mission6_Hansen.Models;
using System.Diagnostics;

namespace Mission6_Hansen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Collection()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Collection(Movie response)
        {
            return View();
        }
    }
}
