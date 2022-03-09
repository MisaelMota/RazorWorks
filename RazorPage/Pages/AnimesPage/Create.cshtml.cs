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
    public class CreateModel : PageModel
    {
        private readonly IAnimesControl _animesControl;

        public CreateModel(IAnimesControl animesControl )
        {
            this._animesControl = animesControl;
        }

        [BindProperty]
        public Animes anime { get; set; }
      


        public void OnGet()
        {


        }

        public IActionResult OnPost()
        {

            _animesControl.CreateAnime(this.anime);
            return RedirectToPage("Index");

        }
    }
}
