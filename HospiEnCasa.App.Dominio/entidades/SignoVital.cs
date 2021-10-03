using HospiEnCasa.App.Dominio;
using System;
namespace HospiEnCasa.App.Dominio
{
    public class SignoVital
    {
     public int Id {get;set;}
    
     public FechaHora FechaHora{get;set;}
    
     public TipoSigno Signo {get;set;}
    
     public int Valor {get;set;}    

    }
}

