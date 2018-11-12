using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trabajo.Models
{
    public class InicioR
    {
        public int Id { get; set; } 

        [Required]
        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }
        public Restaurante reg {get; set;}
        public int regId { get; set; }
        

       

    }
}