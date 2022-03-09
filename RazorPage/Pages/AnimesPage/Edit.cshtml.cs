using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Data;
using RazorPage.Models;

namespace RazorPage.Pages.AnimesPage
{
    public class EditModel : PageModel
    {
        private readonly IAnimesControl _animesControl;

        public EditModel(IAnimesControl animesControl)
        {
            this._animesControl = animesControl;
        }

        [BindProperty]
        public Animes anime { get; set; }


        public void OnGet()
        {
            int AnimeId = int.Parse(Request.Query["id"].ToString());
            var animeN = _animesControl.AnimesPorID(AnimeId);
            anime = animeN;
        }

        public IActionResult OnPost()
        {
            _animesControl.UpdateAnimes(this.anime);
            return RedirectToPage("Index");

        }
    }
}
