using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
using System;
using Microsoft.EntityFrameworkCore;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioMedico
    {
        IEnumerable<Medico> GetAllMedicos();

        Medico AddMedico(Medico medico);

        Medico UpdateMedico(Medico medico);

        void DeleteMedico(int IdMedico);

        Medico GetMedico(int IdMedico);
   }

}