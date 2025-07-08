using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP06_Drucker_Daiksel.Models;

namespace TP06_Drucker_Daiksel.Controllers;

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
