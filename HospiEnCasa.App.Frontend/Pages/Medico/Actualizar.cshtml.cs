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
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioMedico _RepoMedico;

        public Medico medico {get;set;}
        public ActualizarModel(IRepositorioMedico _RepoMedico)
        {
            this._RepoMedico=_RepoMedico;
        }

        public IActionResult OnGet(int Id)
        {
            medico=_RepoMedico.GetMedico(Id);
            if(medico==null)
            {
                return NotFound();
            }
            else{
                return Page();
            }
        }
        public IActionResult OnPost(Medico medico)
        {
            _RepoMedico.UpdateMedico(medico);
            return RedirectToPage("Index");
        }
    }
}
