using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace Trabajo.Models
{
    public class Platillo
    {
        
        public int Id { get; set; }
        [Required (ErrorMessage = "Falta ingresar el nombre del platillo")]
        public string Nombre  { get; set; }
        [Required (ErrorMessage = "Falta ingresar el precio")]
        public int Precio { get; set; }
        [Required (ErrorMessage = "Falta ingresar la foto")]
        public string Imagen { get; set; }
        public string Descripcion { get; set; }

        public Restaurante reg{get; set;}
        public int regId { get; set; }
    }
}