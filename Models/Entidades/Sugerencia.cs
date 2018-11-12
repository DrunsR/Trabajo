using System.ComponentModel.DataAnnotations;
using Trabajo.Models;
using Trabajo.Models.Entidades;
namespace Trabajo.Models.Entidades
{
    public class Sugerencia
    {

        public int Id { get; set; }
        public string asunto { get; set; }
         public Restaurante Rest { get; set; }
        public int RegistroRestId { get; set; }
        public string detalle { get; set; }
    }
}