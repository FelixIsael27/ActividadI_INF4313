using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using Ejercicio_11.Models;

namespace Ejercicio_11.Controllers
{
    public class SeguridadController : Controller
    {
        [HttpGet]
        public IActionResult ClaveFuerte()
        {
            return View(new ContrasenaModel());
        }

        [HttpPost]
        public IActionResult ClaveFuerte(ContrasenaModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (EsContraseñaFuerte(model.Contraseña))
            {
                model.Mensaje = "La contraseña es segura.";
            }
            else
            {
                model.Mensaje = "La contraseña NO es segura. Debe tener al menos 8 caracteres, una mayúscula, una minúscula y un número.";
            }

            return View(model);
        }

        private bool EsContraseñaFuerte(string contraseña)
        {
            if (contraseña.Length < 8)
                return false;

            bool tieneMayuscula = Regex.IsMatch(contraseña, "[A-Z]");
            bool tieneMinuscula = Regex.IsMatch(contraseña, "[a-z]");
            bool tieneNumero = Regex.IsMatch(contraseña, "[0-9]");

            return tieneMayuscula && tieneMinuscula && tieneNumero;
        }
    }
}
