using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;
using System.Linq;


namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        //metodo para optener todos los Pacientes en lista  
        IEnumerable <Paciente> GetAllPacientes();

        //metodo para adicionar el Paciente 
        Paciente AddPaciente(Paciente paciente);
        
        //metodo para actualizar el Paciente 
        Paciente UpdatePaciente(Paciente paciente);
        
        //metodo para eliminar el Paciente 
        void DeletePaciente(int IdPaciente);
        
        // metodo para consultar el Paciente 
        Paciente GetPaciente(int IdPaciente);

       
   }

}