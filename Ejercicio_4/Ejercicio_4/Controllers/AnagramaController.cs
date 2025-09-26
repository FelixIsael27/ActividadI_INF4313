using Microsoft.AspNetCore.Mvc;
using Ejercicio_4.Models;

namespace Ejercicio_4.Controllers
{
    public class AnagramaController : Controller
    {
        public IActionResult Verificar(string texto1, string texto2)
        {
            var model = new AnagramaModel
            {
                Texto1 = texto1,
                Texto2 = texto2,
                Es_o_NoAnagrama = false
            };

            if (!string.IsNullOrWhiteSpace(texto1) && !string.IsNullOrWhiteSpace(texto2))
            {
                var normalizado1 = new string(texto1.ToLower().Replace(" ", "").OrderBy(c => c).ToArray());
                var normalizado2 = new string(texto2.ToLower().Replace(" ", "").OrderBy(c => c).ToArray());

                model.Es_o_NoAnagrama = normalizado1 == normalizado2;
            }

            return View(model);
        }
    }
}
