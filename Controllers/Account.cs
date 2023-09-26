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
        ViewBag.Username = BD.Login(username, contraseña);
        return View("Index");
    }
    public IActionResult Registrarse_view()
    {
        return View("Registrarse");
    }
    [HttpPost] public IActionResult Registrarse(Usuario user)
    {
        BD.Registrarse(user);
        return View("Index");
    }
    public IActionResult ReemplazarContraseña_View()
    {
        return View("ReemplazarContraseña");
    }
    public IActionResult ReemplazarContraseña(string mail, string contraseña)
    {
        BD.ReemplazarContraseña(mail, contraseña);
        return View("index");
    }
}

