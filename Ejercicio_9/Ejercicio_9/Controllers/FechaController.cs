using Microsoft.AspNetCore.Mvc;
using Ejercicio_9.Models;

namespace Ejercicio_9.Controllers
{
    public class FechaController : Controller
    {
        [HttpGet]
        public IActionResult DiaSemana()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DiaSemana(FechaModel model)
        {
            if (ModelState.IsValid)
            {
                model.DiaSemana = model.Fecha.ToString("dddd", new System.Globalization.CultureInfo("es-ES"));
                return View(model);
            }

            return View(model);
        }
    }
}
