﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Wikiclass.Data;

#nullable disable

namespace Wikiclass.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220915144957_lol")]
    partial class lol
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Wikiclass.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Año")
                        .HasColumnType("integer");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Plataforma")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("TagId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.ToTable("categoria");
                });

            modelBuilder.Entity("Wikiclass.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("PostId")
                        .HasColumnType("integer");

                    b.Property<int>("categoriaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("categoriaId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Wikiclass.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Idcategoria")
                        .HasColumnType("integer");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("Wikiclass.Models.Categoria", b =>
                {
                    b.HasOne("Wikiclass.Models.Tag", null)
                        .WithMany("categoria")
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("Wikiclass.Models.Post", b =>
                {
                    b.HasOne("Wikiclass.Models.Post", null)
                        .WithMany("Posts")
                        .HasForeignKey("PostId");

                    b.HasOne("Wikiclass.Models.Categoria", "categoria")
                        .WithMany()
                        .HasForeignKey("categoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoria");
                });

            modelBuilder.Entity("Wikiclass.Models.Post", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Wikiclass.Models.Tag", b =>
                {
                    b.Navigation("categoria");
                });
#pragma warning restore 612, 618
        }
    }
}
