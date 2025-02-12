using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Daynes.Models;

namespace Mission06_Daynes.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;
        public HomeController(MovieContext temp)  // constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(AddMovie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Index");
        }
    }
}
