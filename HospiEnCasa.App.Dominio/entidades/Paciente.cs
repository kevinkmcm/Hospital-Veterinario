using System;
using HospiEnCasa.App.Dominio;
namespace HospiEnCasa.app.Dominio
{
    public class Paciente:Mascota
    {
        public string Direccion {get;set;}
        public int Latitud {get;set;}
        public int Longitud {get;set;}
        public string Ciudad {get;set;}
        public DateTime Fecha_Nacimiento {get;set;}
        public FamiliarDesignado FamiliarDesignado {get;set;}
        public SignoVital SignoVital {get;set;}
        public Historia Historia {get;set;}
        public Enfermera Enfermera {get;set;}

    }
}
