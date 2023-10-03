using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Dapper;
using tp9.Models;
namespace tp9.Controllers;
public class Account : Controller
{
    public IActionResult Login(string username, string contraseña)
    {
        if (BD.Login(username, contraseña) == null)
        {
            return View("Index");
        }
        else {return RedirectToAction("welcome");}
    }
    public IActionResult Registro_view()
    {
        return View("Registro");
    }
    [HttpPost] public IActionResult Registro(Usuario user)
    {
        if(BD.BuscarUsuario(user.UserName != null))
        {
            BD.Registrarse(user);
            return RedirectToAction("welcome");
        }
        else{return View(Registro(user));}
    }
    public IActionResult OlvideContraseña_View()
    {
        return View("Olvide");
    }
    public IActionResult OlvideContraseña(string mail, string contraseña)
    {
        BD.ReemplazarContraseña(mail, contraseña);
        return View("index");
    }
}

