using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trabajo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Trabajo.Controllers
{
    public class ClientController : SecretController
    {

        private readonly ReadyToEatContext _context;
        public ClientController(ReadyToEatContext context)
        {
            this._context = context;
        }

        public IActionResult InicioSesion()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult InicioSesion(InicioR c)
        {
            if(ModelState.IsValid){
                var ini = _context.InicioR.FirstOrDefault(x => x.Usuario == c.Usuario && x.Contraseña == c.Contraseña.ToString());
                if( ini != null){

                    HttpContext.Session.SetString("NombreUsuario", c.Usuario);
                    
                    return RedirectToAction("Principal","Restaurantes");
                }
                ModelState.AddModelError("Incorrecto", "Contraseña o usuario Erroneo");
                return View(c);
            }
            return View(c);
        }
        public IActionResult RegistroRestaurante()
        {
            ViewBag.Usuario= HttpContext.Session.GetString("NombreUsuario");
            return View();  
        }
        

        
        [HttpPost]
        public IActionResult RegistroRestaurante(Restaurante r)
        {
            if(ModelState.IsValid){

                _context.Add(r);
                _context.SaveChanges();
                HttpContext.Session.SetString("NombreUsuario",r.ini.Usuario);
                    
                
                return RedirectToAction("Principal","Restaurantes");

            }
            return View(r);
        }




        public IActionResult Salir()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Nosotros","Home");
        }       

    }
}
