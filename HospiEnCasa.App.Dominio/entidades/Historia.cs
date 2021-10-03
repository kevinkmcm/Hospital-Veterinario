using HospiEnCasa.App.Dominio;
using System;
namespace HospiEnCasa.App.Dominio
{
    public class Historia
    {
        public int Id {get;set;}
        public string Diagnostico {get;set;}
        public string Entrono {get;set;}
        public SugerenciaDecuidado SugerenciaDecuidado {get;set;}
        

        

    }
}
