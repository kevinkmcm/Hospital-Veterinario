using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Frontend.Familiar
{
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioFamiliar _RepoFamiliar;

        public Familiar familiar {get;set;}
        public ActualizarModel(IRepositorioFamiliar _RepoFamiliar)
        {
            this._RepoFamiliar=_RepoFamiliar;
        }
        public IActionResult OnGet(int Id)
        {
            aciente=_RepoFamiliar.GetFamiliar(Id);
            if(familiar==null)
            {
                return NotFound();
            }
            else{
                return Page();
            }
        }
        public IActionResult OnPost(Familiar familiar)
        {
            _RepoFamiliar.UpdateFamiliar(familiar);
            return RedirectToPage("Index");
        }
    }
}
