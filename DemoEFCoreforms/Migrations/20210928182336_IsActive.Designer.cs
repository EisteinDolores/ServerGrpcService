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
    [Migration("20210928182336_IsActive")]
    partial class IsActive
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

                    b.HasData(
                        new { Id = 1, FechaNacimiento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Nombres = "Eistein Dolores" },
                        new { Id = 2, FechaNacimiento = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Nombres = "Jenny Cuya" }
                    );
                });

            modelBuilder.Entity("DemoEFCoreforms.Models.EstudianteCurso", b =>
                {
                    b.Property<int>("CursoId");

                    b.Property<int>("EstudianteId");

                    b.Property<bool>("IsActivie");

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