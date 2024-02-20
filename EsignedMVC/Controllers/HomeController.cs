using System.Diagnostics;
using Esigned.core.Models;
using EsignedMVC.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        IEnumerable<Slider> sliders =
             await _esignedDbContext.Sliders.Where(x => !x.IsDeleted)
             .AsNoTracking()
             .ToListAsync();
        return View(sliders);
    }
}

