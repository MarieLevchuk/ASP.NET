using DAL;
using Login.Models;
using Login.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PalyndromLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        IIdentityValidator _validator;
        public HomeController(IIdentityValidator validator)
        {
            _validator = validator;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult SignUp(string login, string password)
        {

            if (_validator.UserIsRegistered(UserData.GetUserByRegistrationData(login, password)))
            {
                Response.Cookies.Append("login", login);
                return View("Palyndrom");
            }
            else
                return View("Index");
        }
        [HttpGet]
        public IActionResult IsPalyndrome()
        {
            return View("Palyndrome");
        }

        [HttpPost]
        public IActionResult IsPalyndrome(string word)
        {
            ViewBag.Result = Palyndrom.IsPalyndrom(word);
            return View("Palyndrom");
        }
    }
}
