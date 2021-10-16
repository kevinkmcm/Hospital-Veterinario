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
    public class crearModel : PageModel
    {
        private readonly IRepositorioFamiliar _RepoFamiliar;

        public FamiliarDesignado familiarDesignado{get;set;}

        public crearModel (IRepositorioFamiliar _RepoFamiliar)
        {
            this._RepoFamiliar=_RepoFamiliar;
        }
        public void OnGet()
        {
            familiarDesignado=new FamiliarDesignado();
        }
        public IActionResult OnPost( FamiliarDesignado familiarDesignado)
        {
            _RepoFamiliar.AddFamiliarDesignado(familiarDesignado);
            return RedirectToPage("Index");
        }
    }
}
