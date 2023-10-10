using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Dapper;
using tp9.Models;
namespace tp9.Controllers;
public class Account : Controller
{
    public IActionResult Login_view()
    {
        return View("Login");
    }
    public IActionResult Login(string username, string contraseña)
    {
        if (BD.Login(username, contraseña) == null) 
        {
            return View("Login");
        }
        else
        {
            return RedirectToAction("Welcome", new {name = username});
        }
    }
    public IActionResult Welcome(string name)
    {
        ViewBag.UserName = name;
        return View("Welcome");
    }
    public IActionResult Registro_View()
    {
        return View("Registro");
    }
    [HttpPost] public IActionResult Registro(Usuario user)
    {
        if(BD.BuscarUsuario(user.UserName) != "")
        {
            BD.Registrarse(user);
            return RedirectToAction("Login_view");
        }
        else{return View("Registro",user);}
    }
    public IActionResult OlvideContraseña_View()
    {
        return View("Olvide");
    }
    public IActionResult OlvideContraseña(string mail, string contraseña)
    {
        
        if (BD.ReemplazarContraseña(mail, contraseña) == null)
        {
            return View("Olvide");
        }
        else
        {
            BD.ReemplazarContraseña(mail, contraseña);
            return View("Login");
        }
    }
}