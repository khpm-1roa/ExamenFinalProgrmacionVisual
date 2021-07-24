using KevinPillajoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KevinPillajoWeb.Controllers
{
    public class RecursosController : Controller
    {
        private readonly ILogger<RecursosController> _logger;

        public class RecursosController : Controller

    {

        readonly string[] pinturas  = new string[]

            {

                "El Grito II (La Edad de la Ira)", 

                "El Grito de Munch", 

                "La Gioconda" 

            };

        [HttpPost]

        public IActionResult Index()

        {

            return View(pinturas);

        }

    }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
