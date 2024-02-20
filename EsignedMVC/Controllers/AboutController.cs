using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace EsignedMVC.Controllers;

public class AboutController : Controller
{
   
    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Portfolio()
    {
        return View();
    }

}

