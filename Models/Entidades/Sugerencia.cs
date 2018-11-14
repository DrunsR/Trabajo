using System.ComponentModel.DataAnnotations;
using Trabajo.Models;
namespace Trabajo.Models
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