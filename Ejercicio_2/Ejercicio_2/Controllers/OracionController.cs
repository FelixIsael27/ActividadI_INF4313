using Microsoft.AspNetCore.Mvc;
using Ejercicio_2.Models;

namespace Ejercicio_2.Controllers
{
    public class OracionController : Controller
    {
        [HttpGet]
        public IActionResult ContarVocales(string frase)
        {
            if (string.IsNullOrEmpty(frase))
            {
                return View(new OracionModel { Frase = "", Cantidad_Vocales = 0 });
            }

            int cantidad = frase.Count(c => "aeiouáéíóúAEIOUÁÉÍÓÚ".Contains(c));

            var modelo = new OracionModel
            {
                Frase = frase,
                Cantidad_Vocales = cantidad
            };

            return View(modelo);
        }
    }
}
