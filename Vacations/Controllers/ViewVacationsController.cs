using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vacations.Controllers
{
    public class ViewVacationsController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
