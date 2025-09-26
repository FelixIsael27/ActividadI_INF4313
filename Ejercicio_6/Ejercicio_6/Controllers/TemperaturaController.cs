using Microsoft.AspNetCore.Mvc;
using Ejercicio_6.Models;

namespace Ejercicio_6.Controllers
{
    public class TemperaturaController : Controller
    {
        public IActionResult Convertir(double fahrenheit)
        {
            var model = new Temperatura
            {
                Fahrenheit = fahrenheit,
                Celsius = (fahrenheit - 32) * 5 / 9
            };

            return View(model);
        }
    }
}
