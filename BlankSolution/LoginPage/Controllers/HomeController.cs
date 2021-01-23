using LoginPage.Models;
using LoginPage.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LoginPage.Controllers
{
    public class HomeController : Controller
    {
        UsersDAL _usersDAL = new UsersDAL();
        IIdentityValidator _validator;
        public HomeController (IIdentityValidator validator)
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
            if (_validator.UserIsRegistered(_usersDAL.GetUserByRegistrationData(login, password)))
            {
                Response.Cookies.Append("login", login);
                Response.Cookies.Append("password", password);
                return View("PrivatePage");
            }
            else
                return View("Index");
        }

        [HttpGet]
        public IActionResult PrivatePage()
        {
            ViewBag.Max = ArrayDB.array.Max();
            ViewBag.Min = ArrayDB.array.Min();
            return View("Index");
        }
    }
}
