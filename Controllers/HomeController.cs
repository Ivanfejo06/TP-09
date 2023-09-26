using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;
public class HomeController : Controller
{
    public IActionResult Index(string username, string contraseña)
    {
        return View();
    }
}
