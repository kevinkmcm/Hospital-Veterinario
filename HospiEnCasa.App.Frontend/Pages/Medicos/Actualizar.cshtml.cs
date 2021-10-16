using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Frontend.Pages.Medicos
{
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioMedico _RepoMedico;

        
        public ActualizarModel(IRepositorioMedico _RepoMedico)
        {
            this._RepoMedico=_RepoMedico;
        }

        public IActionResult OnGet(int Id)
        {
            medic=_RepoMedico.GetMedico(Id);
            if(medic==null)
            {
                return NotFound();
            }
            else{
                return Page();
            }
        }
        public IActionResult OnPost(dynamic medic)
        {
            _RepoMedico.UpdateMedico(medic);
            return RedirectToPage("Index");
        }
    }
}