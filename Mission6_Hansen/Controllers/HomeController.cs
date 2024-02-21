using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            return View(new Movie());
        }

        [HttpPost]
        public IActionResult Collection(Movie response)
        {
            if (ModelState.IsValid)
            {

            _context.Movies.Add(response);
            _context.SaveChanges();

            }

            else
            {
                ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

                return View(response);
            }

            return RedirectToAction("ViewData");
        }

        public IActionResult ViewData()
        {
            var movies = _context.Movies.Include(x => x.Category)
                .OrderBy(x => x.Title).ToList();

            return View("View", movies);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            return View("Collection", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo) 
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("ViewData", updatedInfo);
        }
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View("Delete", recordToDelete);

        }

        [HttpPost]
        public IActionResult Delete(Movie deletedInfo)
        {
            _context.Movies.Remove(deletedInfo);
            _context.SaveChanges();

            return RedirectToAction("ViewData");
        }
    }
}
