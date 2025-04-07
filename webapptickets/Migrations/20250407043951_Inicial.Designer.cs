﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPITickets.Database;

#nullable disable

namespace WebAPITickets.Migrations
{
    [DbContext(typeof(ContextoDB))]
    [Migration("20250407043951_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPITickets.Models.Tiquetes", b =>
                {
                    b.Property<int>("ti_identificador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ti_identificador"));

                    b.Property<int?>("Rolesro_identificador")
                        .HasColumnType("int");

                    b.Property<string>("ti_adicionado_por")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ti_asunto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ti_categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ti_estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ti_fecha_adicion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ti_fecha_modificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("ti_importancia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ti_modificado_por")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ti_solucion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ti_urgencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ti_us_id_asigna")
                        .HasColumnType("int");

                    b.HasKey("ti_identificador");

                    b.HasIndex("Rolesro_identificador");

                    b.ToTable("Tiquetes");
                });

            modelBuilder.Entity("WebAPITickets.Models.Usuarios", b =>
                {
                    b.Property<int>("us_identificador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("us_identificador"));

                    b.Property<string>("us_adicionado_por")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("us_clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("us_correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("us_estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("us_fecha_adicion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("us_fecha_modificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("us_modificado_por")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("us_nombre_completo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("us_ro_identificador")
                        .HasColumnType("int");

                    b.HasKey("us_identificador");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("wWebAPITickets.Models.Roles", b =>
                {
                    b.Property<int>("ro_identificador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ro_identificador"));

                    b.Property<string>("ro_adicionado_por")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ro_decripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ro_fecha_adicion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ro_fecha_modificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("ro_modificado_por")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ro_identificador");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebAPITickets.Models.Tiquetes", b =>
                {
                    b.HasOne("wWebAPITickets.Models.Roles", null)
                        .WithMany("tiquetes")
                        .HasForeignKey("Rolesro_identificador");
                });

            modelBuilder.Entity("wWebAPITickets.Models.Roles", b =>
                {
                    b.Navigation("tiquetes");
                });
#pragma warning restore 612, 618
        }
    }
}
