using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.RazorPages.Redirect.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            //return RedirectToPage("PrivacyPolicy");
            //return RedirectToPagePermanent("PrivacyPolicy");
            return RedirectToPagePreserveMethod("PrivacyPolicy");
            //return RedirectToPagePermanentPreserveMethod("PrivacyPolicy");
        }
    }
}
