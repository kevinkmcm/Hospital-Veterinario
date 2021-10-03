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
        public class IndexModel:PageModel
        {
            private readonly IRepisitorioMedico _RepoMedico;

            public IEnumerable <Medico> Medicos {get;set;}

            public IndexModel (IRepisitorioMedico _RepoMedico)
            {
                this._RepoMedico=_RepoMedico;
            }
        }
        public void OnGet()
        {
            Medicos=_RepoMedico.GetAllMedicos();
        }
    }
}
