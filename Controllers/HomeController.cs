using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP06_Drucker_Daiksel.Models;
using Newtonsoft.Json;
namespace TP06_Drucker_Daiksel.Controllers;

public class HomeController : Controller
{



    private readonly ILogger<HomeController> _logger;



    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpPost]
    public IActionResult login(string email, string contraseña)
    {


        if (HttpContext.Session.GetString("idUsuario") != null)
        {
            ViewBag.mensaje = "Ya hay un usuario logueado. Para ingresar denuevo primero salga de sesion";
            return View("Index");

        }
        else
        {
            int id = -1;
            id = BD.login(email, contraseña);

            if (id != -1)
            {
                Usuario usuarioLogueado;
                usuarioLogueado = BD.GetUsuario(id);
                ViewBag.usuario = usuarioLogueado;
                ViewBag.mensaje = "Bienvenido " + usuarioLogueado.Nombre;
                HttpContext.Session.SetString("idUsuario", id.ToString());
                return View("Bienvenida");
            }
            else
            {
                ViewBag.mensaje = "Uno de los campos o ambos fueron ingresados incorrectamente.";
                return View("Index");

            }

        }

    }

    public IActionResult logout()
    {

        HttpContext.Session.Remove("idUsuario");
        ViewBag.mensaje = "Usted salió correctamente de la sesión.";
        return View("Index");
    }


    public IActionResult verDatosInteres()
    {
        string idString = HttpContext.Session.GetString("idUsuario");
        int id = int.Parse(idString);
        List<DatoInteres> datosInteres = BD.GetDatoInteres(id);
        Usuario usuarioLogueado = BD.GetUsuario(id);
        ViewBag.datosInteres = datosInteres;
        ViewBag.usuario = usuarioLogueado;
        HttpContext.Session.SetString("idUsuario", id.ToString());
        return View("datosInteres");
    }

    public IActionResult verDatosFamiliar()
    {

        string idString = HttpContext.Session.GetString("idUsuario");
        int id = int.Parse(idString);
        List<DatoFamiliar> datosFamiliares = BD.GetDatoFamiliar(id);
        Usuario usuarioLogueado = BD.GetUsuario(id);
        ViewBag.datosFamiliares = datosFamiliares;
        ViewBag.usuario = usuarioLogueado;
        HttpContext.Session.SetString("idUsuario", id.ToString());
        return View("datosFamiliares");
    }

    public IActionResult volverABienvenida()
    {
        string idString = HttpContext.Session.GetString("idUsuario");
        int id = int.Parse(idString);
        Usuario usuario = BD.GetUsuario(id);
        ViewBag.usuario = usuario;
        return View("Bienvenida");
    }
    public IActionResult Index()
    {

        return View();
    }
        public IActionResult verUsuario()
    {
        string idString = HttpContext.Session.GetString("idUsuario");
        int id = int.Parse(idString);
        Usuario usuario = BD.GetUsuario(id);
        ViewBag.usuario = usuario;
        return View("datosPersonales");
    }
}
