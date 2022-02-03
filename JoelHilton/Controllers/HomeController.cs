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
            if (ModelState.IsValid)
            {
                daContext.Add(mr);
                daContext.SaveChanges();
                return View("Confirmation", mr);
            }
            else // If Invalid
            {
                ViewBag.Categories = daContext.Categories.ToList();
                return View(mr);
            }
          
 
                
        }
        public IActionResult MovieList()
        {
            var movies = daContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies);
        }
        [HttpGet]
        public IActionResult Edit(int applicationid)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            var application = daContext.Responses.Single(x => x.ApplicationId == applicationid);

            return View("MovieForm", application);
        }
        [HttpPost]
        public IActionResult Edit (MovieResponse update)
        {
            daContext.Update(update);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application = daContext.Responses.Single(x => x.ApplicationId == applicationid);

            return View(application);
        }
        [HttpPost]
        public IActionResult Delete(MovieResponse mr)
        {
            daContext.Responses.Remove(mr);
            daContext.SaveChanges();
            return RedirectToAction("MovieList");
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
