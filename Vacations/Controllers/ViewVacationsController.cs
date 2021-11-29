using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vacations.Models;
using Vacations.Services;

namespace Vacations.Controllers
{
    public class ViewVacationsController : Controller
    {
        DataServices services = new DataServices();
        public IActionResult List(VacationsModel vacations)
        {
            return View("List", services.GetVacationData());
        }
    }
}
