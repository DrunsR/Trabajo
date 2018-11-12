using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Trabajo.Models;
using Trabajo.Models.Entidades;

namespace Trabajo.Models
{
    public class Restaurante
    {
        public int Id { get; set; }

        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellido { get; set; }

        public InicioR ini { get; set; }
        

        [Required]
        [EmailAddress]
        public string email{ get; set; }
        [Required]
        public int telefono { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string RUC { get; set; }

        [Required]
        public string confirm_password { get; set; }
        [Required]
        public string nombreTienda { get; set; }
        
        public string foto { get; set; }
        public string descripcion { get; set; }

        public List<Platillo> Menu { get; set; }


        
    }
}