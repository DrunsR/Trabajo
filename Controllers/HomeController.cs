using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trabajo.Models;

namespace Trabajo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Nosotros()
        {
            return View();
        }

        public IActionResult About()
        {
           

            return View();
        }

        public IActionResult Sugerencias()
        {
            

            return View();
        }

    }
}