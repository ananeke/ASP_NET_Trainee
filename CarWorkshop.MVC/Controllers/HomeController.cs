using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarWorkshop.MVC.Models;

namespace CarWorkshop.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult About()
    {
        var model = new List<AboutViewModel>()
        {
            new AboutViewModel()
            { 
                Title = "About Us",
                Description = "This is a description of the application.",
                Tags = new[] { "ASP.NET Core", "C#", "Razor Pages" } 
            },
            new AboutViewModel()
            {

                Title = "O nas",
                Description = "To jest opis mojej aplikacji",
                Tags = new[] { "ASP.NET Core", "C#", "Razor Pages" }
            },
        };
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
