using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Trabajo.Models
{
    public class Restaurante
    {

        [BindProperty]
		public InicioR Inicio { get; set; }
        public int InicioRId { get; set; }

        [Required]
        public string name { get; set; }
        [Required]
        public string apellido { get; set; }

        [Required]
        [EmailAddress]
        public string email{ get; set; }
        
        public int telefono { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string RUC { get; set; }

        [Required]
        public string confirm_pasword { get; set; }
        
    }
}