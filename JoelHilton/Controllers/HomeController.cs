using JoelHilton.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHilton.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieFormContext blahContext { get; set; }

        //Controller
        public HomeController(ILogger<HomeController> logger, MovieFormContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
       //Get and Post Methods for the Movie form, which takes them to the confirmation
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }
        [HttpPost]
       
        public IActionResult MovieForm(MovieResponse mr)
        {
                
            blahContext.Add(mr);
            blahContext.SaveChanges();
            return View("Confirmation", mr);
                
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
