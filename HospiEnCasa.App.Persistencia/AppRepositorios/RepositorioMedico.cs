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

        private readonly AppContext _appContext= new AppContext();
         ///<summary>
        ///Metodo constructor utiliza
        ///Inyeccion de dependencia para indicar el contexto a utilizar
        ///</summary>

        ///<param name="appContext"></param>//

        //public RepositorioMedico(AppContext appContext)
        //{
          //this._appContext=_appContext;
        //}
    
       Medico IRepositorioMedico.AddMedico(Medico medic)
        {
            var medicoAdicionado=_appContext.Medicos.Add(medic);
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

        Medico IRepositorioMedico.UpdateMedico(Medico medic)
        {
            var medicoencontrado= _appContext.Medicos.Find(medic.Id );
            if (medicoencontrado!=null)
            {
                medicoencontrado.Id=medic.Id;
                medicoencontrado.Apellidos=medic.Apellidos;
                medicoencontrado.NumeroTelefono=medic.NumeroTelefono;
                medicoencontrado.Genero=medic.Genero;
                medicoencontrado.Especialidad=medic.Especialidad;
                medicoencontrado.Codigo=medic.Codigo;
                medicoencontrado.Registro_Rethus=medic.Registro_Rethus;

               
               

                _appContext.SaveChanges();
                
            }
            return medicoencontrado;

        }

    }

}
