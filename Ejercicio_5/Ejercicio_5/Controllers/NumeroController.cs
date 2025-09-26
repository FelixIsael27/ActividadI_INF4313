using Microsoft.AspNetCore.Mvc;
using Ejercicio_5.Models;

namespace Ejercicio_5.Controllers
{
    public class NumeroController : Controller
    {
        public IActionResult Tabla(int numero)
        {
            var model = new TabladeMultiplicar
            {
                Numero = numero
            };

            for (int i = 1; i <= 10; i++)
            {
                model.Resultados.Add($"{numero} x {i} = {numero * i}");
            }

            return View(model);
        }
    }
}
