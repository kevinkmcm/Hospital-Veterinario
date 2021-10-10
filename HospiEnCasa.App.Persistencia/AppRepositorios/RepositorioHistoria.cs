using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        ///<summary>
        ///Referecia al contexto del Historia
        ///</summary>

        public readonly AppContext _appContext= new AppContext();
         ///<summary>
        ///Metodo constructor utiliza
        ///Inyeccion de dependencia para indicar el contexto a utilizar
        ///</summary>

        ///<param name="appContext"></param>//

       // public RepositorioHistoria(AppContext _appContext)
        //{
          //  this._appContext=_appContext;
        //}
    
       Historia IRepositorioHistoria.AddHistoria(Historia Historia)
        {
            var HistoriaAdicionado=_appContext.Historias.Add(Historia);
             _appContext.SaveChanges();
             return HistoriaAdicionado.Entity;

        }

       void  IRepositorioHistoria.DeleteHistoria(int IdHistoria)
        {
            var HistoriaEncontrado= _appContext.Historias.Find(IdHistoria );
            if (HistoriaEncontrado==null)
            return;
            _appContext.Historias.Remove(HistoriaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Historia> IRepositorioHistoria.GetAllHistorias()
        {
            return _appContext.Historias;

        }

        Historia IRepositorioHistoria.GetHistoria(int IdHistoria)
        {
            return _appContext.Historias.Find(IdHistoria );

        }

        Historia IRepositorioHistoria.UpdateHistoria(Historia Historia)
        {
            var HistoriaEncontrado= _appContext.Historias.Find(Historia.Id );
            if (HistoriaEncontrado!=null)
            {
                HistoriaEncontrado.Id=Historia.Id;
                HistoriaEncontrado.Diagnostico=Historia.Diagnostico;
                
                
               

                _appContext.SaveChanges();
                
            }
            return HistoriaEncontrado;

        }

        

    }

}