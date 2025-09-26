using Microsoft.AspNetCore.Mvc;
using Ejercicio_7.Models;

namespace Ejercicio_7.Controllers
{
    public class OperacionesController : Controller
    {
        public IActionResult Sumar(int a, int b)
        {
            var operacion = new Operaciones
            {
                Numero1 = a,
                Numero2 = b,
                Nombre_Operacion = "Suma",
                Resultado = a + b
            };
            return View("Resultado", operacion);
        }

        public IActionResult Restar(int a, int b)
        {
            var operacion = new Operaciones
            {
                Numero1 = a,
                Numero2 = b,
                Nombre_Operacion = "Resta",
                Resultado = a - b
            };
            return View("Resultado", operacion);
        }

        public IActionResult Multiplicar(int a, int b)
        {
            var operacion = new Operaciones
            {
                Numero1 = a,
                Numero2 = b,
                Nombre_Operacion = "Multiplicación",
                Resultado = a * b
            };
            return View("Resultado", operacion);
        }

        public IActionResult Residuo(int a, int b)
        {
            var operacion = new Operaciones
            {
                Numero1 = a,
                Numero2 = b,
                Nombre_Operacion = "Residuo",
                Resultado = b != 0 ? a % b : double.NaN
            };
            return View("Resultado", operacion);
        }
    }
}
