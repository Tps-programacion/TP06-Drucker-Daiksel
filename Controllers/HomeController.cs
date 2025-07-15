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

    public IActionResult login(string email, string contraseña)
    {
        
        
        if (HttpContext.Session.GetString("idUsuario") == null){
            ViewBag.mensaje  = "Ya hay un usuario logueado, para ingresar denuevo primero salga de sesion";
        

        }
        else
            {
            Usuario usuarioLogueado = null;
            if(email == null || contraseña == null ){
                ViewBag.mensaje = "En algunos de los campos no se ingreso informacion";
                return View("Index");
            }
            else{
                int id = -1;
                id = BD.login(email, contraseña);
                
            if(id != -1){
                usuarioLogueado = BD.GetUsuario(id);
                ViewBag.Usuario = usuarioLogueado;
                ViewBag.mensaje = "Bienvenido" + usuarioLogueado.Nombre;
                HttpContext.Session.SetString("idUsuario", id.ToString());
                
            }
            else{
                ViewBag.mensaje = "Uno de los campos o ambos fueron ingresados incorrectamente.";
                return View("Index");
            }
         
        }                
            }

            return View("Bienvenida");
    }

    public IActionResult Index()
    {
        return View();
    }
}
