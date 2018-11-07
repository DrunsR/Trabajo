using System.ComponentModel.DataAnnotations;

namespace Trabajo.Models
{
    public class registrorestaurant
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string apellido { get; set; }
        [Required]
        public string username { get; set; }
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
        public string password{ get; set; }
        [Required]
        public string confirm_pasword { get; set; }
    }
}