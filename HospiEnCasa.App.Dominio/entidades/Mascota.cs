using HospiEnCasa.App.Dominio;
using System;
namespace HospiEnCasa.App.Dominio
{
    public class Mascota
    {
        public int Id {get;set;}
        public string Raza {get;set;}

        public Tipo Tipo {get;set;}
       
        public int Edad {get;set;}
       
        public string Color{get;set;}
       
        public Pedigree Pedigree {get;set;}

        public string Nombre {get;set;}
    

    }
}
