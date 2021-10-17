using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioMedico _RepoMedico;
        public Medico medic {get;set;}

        public CreateModel (IRepositorioMedico _RepoMedico)
        {
            this._RepoMedico = _RepoMedico;
        }
        public void OnGet()
        {
            this.medic = new Medico();
        }

        public IActionResult OnPost(Medico medic)
        {
            _RepoMedico.AddMedico(medic);
            return RedirectToPage("Index");
        }
    }
}
