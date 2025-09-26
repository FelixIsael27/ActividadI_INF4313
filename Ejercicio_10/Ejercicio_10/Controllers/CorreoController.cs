using Microsoft.AspNetCore.Mvc;
using Ejercicio_10.Models;

namespace Ejercicio_10.Controllers
{
    public class CorreoController : Controller
    {
        public IActionResult Usuario(string email)
        {
            var model = new CorreoModel();

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                model.Mensaje_Error = "Correo inválido";
            }
            else
            {
                model.Email = email;
                model.Nombre_Usuario = email.Split('@')[0];
            }

            return View(model);
        }
    }
}
