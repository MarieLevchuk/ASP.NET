using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult CreateCookie()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult CreateCookie(string txtUserName)
        {
            Response.Cookies.Append("name", txtUserName);
            return View("Index");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
