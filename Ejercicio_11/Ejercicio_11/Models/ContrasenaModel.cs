using System.ComponentModel.DataAnnotations;

namespace Ejercicio_11.Models
{
    public class ContrasenaModel
    {
        [Required(ErrorMessage = "Debe ingresar una contraseña.")]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }

        public string Mensaje { get; set; }
    }
}
