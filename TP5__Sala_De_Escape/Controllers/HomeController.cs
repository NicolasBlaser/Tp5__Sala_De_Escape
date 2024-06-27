using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP5__Sala_De_Escape.Models;

namespace TP5__Sala_De_Escape.Controllers;

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
}
