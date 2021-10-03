using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
using System;
using Microsoft.EntityFrameworkCore;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();

        Paciente AddPaciente(Paciente paciente);

        Paciente UpdatePaciente(Paciente paciente);

        void DeletePaciente(int IdPaciente);

        Paciente GetPaciente(int IdPaciente);
   }

}