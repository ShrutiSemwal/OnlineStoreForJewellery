using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using OnlineStoreForJewellery.Helpers;
using OnlineStoreForJewellery.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStoreForJewellery.Controllers
{

    [Route("contact")]
    public class ContactController : Controller
    {
        private IConfiguration configuration;
        private IWebHostEnvironment webHostEnvironment;

        public ContactController(IConfiguration _configuration, IWebHostEnvironment _webHostEnvironment)
        {
         
            configuration = _configuration;
            webHostEnvironment = _webHostEnvironment;
        }

      

        public IActionResult Index()
        {
            return View("Index", new Contact());
        }

        [HttpPost]
        [Route("send")]

        public IActionResult Send(Contact contact)
        {
            var body = "Name: " + contact.Name + "<br>Email: " + contact.Email + "<br>";
            var mailHelper = new MailHelper(configuration);
            List<string> fileNames = null;

            if (mailHelper.Send(contact.Email, configuration["Gmail:Username"], contact.Message, body, fileNames))
            {
                ViewBag.msg = "Sent Mail Successfully";
            }
            else
            {
                ViewBag.msg = "Failed";
            }
            return View("Contact", new Contact());
        }
    }
}
