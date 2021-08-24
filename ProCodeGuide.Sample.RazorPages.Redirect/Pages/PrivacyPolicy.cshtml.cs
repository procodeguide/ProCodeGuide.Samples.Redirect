using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.RazorPages.Redirect.Pages
{
    public class PrivacyPolicyModel : PageModel
    {
        private readonly ILogger<PrivacyPolicyModel> _logger;

        public PrivacyPolicyModel(ILogger<PrivacyPolicyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
