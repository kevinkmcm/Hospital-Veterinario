 using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioFamiliar : IRepositorioFamiliar
    {
        ///<summary>
        ///Referecia al contexto del paciente
        ///</summary>

        private readonly AppContext _appContext;
         ///<summary>
        ///Metodo constructor utiliza
        ///Inyeccion de dependencia para indicar el contexto a utilizar
        ///</summary>

        ///<param name="appContext"></param>//

        public RepositorioFamiliar(AppContext appContext)
        {
            _appContext=_appContext;
        }
    
       familiar IRepositorioFamiliar.AddFamiliar(Familiar familiar)
        {
            var familiarAdicionado=_appContext.familiar.Add(familiar);
             _appContext.SaveChanges();
             return familiarAdicionado.Entity;

        }

       void  IRepositorioFamiliar.DeleteFamiliarDesignado(int IdMedico)
        {
            var familiarencontrado= _appContext.familiar.FirstOrDefault(p => p.Id==IdFamiliarDesignado );
            if (familiarencontrado==null)
            return;
            _appContext.FamiliarDesignado.Remove(familiarencontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<FamiliarDesignado> IRepositorioFamiliar.GetAllFamiliarDesignados()
        {
            return _appContext.familiar;

        }

        Familiar IRepositorioFamiliar.GetFamiliarDesignado(int IdFamiliarDesignado)
        {
            return _appContext.Familiar.FirstOrDefault(p => p.Id==IdFamiliarDesignado );

        }

        Paciente IRepositorioFamiliar.UpdateFamiliarDesignado(Familiar familiar)
        {
            var familiarencontrado= _appContext.familiar.FirstOrDefault(p => p.Id==familiar.Id );
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