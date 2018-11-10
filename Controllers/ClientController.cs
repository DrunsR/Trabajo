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
        public IActionResult InicioClient(InicioR c)
        {
            if(!ModelState.IsValid){
                
                return RedirectToAction("Nosotros","Home");

            }
            return View(c);
        }
        public IActionResult RegistroClient()
        {
            return View();
        }
        

        
        [HttpPost]
        public IActionResult RegistroClient(Restaurante c)
        {
            if(!ModelState.IsValid){
                
                return RedirectToAction("Nosotros","Home");

            }
            return View(c);
        }



    }
}
