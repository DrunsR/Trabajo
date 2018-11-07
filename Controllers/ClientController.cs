using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trabajo.Models;

namespace Trabajo.Controllers
{
    public class ClientController : Controller
    {

        public IActionResult InicioClient()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult InicioClient(Cliente c)
        {
            if(!ModelState.IsValid){
                
                return RedirectToAction("Nosotros","Home");

            }
            return View(c);
        }
        public IActionResult InicioRestaurant()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult InicioRestaurant(Restaurante r)
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult RegistroClient(registrocliente c)
        {
            if(!ModelState.IsValid){
                
                return RedirectToAction("Nosotros","Home");

            }
            return View(c);
        }
        
        [HttpPost]
        public IActionResult RegistroRestaurant(Restaurante r)
        {
            return View();
        }


    }
}
