using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IOC.Web.Models;

namespace IOC.Web.Controllers;

public class HomeController : Controller
{
    private readonly ISingletonDateService _singletonDateService;
    private readonly IScopedDateService _scopedDateService;
    private readonly ITransientDateService _transientDateService;

    public HomeController(ISingletonDateService singletonDateService,
                          IScopedDateService scopedDateService,
                          ITransientDateService transientDateService)
    {
        _singletonDateService = singletonDateService;
        _scopedDateService = scopedDateService;
        _transientDateService = transientDateService;
    }

    public IActionResult Index([FromServices] ISingletonDateService singletonDateService,
                               [FromServices] IScopedDateService scopedDateService,
                               [FromServices] ITransientDateService transientDateService)
    {
        ViewBag.time1 = _singletonDateService.GetDateTime.TimeOfDay.ToString();
        ViewBag.time2 = singletonDateService.GetDateTime.TimeOfDay.ToString();

        ViewBag.time3 = _scopedDateService.GetDateTime.TimeOfDay.ToString();
        ViewBag.time4 = scopedDateService.GetDateTime.TimeOfDay.ToString();

        ViewBag.time5 = _transientDateService.GetDateTime.TimeOfDay.ToString();
        ViewBag.time6 = transientDateService.GetDateTime.TimeOfDay.ToString();

        return View();
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

