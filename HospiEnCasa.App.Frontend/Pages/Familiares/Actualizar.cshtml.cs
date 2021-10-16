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
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioFamiliar _RepoFamiliar;

        public FamiliarDesignado FamiliarDesignado {get;set;}
        
        public ActualizarModel(IRepositorioFamiliar _RepoFamiliar)
        {
            this._RepoFamiliar=_RepoFamiliar;
        }
        public IActionResult OnGet(int Id)
        {
            FamiliarDesignado=_RepoFamiliar.GetFamiliarDesignado(Id);
            if(FamiliarDesignado==null)
            {
                return NotFound();
            }
            else{
                return Page();
            }
        }
        public IActionResult OnPost(FamiliarDesignado FamiliarDesignado)
        {
            _RepoFamiliar.UpdateFamiliarDesignado(FamiliarDesignado);
            return RedirectToPage("Index");
        }
    }
}
