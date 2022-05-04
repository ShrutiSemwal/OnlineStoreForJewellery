using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineStoreForJewellery.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStoreForJewellery.Controllers
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
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View("Views/Home/Account/Cart.cshtml");
        }

        public IActionResult Checkout()
        {
            return View("Views/Home/Account/Checkout.cshtml");
        }

        public IActionResult Payment()
        {
            return View("Views/Home/Account/Payment.cshtml");
        }

        public IActionResult Login()
        {
            return View("Views/Home/Auth/Login.cshtml");
        }

        public IActionResult Signup()
        {
            return View("Views/Home/Auth/Signup.cshtml");
        }

        public IActionResult Rings()
        {
            return View("Views/Home/Categories/Rings.cshtml");
        }

        public IActionResult Bracelets()
        {
            return View("Views/Home/Categories/Bracelets.cshtml");
        }

        public IActionResult Earrings()
        {
            return View("Views/Home/Categories/Earrings.cshtml");
        }

        public IActionResult Neckpieces()
        {
            return View("Views/Home/Categories/Neckpieces.cshtml");
        }

        public IActionResult All()
        {
            return View("Views/Home/Collections/All.cshtml");
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
