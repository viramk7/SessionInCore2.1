using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SessionDemo.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            var userName = SessionHelper.LoggedInUser;
            if (userName == null)
            {
                return RedirectToAction("Index","Home");
            }

            return View();
        }
    }
}