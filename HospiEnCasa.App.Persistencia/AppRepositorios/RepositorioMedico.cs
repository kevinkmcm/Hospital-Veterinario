 using System.Collections.Generic;
using System.Linq;
using HospiEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioMedico : IRepositorioMedico
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

        public RepositorioMedico(AppContext appContext)
        {
            _appContext=_appContext;
        }
    
       Paciente IRepositorioMedico.AddMedico(Medico medico)
        {
            var medicoAdicionado=_appContext.medico.Add(medico);
             _appContext.SaveChanges();
             return medicoAdicionado.Entity;

        }

       void  IRepositorioMedico.DeleteMedico(int IdMedico)
        {
            var medicoencontrado= _appContext.Medico.FirstOrDefault(p => p.Id==IdMedico );
            if (medicoencontrado==null)
            return;
            _appContext.Medico.Remove(medicoencontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Medico> IRepositorioMedico.GetAllMedicos()
        {
            return _appContext.Medicos;

        }

        Paciente IRepositorioMedico.GetMedico(int IdMedico)
        {
            return _appContext.Medicos.FirstOrDefault(p => p.Id==IdMedico );

        }

        Paciente IRepositorioMedico.UpdateMedico(Medico medico)
        {
            var medicoencontrado= _appContext.Medicos.FirstOrDefault(p => p.Id==medico.Id );
            if (medicoencontrado!=null)
            {
                medicoencontrado.Id=medico.Id; 
                medicoencontrado.Edad=medico.Nombre;
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
