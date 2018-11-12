﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trabajo.Models;

namespace Trabajo.Migrations
{
    [DbContext(typeof(ReadyToEatContext))]
    [Migration("20181112160549_Conexiones")]
    partial class Conexiones
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Trabajo.Models.Entidades.Platillo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Imagen")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("Precio");

                    b.Property<int>("regId");

                    b.HasKey("Id");

                    b.HasIndex("regId");

                    b.ToTable("RegistroMenus");
                });

            modelBuilder.Entity("Trabajo.Models.InicioR", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contraseña")
                        .IsRequired();

                    b.Property<string>("Usuario")
                        .IsRequired();

                    b.Property<int>("regId");

                    b.HasKey("Id");

                    b.HasIndex("regId")
                        .IsUnique();

                    b.ToTable("InicioR");
                });

            modelBuilder.Entity("Trabajo.Models.Restaurante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RUC")
                        .IsRequired();

                    b.Property<string>("apellido")
                        .IsRequired();

                    b.Property<string>("confirm_password")
                        .IsRequired();

                    b.Property<string>("descripcion");

                    b.Property<string>("direccion")
                        .IsRequired();

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("foto")
                        .IsRequired();

                    b.Property<string>("nombre")
                        .IsRequired();

                    b.Property<string>("nombreTienda")
                        .IsRequired();

                    b.Property<int>("telefono");

                    b.HasKey("Id");

                    b.ToTable("Restaurante");
                });

            modelBuilder.Entity("Trabajo.Models.Entidades.Platillo", b =>
                {
                    b.HasOne("Trabajo.Models.Restaurante", "reg")
                        .WithMany("Menu")
                        .HasForeignKey("regId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Trabajo.Models.InicioR", b =>
                {
                    b.HasOne("Trabajo.Models.Restaurante", "reg")
                        .WithOne("ini")
                        .HasForeignKey("Trabajo.Models.InicioR", "regId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}