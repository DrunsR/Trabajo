using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Trabajo.Models
{
    public class Restaurante
    {

        [BindProperty]
		public InicioR Ini { get; set; }
        public int InicioRId { get; set; }

        [Required]
        public string nombre { get; set; }
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
        public string confirm_password { get; set; }
        [Required]
        public string nombreTienda { get; set; }
        [Required]
        public string foto { get; set; }
        public string descripcion { get; set; }
        
    }
}