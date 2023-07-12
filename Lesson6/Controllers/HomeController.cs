using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lesson6.Models;

namespace Lesson6.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var model = new HelloWorldModel
        {
            Text = "Ivan!"
        };
        ViewData["Message"] = "Some message";
        ViewBag.text_another = "Some another text";
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}