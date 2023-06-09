﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlataformaDeCurso.Contexto;

#nullable disable

namespace PlataformaDeCurso.Migrations
{
    [DbContext(typeof(AppContexto))]
    [Migration("20230526003730_AlteracaoBanco")]
    partial class AlteracaoBanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PlataformaDeCurso.Model.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("administradors");
                });

            modelBuilder.Entity("PlataformaDeCurso.Model.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("duracao")
                        .HasColumnType("float");

                    b.Property<string>("nomeCurso")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("cursos");
                });

            modelBuilder.Entity("PlataformaDeCurso.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("PlataformaDeCurso.Model.Administrador", b =>
                {
                    b.HasOne("PlataformaDeCurso.Model.Curso", null)
                        .WithMany("Administradors")
                        .HasForeignKey("CursoId");
                });

            modelBuilder.Entity("PlataformaDeCurso.Model.Usuario", b =>
                {
                    b.HasOne("PlataformaDeCurso.Model.Curso", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("CursoId");
                });

            modelBuilder.Entity("PlataformaDeCurso.Model.Curso", b =>
                {
                    b.Navigation("Administradors");

                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
