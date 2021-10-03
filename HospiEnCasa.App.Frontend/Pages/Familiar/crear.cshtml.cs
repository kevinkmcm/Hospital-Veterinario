using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospiEnCasa.App.Frontend.Pages.Familiar
{
    public class crearModel : PageModel
    {
        private readonly IRepositorioFamiliar _RepoFamiliar;

        public Familiar familiar{get;set;}

        public crearModel (IRepositorioFamiliar _RepoFamiliar)
        {
            this._RepoFamiliar=_RepoFamiliar;
        }
        public void OnGet()
        {
            Familiar=new Familiar();
        }
        public IActionResult OnPost( Familiar familiar)
        {
            _RepoFamiliar.addFamiliar(familiar);
            return RedirectToPage("Index");
        }
    }
}
