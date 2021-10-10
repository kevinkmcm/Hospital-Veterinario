using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioMedico : IRepositorioMedico
    {
        ///<summary>
        ///Referecia al contexto del paciente
        ///</summary>

        public readonly AppContext _appContext;
         ///<summary>
        ///Metodo constructor utiliza
        ///Inyeccion de dependencia para indicar el contexto a utilizar
        ///</summary>

        ///<param name="appContext"></param>//

        //public RepositorioMedico(AppContext appContext)
        //{
          //  _appContext=_appContext;
        //}
    
       Medico IRepositorioMedico.AddMedico(Medico medico)
        {
            var medicoAdicionado=_appContext.Medicos.Add(medico);
             _appContext.SaveChanges();
             return medicoAdicionado.Entity;

        }

       void  IRepositorioMedico.DeleteMedico(int IdMedico)
        {
            var medicoencontrado= _appContext.Medicos.Find(IdMedico );
            if (medicoencontrado==null)
            return;
            _appContext.Medicos.Remove(medicoencontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Medico> IRepositorioMedico.GetAllMedicos()
        {
            return _appContext.Medicos;

        }

        Medico IRepositorioMedico.GetMedico(int IdMedico)
        {
            return _appContext.Medicos.Find(IdMedico );

        }

        Medico IRepositorioMedico.UpdateMedico(Medico medico)
        {
            var medicoencontrado= _appContext.Medicos.Find(medico.Id );
            if (medicoencontrado!=null)
            {
                medicoencontrado.Id=medico.Id;
                medicoencontrado.Apellidos=medico.Apellidos;
                medicoencontrado.NumeroTelefono=medico.NumeroTelefono;
                medicoencontrado.Genero=medico.Genero;
                medicoencontrado.Especialidad=medico.Especialidad;
                medicoencontrado.Codigo=medico.Codigo;
                medicoencontrado.Registro_Rethus=medico.Registro_Rethus;

               
               

                _appContext.SaveChanges();
                
            }
            return medicoencontrado;

        }

    }

}
