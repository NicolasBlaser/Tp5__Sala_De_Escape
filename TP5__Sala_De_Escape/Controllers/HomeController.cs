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
                return View("Habitacion" + Escape.GetEstadoJuego());
            }
            else if(Escape.ResolverSala(sala, clave))
            {
                ViewBag.Error = "La respuesta introducida fue incorrecta";
            }
            else if(sala == 5 && Escape.ResolverSala(sala, clave))
            {
                return View("Victoria");
            } 
            return View(RedirectToAction("Comenzar"));
        }

        public IActionResult Creditos()
        {
            return View();
        }
    }
}
