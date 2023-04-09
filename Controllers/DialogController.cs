using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _7Core_MUI_UI_jQuery_UI.Models;

namespace _7Core_MUI_UI_jQuery_UI.Controllers;

public class DialogController : Controller
{
    private readonly ILogger<DialogController> _logger;

    public DialogController(ILogger<DialogController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
