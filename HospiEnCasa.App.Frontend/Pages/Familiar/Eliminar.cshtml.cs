using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Frontend.Pages.Familiar
{
    public class EliminarModel : PageModel
    {
        private readonly IRepositorioFamiliar _RepoFamiliar;
        public Familiar familiar {get;set;}
        public EliminarModel (IRepositorioFamiliar _RepoFamiliar)
        {
            this._RepoFamiliar=_RepoFamiliar;
        }
        public IActionResult OnGet( int Id)
        {
             familiar=_RepoFamiliar.GetFamiliar(  Id);
            if(Familiar==null)
            {
                return NotFound();
            }
            else{
                return Page();
            }
        }
        public IActionResult OnPost(int Id)
        {
         _RepoFamiliar.DeleteFamiliar(Id);
            return RedirectToPage("Index");      
        }
    }
}
