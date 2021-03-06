using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
using System;
using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Persistencia;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioMedico
    {
        IEnumerable<Medico> GetAllMedicos();

        Medico AddMedico(Medico medic);

        Medico UpdateMedico(Medico medic);

        void DeleteMedico(int IdMedico);

        Medico GetMedico(int IdMedico);
   }

}