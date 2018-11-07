using System.ComponentModel.DataAnnotations;

namespace Trabajo.Models
{
    public class registrocliente
    {
        [Required]
        public string username { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password{ get; set; }
        [Required]
        public string confirm_pasword { get; set; }
        
    }
}