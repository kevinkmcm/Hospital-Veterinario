 using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        ///<summary>
        ///Referecia al contexto del paciente
        ///</summary>

        private readonly AppContext _appContext= new AppContext();
         ///<summary>
        ///Metodo constructor utiliza
        ///Inyeccion de dependencia para indicar el contexto a utilizar
        ///</summary>

        ///<param name="appContext"></param>//

        public RepositorioPaciente(AppContext appContext)
        {
            _appContext=_appContext;
        }
    
       Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado=_appContext.Pacientes.Add(paciente);
             _appContext.SaveChanges();
             return pacienteAdicionado.Entity;

        }

       void  IRepositorioPaciente.DeletePaciente(int IdPaciente)
        {
            var pacienteEncontrado= _appContext.Pacientes.FirstOrDefault(p => p.Id==IdPaciente );
            if (pacienteEncontrado==null)
            return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;

        }

        Paciente IRepositorioPaciente.GetPaciente(int IdPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id==IdPaciente );

        }

        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado= _appContext.Pacientes.FirstOrDefault(p => p.Id==paciente.Id );
            if (pacienteEncontrado!=null)
            {
                pacienteEncontrado.Nombre=paciente.Nombre;
                pacienteEncontrado.Raza=paciente.Raza;
                pacienteEncontrado.Tipo=paciente.Tipo;
                pacienteEncontrado.Edad=paciente.Edad;
                pacienteEncontrado.Color=paciente.Color;
                pacienteEncontrado.Pedigree=paciente.Pedigree;
                pacienteEncontrado.Direccion=paciente.Direccion;
                pacienteEncontrado.Latitud=paciente.Latitud;
                pacienteEncontrado.Longitud=paciente.Longitud;
                pacienteEncontrado.Ciudad=paciente.Ciudad;
               // pacienteEncontrado.Fecha_Nacimiento=paciente.Fecha_Nacimiento;
                pacienteEncontrado.Historia=paciente.Historia;

                _appContext.SaveChanges();
                
            }
            return pacienteEncontrado;

        }

    }

}
