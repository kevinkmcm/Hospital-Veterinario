using System;
using HospiEnCasa.App.Dominio;
using System.Collections.Generic;

namespace HospiEnCasa.App.Dominio
{
    public class Paciente:Mascota
    {
        public string Direccion {get;set;}
        public int Latitud {get;set;}
        public int Longitud {get;set;}
        public string Ciudad {get;set;}
        public DateTime Fecha_Nacimiento {get;set;}
        public FamiliarDesignado FamiliarDesignado {get;set;}
        public List<SignoVital> SignoVital {get;set;}
        public Historia Historia {get;set;}
        public Medico Medico {get;set;}

    }
}
