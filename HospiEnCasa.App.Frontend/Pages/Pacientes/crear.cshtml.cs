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
    public class crearModel : PageModel
    {
        private readonly IRepositorioPaciente _RepoPaciente;

        public Paciente paciente{get;set;}

        //metodo constructor
        public crearModel(IRepositorioPaciente _RepoPaciente)
        {
            this._RepoPaciente=_RepoPaciente;
        }

        public void OnGet()
        {
            Paciente=new Paciente();
        }
        //METODO PARA EMVIAR A LA BASE DE DATOS
        public IActionResult OnPost(Paciente paciente)
        {
            _RepoPaciente.AddPaciente(paciente);
            return RedirectToPage("Index");

        }
    }
}
