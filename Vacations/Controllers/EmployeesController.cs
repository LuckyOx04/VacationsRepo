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
        DatabaseAccess services = new DatabaseAccess();
        public IActionResult Index()
        {
            return View("ViewEmployees", services.GetEmployees());
        }
    }
}
