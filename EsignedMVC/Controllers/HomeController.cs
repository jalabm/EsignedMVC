using System.Diagnostics;
using EsignedMVC.Contexts;
using Microsoft.AspNetCore.Mvc;


namespace EsignedMVC.Controllers;

public class HomeController : Controller
{
    private readonly EsignedDbContext _esignedDbContext;

    public HomeController(EsignedDbContext esignedDbContext)
    {
        _esignedDbContext = esignedDbContext;

    }
    public async  Task<IActionResult> Index()
    {
        //_esignedDbContext.Positions.ToList();
        return View();
    }
}

