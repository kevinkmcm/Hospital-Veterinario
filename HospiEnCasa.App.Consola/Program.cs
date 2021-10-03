using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        
        private static IRepositorioPaciente _repoPaciente= new RepositorioPaciente(new Persistencia.AppContext()); 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity framework!");
            AddPaciente();
           //BuscarPaciente(1);
        }

        
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre= "firulais",
                Direccion= "calle 13 ",
                Longitud= 5,
                Latitud= -7,
                Ciudad="cali",
               // FechaNacimiento= new DateTime(2000,01,12)



            };
            _repoPaciente.AddPaciente(paciente);
        }

        /*private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Consola.WriteLine(paciente.Nombre+" "+paciente.ciudad);
        }*/
    }
}
