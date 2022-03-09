using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPage.Data;
using RazorPage.Models;

namespace RazorPage.Pages.AnimesPage
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IAnimesControl _animesControl;

        public IndexModel(ILogger<IndexModel> logger, IAnimesControl animesControl)
        {
            _logger = logger;
            _animesControl = animesControl;
        }

        public IEnumerable<Animes> Anime { get; set; }
        public void OnGet()
        {
            Anime = _animesControl.GetAnimes();

        }
    }
}
