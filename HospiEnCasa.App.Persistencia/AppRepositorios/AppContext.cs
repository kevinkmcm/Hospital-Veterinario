using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Enfermera> Enfermeras { get; set; }
        public DbSet<FamiliarDesignado> Familiar { get; set; }
        public DbSet<Historia> Historias { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<SignoVital> signos { get; set; }
        public DbSet<SugerenciaDecuidado> Sugerencias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospiEnCasatData");
            }
        }
    }
}