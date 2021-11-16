using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vacations.Models;

namespace Vacations.Controllers
{
    public class ViewVacationsController : Controller
    {
        public IActionResult List(VacationsModel vacations)
        {
            return View("List", vacations);
        }
    }
}
