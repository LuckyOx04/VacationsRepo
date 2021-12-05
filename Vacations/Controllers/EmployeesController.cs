using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vacations.Services;

namespace Vacations.Controllers
{
    public class EmployeesController : Controller
    {
        DataServices services = new DataServices();
        public IActionResult Index()
        {
            return View("ViewEmployees", services.GetEmployees());
        }
    }
}
