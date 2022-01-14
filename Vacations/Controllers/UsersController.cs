using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vacations.Models;
using Vacations.Services;

namespace Vacations.Controllers
{
    public class UsersController : Controller
    {
        public static bool IsLoggedIn { get; set; } = false;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Validate(UserModel user)
        {
            DataServices service = new DataServices();

            if (service.IsValid(user))
            {
                return View("SuccessfulLogin", user);
            }
            else
            {
                return View("FailedLogin", user);
            }
        }
    }
}
