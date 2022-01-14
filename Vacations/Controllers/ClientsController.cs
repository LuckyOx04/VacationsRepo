using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vacations.Models;
using Vacations.Services;

namespace Vacations.Controllers
{
    public class ClientsController : Controller
    {
        DataServices services = new DataServices();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ClientAdded(ClientModel client)
        {
            if (services.AddClient(client))
            {
                return View("Index");
            }
            else
            {
                return View("Index");
            }
        }
    }
}
