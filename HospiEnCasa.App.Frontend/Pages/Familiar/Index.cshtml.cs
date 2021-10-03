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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioFamiliar _RepoFamiliar;

        public IEnumerable <Familiar> Familiares {get;set;}

        public IndexModel(IRepositorioFamiliar _RepoFamiliar)
        {
            this._RepoFamiliar=_RepoFamiliar;
        }
    
        public void OnGet()
        {
            Familiares=_RepoFamiliar.GetAllFamiliares();
        }
    }
}
