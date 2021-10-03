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

        public Medico medico{get;set;}
        
        public crearModel (IRepositorioMedico _RepoMedico)
        {
            this._RepoMedico=_RepoMedico;
        }
        public void OnGet()
        {
            Medico=new Medico();
        }

        public IActionResult OnPost(Medico medico)
        {
            _RepoMedico.addMedico(medico);
            return RedirectToPage("Index");
        }
    }
}
