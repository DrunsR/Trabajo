using System.ComponentModel.DataAnnotations;

namespace Trabajo.Models.Entidades
{
    public class RegistroMenu
    {
        public int Id { get; set; }
        [Required]
        public string Nombre  { get; set; }
        [Required]
        public int Precio { get; set; }
        [Required]
        public string Imagen { get; set; }
        public string Descripcion { get; set; }

        public Restaurante reg{get; set;}
        public int regId { get; set; }
    }
}