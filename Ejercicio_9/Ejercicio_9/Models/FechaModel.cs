using System.ComponentModel.DataAnnotations;

namespace Ejercicio_9.Models
{
    public class FechaModel
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        public string DiaSemana { get; set; }
    }
}
