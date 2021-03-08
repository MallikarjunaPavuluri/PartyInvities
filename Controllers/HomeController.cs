using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvities.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvities.Controllers
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
        [HttpGet]
        public ViewResult RsvpForm()
        {
            
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponce guestResponce)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponce);
                return View("Thanks", guestResponce);
            }
            else
            {
                return View();
            }
            
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responces.Where(r =>r.WillAttend == true));
        }

        public IActionResult Privacy()
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
