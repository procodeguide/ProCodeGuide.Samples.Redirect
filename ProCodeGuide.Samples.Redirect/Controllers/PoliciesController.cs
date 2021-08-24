using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuide.Samples.Redirect.Controllers
{
    public class PoliciesController : Controller
    {
        public IActionResult PrivacyPolicy()
        {
            return View();
        }
    }
}
