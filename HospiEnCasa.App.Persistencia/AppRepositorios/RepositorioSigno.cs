using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using HospiEnCasa.App.Persistencia;

/*namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioSigno : IRepositorioSigno
    {
        ///<summary>
        ///Referecia al contexto del paciente
        ///</summary>

        private readonly AppContext _appContext = new AppContext();
        ///<summary>
        ///Metodo constructor utiliza
        ///Inyeccion de dependencia para indicar el contexto a utilizar
        ///</summary>

        ///<param name="appContext"></param>//

        //public RepositorioPaciente(AppContext _appContext)
        //{
        //this._appContext=_appContext;
        //}

        SignoVital IRepositorioSigno.AddSigno(SignoVital Signo)        {
            var SignoAdicionado = _appContext.signos.Add(Signo);
            _appContext.SaveChanges();
            return SignoAdicionado.Entity;

        }

        void IRepositorioSigno.DeleteSigno(int IdSignoVital)
        {
            var SignoEncontrado = _appContext.signos.Find(IdSignoVital);
            if (SignoEncontrado == null)
                return;
            _appContext.signos.Remove(SignoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<SignoVital> IRepositorioSigno.GetAllSigno()
        {
            return _appContext.signos;

        }

        SignoVital IRepositorioSigno.GetSigno(int IdSignoVital)
        {
            return _appContext.signos.Find(IdSignoVital);

        }

        SignoVital IRepositorioSigno.UpdateSigno(SignoVital Signo)
        {
            var SignoEncontrado = _appContext.signos.Find(Signo.Id);
            if (SignoEncontrado != null)
            {
                SignoEncontrado.FechaHora= Signo.FechaHora;
                SignoEncontrado.Signo = Signo.Signo;
                SignoEncontrado.Valor = Signo.Valor;
                SignoEncontrado.Pacienteid = Signo.Pacienteid;




                _appContext.SaveChanges();

            }
            return SignoEncontrado;

        }



    }

}*/
