using Microsoft.AspNetCore.Mvc;
using Mission6_Hansen.Models;
using SQLitePCL;
using System.Diagnostics;

namespace Mission6_Hansen.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;

        public HomeController(MovieContext temp)
        {
            _context = temp;
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
            _context.MovieCollection.Add(response);
            _context.SaveChanges();

            return View("Index", response);
        }

        public IActionResult ViewData()
        {
            var movies = _context.MovieCollection
                .OrderBy(x => x.Title).ToList();

            return View("View", movies);
        }
    }
}
