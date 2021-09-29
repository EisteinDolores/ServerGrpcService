﻿// <auto-generated />
using System;
using DemoEFCoreforms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoEFCoreforms.Migrations
{
    [DbContext(typeof(ApplicationsDbContext))]
    [Migration("20210928180053_EstudianteCursos")]
    partial class EstudianteCursos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoEFCoreforms.Models.Contacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Contactos");
                });

            modelBuilder.Entity("DemoEFCoreforms.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("DemoEFCoreforms.Models.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApeMaterno");

                    b.Property<string>("ApePaterno");

                    b.Property<int?>("DetalleId");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nombres");

                    b.HasKey("Id");

                    b.HasIndex("DetalleId");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("DemoEFCoreforms.Models.EstudianteCurso", b =>
                {
                    b.Property<int>("CursoId");

                    b.Property<int>("EstudianteId");

                    b.HasKey("CursoId", "EstudianteId");

                    b.HasIndex("EstudianteId");

                    b.ToTable("EstudianteCursos");
                });

            modelBuilder.Entity("DemoEFCoreforms.Models.EstudianteDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("EstudianteDetalles");
                });

            modelBuilder.Entity("DemoEFCoreforms.Models.Estudiante", b =>
                {
                    b.HasOne("DemoEFCoreforms.Models.EstudianteDetalle", "Detalle")
                        .WithMany()
                        .HasForeignKey("DetalleId");
                });

            modelBuilder.Entity("DemoEFCoreforms.Models.EstudianteCurso", b =>
                {
                    b.HasOne("DemoEFCoreforms.Models.Curso", "Curso")
                        .WithMany("EstudianteCursos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoEFCoreforms.Models.Estudiante", "Estudiante")
                        .WithMany("EstudianteCursos")
                        .HasForeignKey("EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
