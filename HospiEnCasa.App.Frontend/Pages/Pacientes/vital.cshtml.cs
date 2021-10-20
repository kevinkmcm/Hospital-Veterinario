using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Frontend.Pacientes
{
    public class vitalModel : PageModel
    {
        private readonly IRepositorioPaciente _Repopaciente;
        public Paciente paciente { get; set; }

        public SignoVital signo { get; set; }

        public vitalModel (IRepositorioPaciente _Repopaciente)
        {
            this._Repopaciente = _Repopaciente;
        }
        public IActionResult OnGet(int id)
        {
            paciente = _Repopaciente.GetPaciente(id);
            if(paciente!=null)
            {
                return Page();
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult OnPost(int Id,SignoVital signo)
        {
            _Repopaciente.AddSigno(Id, signo);
            return RedirectToPage("Index");
        }
    }
}
