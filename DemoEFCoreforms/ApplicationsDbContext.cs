using DemoEFCoreforms.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFCoreforms
{
    public class ApplicationsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=apirest;Persist Security Info=True;User ID=sa;password=system")
                .EnableSensitiveDataLogging(true);
            //.UseLoggerFactory(new LoggerFactory().AddConsole((category, level) => level = category));

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var estudiante1 = new Estudiante() { Id = 1, Nombres = "Eistein Dolores" };
            var estudiante2 = new Estudiante() { Id = 2, Nombres = "Jenny Cuya" };
            modelBuilder.Entity<Estudiante>().HasData(new Estudiante[] { estudiante1, estudiante2 });

            modelBuilder.Entity<EstudianteCurso>().HasKey(x => new { x.CursoId, x.EstudianteId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<EstudianteDetalle> EstudianteDetalles { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<EstudianteCurso> EstudianteCursos { get; set; }
    }
}
