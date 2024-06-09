﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial_2.Dal.Data;

#nullable disable

namespace Parcial_2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240609004316_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Parcial_2.Dal.Entities.Cancion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DiscoId")
                        .HasColumnType("int");

                    b.Property<int>("TiempoDuracion")
                        .HasColumnType("int");

                    b.Property<string>("TituloCancion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DiscoId");

                    b.ToTable("Canciones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiscoId = 1,
                            TiempoDuracion = 123,
                            TituloCancion = "Test"
                        },
                        new
                        {
                            Id = 2,
                            DiscoId = 2,
                            TiempoDuracion = 321,
                            TituloCancion = "Test2"
                        });
                });

            modelBuilder.Entity("Parcial_2.Dal.Entities.Disco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Banda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaLanzamiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnidadesVendidas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Discos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Banda = "Test",
                            FechaLanzamiento = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = "Test",
                            Nombre = "Test",
                            SKU = "Test",
                            UnidadesVendidas = 1
                        },
                        new
                        {
                            Id = 2,
                            Banda = "Test2",
                            FechaLanzamiento = new DateTime(1999, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = "Test2",
                            Nombre = "Test2",
                            SKU = "Test2",
                            UnidadesVendidas = 2
                        });
                });

            modelBuilder.Entity("Parcial_2.Dal.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Test@Test.com",
                            Name = "Test",
                            Password = "Test",
                            UserName = "Test"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Test2@Test2.com",
                            Name = "Test2",
                            Password = "Test2",
                            UserName = "Test2"
                        });
                });

            modelBuilder.Entity("Parcial_2.Dal.Entities.Cancion", b =>
                {
                    b.HasOne("Parcial_2.Dal.Entities.Disco", "Disco")
                        .WithMany("Canciones")
                        .HasForeignKey("DiscoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disco");
                });

            modelBuilder.Entity("Parcial_2.Dal.Entities.Disco", b =>
                {
                    b.Navigation("Canciones");
                });
#pragma warning restore 612, 618
        }
    }
}
