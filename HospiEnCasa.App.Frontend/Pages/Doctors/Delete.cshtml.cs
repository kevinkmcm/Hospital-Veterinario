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
    public class DeleteModel : PageModel
    { private readonly IRepositorioMedico _RepoMedico;
        public Medico medic {get;set;}
        public DeleteModel(IRepositorioMedico _RepoMedico)
        {
            this._RepoMedico = _RepoMedico;
        }
        public IActionResult OnGet(int Id)
        {
            this.medic = _RepoMedico.GetMedico(Id);
            if (this.medic == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(int Id)
        {
            _RepoMedico.DeleteMedico(Id);
            return RedirectToPage("Index");
        }
    }
}
