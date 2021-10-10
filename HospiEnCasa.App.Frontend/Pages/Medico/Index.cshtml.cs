using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Frontend.Pages.Medico
{
    public class IndexModel : PageModel
    {
        
            private readonly IRepositorioMedico _RepoMedico;

            public IEnumerable <Medico> Medicos {get;set;}

            public IndexModel (IRepositorioMedico _RepoMedico)
            {
                this._RepoMedico=_RepoMedico;
            }
        
        public void OnGet()
        {
            Medicos=_RepoMedico.GetAllMedicos();
        }
    }

}