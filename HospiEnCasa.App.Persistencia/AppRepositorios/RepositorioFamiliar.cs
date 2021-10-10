using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioFamiliar : IRepositorioFamiliar
    {
        ///<summary>
        ///Referecia al contexto del paciente
        ///</summary>

        public readonly AppContext _appContext= new AppContext();
         ///<summary>
        ///Metodo constructor utiliza
        ///Inyeccion de dependencia para indicar el contexto a utilizar
        ///</summary>

        ///<param name="appContext"></param>//

        //public RepositorioFamiliar(AppContext appContext)
        //{
          //  this._appContext=_appContext;
        //}
    
       FamiliarDesignado IRepositorioFamiliar.AddFamiliarDesignado(FamiliarDesignado familiar)
        {
            var familiarAdicionado=_appContext.Familiar.Add(familiar);
             _appContext.SaveChanges();
             return familiarAdicionado.Entity;

        }

       void  IRepositorioFamiliar.DeleteFamiliarDesignado(int IdFamiliarDesignado)
        {
            var familiarencontrado= _appContext.Familiar.Find(IdFamiliarDesignado );
            if (familiarencontrado==null)
            return;
            _appContext.Familiar.Remove(familiarencontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<FamiliarDesignado> IRepositorioFamiliar.GetAllFamiliarDesignados()
        {
            return _appContext.Familiar;

        }

        FamiliarDesignado IRepositorioFamiliar.GetFamiliarDesignado(int IdFamiliarDesignado)
        {
            return _appContext.Familiar.Find(IdFamiliarDesignado );

        }

        FamiliarDesignado IRepositorioFamiliar.UpdateFamiliarDesignado(FamiliarDesignado familiar)
        {
            var familiarencontrado= _appContext.Familiar.Find(familiar.Id );
            if (familiarencontrado!=null)
            {
                familiarencontrado.Id=familiar.Id; 
                familiarencontrado.Nombre=familiar.Nombre;
                familiarencontrado.Apellidos=familiar.Apellidos;
                familiarencontrado.NumeroTelefono=familiar.NumeroTelefono;
                familiarencontrado.Genero=familiar.Genero;
                familiarencontrado.Prentesco=familiar.Prentesco;
                familiarencontrado.Correo=familiar.Correo;
                

               
               

                _appContext.SaveChanges();
                
            }
            return familiarencontrado;

        }

    }

}