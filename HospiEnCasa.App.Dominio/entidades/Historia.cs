using HospiEnCasa.App.Dominio;
using System;
using System.Collections.Generic;

namespace HospiEnCasa.App.Dominio
{
    public class Historia
    {
        public int Id {get;set;}
        public string Diagnostico {get;set;}
        public List<SugerenciaDecuidado> Sugerenciadecuidado {get;set;}
    }
}
