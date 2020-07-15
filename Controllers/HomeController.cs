using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IOC.Models;

namespace IOC.Controllers
{
    public class HomeController : Controller
    {
        // Singleton - proje calısma zamanı boyunca tek bir nesne uretilir.
        /*
        private readonly ISingletonDateService _singletonDateService;
      
        public HomeController(ISingletonDateService singletonDateService)
        {
            _singletonDateService = singletonDateService;
        }

        public IActionResult Index([FromServices]ISingletonDateService singletonDateService2)
        {
            ViewBag.time1 = _singletonDateService.GetDateTime.TimeOfDay.ToString();

            ViewBag.time2 = singletonDateService2.GetDateTime.TimeOfDay.ToString();

            return View();
        }
        */

        // Scoped - bir requestte bir nesne uretilir. her requestte yenilenir.
        /*
        private readonly IScopeDateService _scopeDateService;

        public HomeController(IScopeDateService scopeDateService)
        {
            _scopeDateService = scopeDateService;
        }

        public IActionResult Index([FromServices] IScopeDateService scopeDateService2)
        {
            ViewBag.time1 = _scopeDateService.GetDateTime.TimeOfDay.ToString();

            ViewBag.time2 = scopeDateService2.GetDateTime.TimeOfDay.ToString();

            return View();
        }
        */

        // Transient- her enjecte edildiginde yeni bir nesne uretilir.
        private readonly ITransientDateService _transientDateService;

        public HomeController(ITransientDateService transientDateService)
        {
            _transientDateService = transientDateService;
        }

        public IActionResult Index([FromServices] ITransientDateService transientDateService2)
        {
            ViewBag.time1 = _transientDateService.GetDateTime.TimeOfDay.ToString();

            ViewBag.time2 = transientDateService2.GetDateTime.TimeOfDay.ToString();

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
}
