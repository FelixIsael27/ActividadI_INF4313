using Microsoft.AspNetCore.Mvc;
using Ejercicio_3.Models;

namespace Ejercicio_3.Controllers
{
    public class NumeroController : Controller
    {
        [HttpGet]
        public IActionResult Signo()
        {
            return View(new NumModel());
        }

        [HttpPost]
        public IActionResult Signo(NumModel model)
        {
            if (model.Numero > 0)
                model.Resultado = $"El número {model.Numero} es Positivo.";
            else if (model.Numero < 0)
                model.Resultado = $"El número {model.Numero} es Negativo.";
            else
                model.Resultado = "El número es Cero.";

            return View(model);
        }
    }
}
