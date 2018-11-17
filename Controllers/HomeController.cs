using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Trabajo.Models;

namespace Trabajo.Controllers
{
    public class HomeController : SecretController
    {

        private readonly ReadyToEatContext _context;

        public HomeController(ReadyToEatContext context)
        {
            this._context = context;
        }
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
            ViewBag.Registro = new SelectList(_context.Restaurante, "Id", "nombreTienda");
            return View();
        }
        [HttpPost]
        public IActionResult Sugerencias(Sugerencia com)
        {
            if(ModelState.IsValid){
                
                _context.Add(com);
                _context.SaveChanges();

                return RedirectToAction("Nosotros","Home"); 
            }
            return View();
        }

    }
}