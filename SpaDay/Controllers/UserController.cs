using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("/user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if(verify != null && verify != "" && newUser.Password == verify)
            {
                ViewBag.userName = newUser.Username;
                return View("index");
            }
            else
            {
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                ViewBag.error = "Password fields did not match.";
                return View("add");
            }
        }
    }
}
