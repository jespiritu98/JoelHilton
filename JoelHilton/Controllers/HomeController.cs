using JoelHilton.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace JoelHilton.Controllers
{
    public class HomeController : Controller
    {
     
        private MovieFormContext daContext { get; set; }

        //Controller
        public HomeController(MovieFormContext someName)
        {
           
            daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
       //Get and Post Methods for the Movie form, which takes them to the confirmation
        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = daContext.Categories.ToList();
            return View();
        }
        [HttpPost]
       
        public IActionResult MovieForm(MovieResponse mr)
        {
                
            daContext.Add(mr);
            daContext.SaveChanges();
            return View("Confirmation", mr);
                
        }
        public IActionResult MovieList()
        {
            var movie = daContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movie);
        }
        public IActionResult MyPodcasts()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
