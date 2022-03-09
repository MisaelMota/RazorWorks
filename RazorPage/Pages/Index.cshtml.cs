using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RazorPage.Data;
using RazorPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
       

        public IndexModel(ILogger<IndexModel> logger,IAnimesControl animesControl)
        {
            _logger = logger;
            
        }

       
        public void OnGet()
        {
            

        }
    }

}
