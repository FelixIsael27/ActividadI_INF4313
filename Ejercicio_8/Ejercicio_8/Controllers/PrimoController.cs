using Microsoft.AspNetCore.Mvc;
using Ejercicio_8.Models;

namespace Ejercicio_8.Controllers
{
    public class PrimoController : Controller
    {
        public IActionResult Verificar(int numero)
        {
            var model = new PrimoModel
            {
                Numero = numero,
                Es_o_No_Primo = Es_o_No_Primo(numero)
            };

            return View(model);
        }

        private bool Es_o_No_Primo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}
