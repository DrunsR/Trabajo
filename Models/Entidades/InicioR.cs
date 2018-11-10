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
        [EmailAddress]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }
        
        public Restaurante restaurante{ get; set; }

        public int restauranteId{ get; set; }

    }
}