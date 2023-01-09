using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApp.Pages
{
    public class KoukouModel : PageModel
    {
        private readonly ILogger<KoukouModel> _logger;

        public KoukouModel(ILogger<KoukouModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
