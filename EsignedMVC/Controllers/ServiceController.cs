using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace EsignedMVC.Controllers;

public class ServiceController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

}

