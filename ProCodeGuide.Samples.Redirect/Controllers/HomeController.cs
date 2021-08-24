using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProCodeGuide.Samples.Redirect.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuide.Samples.Redirect.Controllers
{
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
            //return Redirect("~/Policies/PrivacyPolicy");
            //return RedirectPermanent("~/Policies/PrivacyPolicy");
            //return RedirectPreserveMethod("~/Policies/PrivacyPolicy");
            //return RedirectPermanentPreserveMethod("~/Policies/PrivacyPolicy");

            //return RedirectToAction("PrivacyPolicy", "Policies");
            //return RedirectToActionPermanent("PrivacyPolicy", "Policies");
            //return RedirectToActionPreserveMethod("PrivacyPolicy", "Policies");
            //return RedirectToActionPermanentPreserveMethod("PrivacyPolicy", "Policies");

            //return RedirectToRoute(new { controller = "Policies", action = "PrivacyPolicy" });
            //return RedirectToRoutePermanent(new { controller = "Policies", action = "PrivacyPolicy" });
            //return RedirectToRoutePreserveMethod("default", new { controller = "Policies", action = "PrivacyPolicy" });
            //return RedirectToRoutePermanentPreserveMethod("default", new { controller = "Policies", action = "PrivacyPolicy" });

            return LocalRedirect("~/Policies/PrivacyPolicy");
            //return LocalRedirectPermanent("~/Policies/PrivacyPolicy");
            //return LocalRedirectPreserveMethod("~/Policies/PrivacyPolicy");
            //return LocalRedirectPermanentPreserveMethod("~/Policies/PrivacyPolicy");
        }

        public IActionResult About()
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
