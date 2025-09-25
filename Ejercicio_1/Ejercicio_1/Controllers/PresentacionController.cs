using Microsoft.AspNetCore.Mvc;
using Ejercicio_1.Models;

namespace Ejercicio_1.Controllers
{
    public class PresentacionController : Controller
    {
        public IActionResult Saludo()
        {
            var mensaje = new Datos
            {
                Nombres = "Felix Isael Mejia Castillo",
                Matricula = "SD-2023-05529"
            };

            return View(mensaje);
        }
    }
}
