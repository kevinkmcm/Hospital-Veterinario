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
    public class eliminarModel : PageModel
    {
        private readonly IRepositorioMedico _RepoMedico;
        public Medico medico {get;set;}
        public EliminarModel (IRepositorioMedico _RepoMedico)
        {
            this._RepoMedico=_RepoMedico;
        }
        public IActionResult OnGet(int Id)
        {
             medico=_RepoMedico.GetMedico( Id);
            if(Medico==null)
            {
                return NotFound();
            }
            else{
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
