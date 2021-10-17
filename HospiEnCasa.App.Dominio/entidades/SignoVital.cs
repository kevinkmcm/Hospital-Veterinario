using HospiEnCasa.App.Dominio;
using System;

namespace HospiEnCasa.App.Dominio
{
    public class SignoVital
    {
    public int Id {get;set;}
    
    public DateTime FechaHora{get;set;}
    
    public TipoSigno Signo {get;set;}
    
    public int Valor {get;set;}  

    public int Pacienteid {get;set;}
    }
}

