using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP5__Sala_De_Escape.Models;

namespace TP5__Sala_De_Escape.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tutorial()
        {
            return View();
        }

        public IActionResult Comenzar()
        {
            return View("Habitacion" + Escape.GetEstadoJuego());
        }
        
        public IActionResult Habitacion(int sala, string clave)
        {
            if(sala > Escape.GetEstadoJuego())
            {
                ViewBag.Error = "Esta habitación no corresponde con el estado del juego";
                return View("Habitacion" + Escape.GetEstadoJuego());
            }
            else
            {
                bool a = Escape.ResolverSala(sala, clave);
                if(a)
                {
                    if(sala == 5)
                    {
                        return View("Victoria");
                    }
                }
                else
                {
                    ViewBag.Error = "La respuesta introducida es incorrecta";
                }
            }
            
            return View("Habitacion" + Escape.GetEstadoJuego());
        }

        public IActionResult Creditos()
        {
            return View();
        }

        public IActionResult Victoria()
        {
            return View();
        }
    }
}
