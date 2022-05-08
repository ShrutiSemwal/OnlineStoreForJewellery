using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineStoreForJewellery.Models;
using System;
using System.Net;
using System.Net.Mail;
//using MailKit.Net.Smtp;
//using MimeKit;
using System.Collections.Generic;
using System.IO;
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


        public IActionResult Cart()
        {
            return View("Views/Home/Account/Cart.cshtml");
        }

        public IActionResult Wishlist()
        {
            return View("Views/Home/Account/Wishlist.cshtml");
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

        public IActionResult New()
        {
            return View("Views/Home/Collections/New.cshtml");
        }

        public IActionResult Under100()
        {
            return View("Views/Home/Collections/Under100.cshtml");
        }

        public IActionResult CasualLook()
        {
            return View("Views/Home/Collections/CasualLook.cshtml");
        }

        public IActionResult Oxidised()
        {
            return View("Views/Home/Collections/Oxidised.cshtml");
        }

        public IActionResult Vintage()
        {
            return View("Views/Home/Collections/Vintage.cshtml");
        }

        public IActionResult Trinkets()
        {
            return View("Views/Home/Collections/Trinkets.cshtml");
        }

        public IActionResult FunctionNight()
        {
            return View("Views/Home/Collections/FunctionNight.cshtml");
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Contact()
        {
           
            return View();
        }

        
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if (!ModelState.IsValid) return View();

            try
            {
                MailMessage mail = new MailMessage();
                // you need to enter your mail address
                mail.From = new MailAddress("shrutisemwal956@gmail.com");

                //To Email Address - your need to enter your to email address
                mail.To.Add("semwalshruti450@gmail.com");



                //you can specify also CC and BCC - i will skip this
                //mail.CC.Add("");
                //mail.Bcc.Add("");

                mail.IsBodyHtml = true;

                string content = "Name : " + contact.Name;
                content += "<br/> Message : " + contact.Message;

                mail.Body = content;


                //create SMTP instant

                //you need to pass mail server address and you can also specify the port number if you required
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");


                //Create nerwork credential and you need to give from email address and password
                NetworkCredential networkCredential = new NetworkCredential("shrutisemwal956@gmail.com", "1609_shrutisemwal@");
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;
                smtpClient.Port = 587; // this is default port number - you can also change this
                smtpClient.EnableSsl = false; // if ssl required you need to enable it
                smtpClient.Send(mail);

                ViewBag.Message = "Mail Sent Successfully";

                // now i need to create the form 
                ModelState.Clear();

            }
            catch (Exception ex)
            {
                //If any error occured it will show
                ViewBag.Message = ex.Message.ToString();
            }
            return View();
        }
        
    }
}



