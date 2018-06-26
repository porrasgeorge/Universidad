﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Universidad.DbModels;

namespace Universidad.Migrations
{
    [DbContext(typeof(PARCIALDBContext))]
    partial class PARCIALDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Universidad.DbModels.Alumno", b =>
                {
                    b.Property<int>("Idalumno")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDAlumno");

                    b.Property<string>("Apellido1")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Apellido2")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("FechaNacimiento")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Idalumno");

                    b.ToTable("Alumno");
                });

            modelBuilder.Entity("Universidad.DbModels.Materia", b =>
                {
                    b.Property<int>("Idmateria")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDMateria");

                    b.Property<int?>("Estado")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<double>("Precio");

                    b.HasKey("Idmateria");

                    b.ToTable("Materia");
                });

            modelBuilder.Entity("Universidad.DbModels.Matricula", b =>
                {
                    b.Property<int>("Idmatricula")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDMatricula");

                    b.Property<int?>("Idalumno")
                        .IsRequired()
                        .HasColumnName("IDAlumno");

                    b.Property<int?>("Idmateria")
                        .HasColumnName("IDMateria");

                    b.Property<int?>("Idprofesor")
                        .IsRequired()
                        .HasColumnName("IDProfesor");

                    b.Property<double?>("Nota")
                        .IsRequired();

                    b.HasKey("Idmatricula");

                    b.HasIndex("Idalumno");

                    b.HasIndex("Idmateria");

                    b.HasIndex("Idprofesor");

                    b.ToTable("Matricula");
                });

            modelBuilder.Entity("Universidad.DbModels.Profesor", b =>
                {
                    b.Property<int>("Idprofesor")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IDProfesor");

                    b.Property<string>("Apellido1")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Apellido2")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("Estado");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Idprofesor");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("Universidad.DbModels.Matricula", b =>
                {
                    b.HasOne("Universidad.DbModels.Alumno", "IdalumnoNavigation")
                        .WithMany("Matricula")
                        .HasForeignKey("Idalumno")
                        .HasConstraintName("fk_matricula_alumno")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Universidad.DbModels.Materia", "IdmateriaNavigation")
                        .WithMany("Matricula")
                        .HasForeignKey("Idmateria")
                        .HasConstraintName("fk_matricula_materia");

                    b.HasOne("Universidad.DbModels.Profesor", "IdprofesorNavigation")
                        .WithMany("Matricula")
                        .HasForeignKey("Idprofesor")
                        .HasConstraintName("fk_matricula_profesor")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
