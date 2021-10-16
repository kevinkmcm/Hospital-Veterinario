using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages.Medico
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorioMedico _RepoMedico;

        // public Medico medic{get;set;}
        
        public CrearModel (IRepositorioMedico _RepoMedico)
        {
            this._RepoMedico=_RepoMedico;
        }
        public void OnGet()
        {
            // medic=new Medico();
        }

        public IActionResult OnPost(dynamic medic)
        {
            _RepoMedico.AddMedico(medic);
            return RedirectToPage("Index");
        }
    }
}
