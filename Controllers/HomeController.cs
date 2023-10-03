using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Dapper;
using tp9.Models;
namespace tp9.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
