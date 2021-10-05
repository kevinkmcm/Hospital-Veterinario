using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages.Pacientes
{
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioPaciente _RepoPaciente;

        public Paciente paciente {get;set;}
        public ActualizarModel(IRepositorioPaciente _RepoPaciente)
        {
            this._RepoPaciente=_RepoPaciente;
        }

        public IActionResult OnGet(int Id)
        {
            paciente=_RepoPaciente.GetPaciente(Id);
            if(paciente==null)
            {
                return NotFund();
            }
            else{
                return Page();
            }
        }
        public IActionResult OnPost(Paciente Paciente)
        {
            _RepoPaciente.UpdatePaciente(paciente);
            return RedirectToPage("Index");
        }
    }
}
