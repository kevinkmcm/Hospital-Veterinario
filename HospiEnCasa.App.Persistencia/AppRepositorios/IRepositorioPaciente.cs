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

        //________________________________________________________________
        //repositorio signos 
        //metodo para optener todos los signos en lista  
        IEnumerable<SignoVital> GetAllSigno();

        //metodo para adicionar el signo 
        SignoVital AddSigno(int IdPaciente, SignoVital Signo);

        //metodo para actualizar el Paciente 
        SignoVital UpdateSigno(SignoVital Signo);

        //metodo para eliminar el Paciente 
        void DeleteSigno(int IdSignoVital);

        // metodo para consultar el Paciente 
        SignoVital GetSigno(int IdSignoVital);

        //________________________________________________________________

        //repositorio Historia
        IEnumerable<Historia> GetAllHistorias();

        Historia AddHistoria(int IdPaciente, Historia Historia, SugerenciaDecuidado sugerencia);

        Historia UpdateHistoria(Historia Historia);

        void DeleteHistoria(int IdHistoria);

        Historia GetHistoria(int IdHistoria);

        //________________________________________________________________________
        //repositorio sugrenecias de cuidado 

        IEnumerable<SugerenciaDecuidado> GetAllSugerencia();

        SugerenciaDecuidado AddSugerencia(int IdPaciente, SugerenciaDecuidado  sugerencia);

        SugerenciaDecuidado UpdateSugerencia(SugerenciaDecuidado sugerencia);

        void DeleteSugerencia(int IdSugerenciaDecuidado);

        SugerenciaDecuidado GetSugerencia(int IdSugerenciaDecuidado);


    }

}