﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trabajo.Models;

namespace Trabajo.Migrations
{
    [DbContext(typeof(TrabajoContext))]
    [Migration("20181114221031_eventos")]
    partial class eventos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Trabajo.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Codigo");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Alumnos");

                    b.HasData(
                        new { Id = 1, Codigo = 1811586, Nombre = "Andres Frias", Password = "666" },
                        new { Id = 2, Codigo = 123443, Nombre = "Denis castillo", Password = "999" }
                    );
                });

            modelBuilder.Entity("Trabajo.Models.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Foto");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Eventos");

                    b.HasData(
                        new { Id = 1, Descripcion = "Ayudar a recibir alimentos y bebidas y empaquetarlas para ser llevadas a puno", Direccion = "Av Los frutales 666 La molina", Fecha = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Foto = "https://api.netnoticias.mx/im/2017/09/10/770x490-tMlnQSNblV09w.JPG", Nombre = "Trabajo comunitario" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}