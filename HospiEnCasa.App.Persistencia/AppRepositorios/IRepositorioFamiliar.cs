using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
using System;
using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Persistencia;
using System.Linq;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioFamiliar
    {
        IEnumerable<FamiliarDesignado> GetAllFamiliarDesignados();

        FamiliarDesignado AddFamiliarDesignado(FamiliarDesignado familiar);

        FamiliarDesignado UpdateFamiliarDesignado(FamiliarDesignado familiar);

        void DeleteFamiliarDesignado(int IdFamiliarDesignado);

        FamiliarDesignado GetFamiliarDesignado(int IdFamiliarDesignado);
   }

}