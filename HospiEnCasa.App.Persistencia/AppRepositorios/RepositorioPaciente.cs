using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using HospiEnCasa.App.Persistencia;

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

        //public RepositorioPaciente(AppContext _appContext)
        //{
          //this._appContext=_appContext;
        //}
    
       Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado=_appContext.Pacientes.Add(paciente);
             _appContext.SaveChanges();
             return pacienteAdicionado.Entity;

        }

       void  IRepositorioPaciente.DeletePaciente(int IdPaciente)
        {
            var pacienteEncontrado= _appContext.Pacientes.Find(IdPaciente);
             if (pacienteEncontrado==null)
            return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable <Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;

        }

        Paciente IRepositorioPaciente.GetPaciente(int Id)
        {
            return _appContext.Pacientes.Find(Id);

        }

        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado= _appContext.Pacientes.Find(paciente.Id );
            if (pacienteEncontrado!=null)
            {
                pacienteEncontrado.Nombre=paciente.Nombre;
                pacienteEncontrado.Raza=paciente.Raza;
                pacienteEncontrado.Tipo=paciente.Tipo;
                pacienteEncontrado.Edad=paciente.Edad;
                pacienteEncontrado.Color=paciente.Color;
                pacienteEncontrado.PedigreeEnum=paciente.PedigreeEnum;
                pacienteEncontrado.Direccion=paciente.Direccion;
                pacienteEncontrado.Latitud=paciente.Latitud;
                pacienteEncontrado.Longitud=paciente.Longitud;
                pacienteEncontrado.Ciudad=paciente.Ciudad;
                pacienteEncontrado.Fecha_Nacimiento=paciente.Fecha_Nacimiento;
                

                _appContext.SaveChanges();
                
            }
            return pacienteEncontrado;

        }
        //__________________________________________________________________
        //REPOSITORIO SIGNOS VITALES
        SignoVital IRepositorioPaciente.AddSigno(int IdPaciente, SignoVital Signo)
        {
            var SignoAdicionado = _appContext.signos.Add(Signo);
            _appContext.SaveChanges();
            return SignoAdicionado.Entity;

        }

        void IRepositorioPaciente.DeleteSigno(int IdSignoVital)
        {
            var SignoEncontrado = _appContext.signos.Find(IdSignoVital);
            if (SignoEncontrado == null)
                return;
            _appContext.signos.Remove(SignoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<SignoVital> IRepositorioPaciente.GetAllSigno()
        {
            return _appContext.signos;

        }

        SignoVital IRepositorioPaciente.GetSigno(int IdSignoVital)
        {
            return _appContext.signos.Find(IdSignoVital);

        }

        SignoVital IRepositorioPaciente.UpdateSigno(SignoVital Signo)
        {
            var SignoEncontrado = _appContext.signos.Find(Signo.Id);
            if (SignoEncontrado != null)
            {
                SignoEncontrado.FechaHora = Signo.FechaHora;
                SignoEncontrado.Signo = Signo.Signo;
                SignoEncontrado.Valor = Signo.Valor;
                SignoEncontrado.Pacienteid = Signo.Pacienteid;




                _appContext.SaveChanges();

            }
            return SignoEncontrado;

        }

        //__________________________________________________________________
        //REPOSITORIOS HISTORIAL
        Historia IRepositorioPaciente.AddHistoria(int IdPaciente, Historia Historia, SugerenciaDecuidado sugerencia)
        {
            var HistoriaAdicionado = _appContext.Historias.Add(Historia);
            _appContext.SaveChanges();
            return HistoriaAdicionado.Entity;

        }

        void IRepositorioPaciente.DeleteHistoria(int IdHistoria)
        {
            var HistoriaEncontrado = _appContext.Historias.Find(IdHistoria);
            if (HistoriaEncontrado == null)
                return;
            _appContext.Historias.Remove(HistoriaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Historia> IRepositorioPaciente.GetAllHistorias()
        {
            return _appContext.Historias;

        }

        Historia IRepositorioPaciente.GetHistoria(int IdHistoria)
        {
            return _appContext.Historias.Find(IdHistoria);

        }

        Historia IRepositorioPaciente.UpdateHistoria(Historia Historia)
        {
            var HistoriaEncontrado = _appContext.Historias.Find(Historia.Id);
            if (HistoriaEncontrado != null)
            {
                HistoriaEncontrado.Id = Historia.Id;
                HistoriaEncontrado.Diagnostico = Historia.Diagnostico;




                _appContext.SaveChanges();

            }
            return HistoriaEncontrado;

        }

        //_________________________________________________________________________________
        //REPOSITORIO SUGERENCIAS DE CUIDADO

        SugerenciaDecuidado IRepositorioPaciente.AddSugerencia(int IdPaciente, SugerenciaDecuidado sugerencia)
        {
            var SugerenciaEncontrado = _appContext.Sugerencias.Add(sugerencia);
            _appContext.SaveChanges();
            return SugerenciaEncontrado.Entity;

        }

        void IRepositorioPaciente.DeleteSugerencia(int IdSugerenciaDecuidado)
        {
            var SugerenciaEncontrado = _appContext.Sugerencias.Find(IdSugerenciaDecuidado);
            if (SugerenciaEncontrado == null)
                return;
            _appContext.Sugerencias.Remove(SugerenciaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<SugerenciaDecuidado> IRepositorioPaciente.GetAllSugerencia()
        {
            return _appContext.Sugerencias;

        }

        SugerenciaDecuidado IRepositorioPaciente.GetSugerencia(int IdSugerenciaDecuidado)            {
            return _appContext.Sugerencias.Find(IdSugerenciaDecuidado);

        }

        SugerenciaDecuidado IRepositorioPaciente.UpdateSugerencia(SugerenciaDecuidado sugerencia)
        {
            var SugerenciaEncontrado = _appContext.Sugerencias.Find(sugerencia.Id);
            if (SugerenciaEncontrado != null)
            {
                SugerenciaEncontrado.Id = sugerencia.Id;
                SugerenciaEncontrado.FechaHora = sugerencia.FechaHora;
                SugerenciaEncontrado.Descripcion = sugerencia.Descripcion;




                _appContext.SaveChanges();

            }
            return SugerenciaEncontrado;

        }



    }

}
