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
    public class HistorialModel : PageModel
    {
        private readonly IRepositorioPaciente _RepoPaciente;
        public Paciente paciente { get; set; }

        public Historia historia { get; set; }
        public SugerenciaDecuidado sugerencia { get; set; }

        public HistorialModel(IRepositorioPaciente _RepoPaciente)
        {
            this._RepoPaciente = _RepoPaciente;
        }
        public IActionResult OnGet(int id)
        {
            paciente = _RepoPaciente.GetPaciente(id);
            if (paciente != null)
            {
                return Page();
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult OnPost(int Id, Historia Historia, SugerenciaDecuidado sugerencia)
        {
            _RepoPaciente.AddHistoria(Id, Historia,sugerencia);
            return RedirectToPage("Index");
        }
    }
}
