////tinfo200:[2021-03-12-<Steven28>-dykstra] -The controller heads most of the operation within the project whether that 
///be communicating via http or other functions that the code in this project 
using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Controllers
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

        public IActionResult Privacy()
        {                          //string first = "Steven", string last = "N", string email = "Email@.edu"

            ////tinfo200:[2021-03-12-<Steven28>-dykstra] - Giving the data into the "var" in Privacy for it 
            ///to display on the webpage making it ccs => htlm code 
           /* ViewData["FirstName"] = "Steven";
            ViewData["LastName"] = "N.";
            ViewData["Email"] = "Email@.uw.edu"; */

            ////tinfo200:[2021-03-12-<Steven28>-dykstra] - ^ same concpet above but we ask the user for the var
            ///to display...note they have to do it through the web brower instead 
           /* ViewData["FirstName"] = first;
            ViewData["LastName"] = last;
            ViewData["Email"] = email; */

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
