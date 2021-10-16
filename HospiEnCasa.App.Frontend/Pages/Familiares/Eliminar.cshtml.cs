using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Frontend.Pages.Familiares
{
    public class EliminarModel : PageModel
    {
        private readonly IRepositorioFamiliar _RepoFamiliar;

        public FamiliarDesignado familiarDesignado {get;set;}

        public EliminarModel (IRepositorioFamiliar _RepoFamiliar)
        {
            this._RepoFamiliar=_RepoFamiliar;
        }
        public IActionResult OnGet( int Id)
        {
             familiarDesignado=_RepoFamiliar.GetFamiliarDesignado(  Id);
            if(familiarDesignado==null)
            {
                return NotFound();
            }
            else{
                return Page();
            }
        }
        public IActionResult OnPost(int Id)
        {
         _RepoFamiliar.DeleteFamiliarDesignado(Id);
            return RedirectToPage("Index");      
        }
    }
}
