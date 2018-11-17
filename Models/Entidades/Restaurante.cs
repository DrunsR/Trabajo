using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace Trabajo.Models
{
    public class Restaurante
    {
        [BindProperty]
        public InicioR ini { get; set; }
        public int Id { get; set; }

        [Required (ErrorMessage = "Falta ingresar nombre")]
        public string nombre { get; set; }
        [Required (ErrorMessage = "Falta ingresar apellido")]
        public string apellido { get; set; }

        
        

        [Required (ErrorMessage = "Falta ingresar el correo electronico")]
        [EmailAddress (ErrorMessage = "Necesita el formato example@example.com")]
        public string email{ get; set; }

        [StringLength(9, ErrorMessage = "El telefono debe tener  9 digitos"),MinLength(9, ErrorMessage = "El telefono debe tener  9 digitos")]
        [DataType(DataType.PhoneNumber,ErrorMessage = "No cumple con el formato de telefono")]
        public string telefono { get; set; }

        [Required(ErrorMessage = "Necesita ingresar la ubicacion del lugar")]
        public string direccion { get; set; }
        [Required (ErrorMessage = "Falta ingresar el RUC del negocio")]
        [StringLength(11 ,ErrorMessage = "El RUC debe tener 11 digitos"),MinLength(11, ErrorMessage = "El RUC debe tener  11 digitos")]
        public string RUC { get; set; }

        [Required(ErrorMessage = "Falta confirmar la contraseña")]
        [DataType(DataType.Password)]
        public string confirm_password { get; set; }
        
        [Required (ErrorMessage = "Necesita ingresar el nombre de su Local")]
        public string nombreTienda { get; set; }
        
        public string foto { get; set; }
        public string descripcion { get; set; }

        public List<Platillo> Menu { get; set; }
        public List<Sugerencia> Recomendaciones { get; set; }


        
    }
}