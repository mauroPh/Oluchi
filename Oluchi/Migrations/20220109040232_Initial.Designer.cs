﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oluchi.Models;

namespace Oluchi.Migrations
{
    [DbContext(typeof(OluchiContext))]
    [Migration("20220109040232_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Oluchi.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArtistaId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Local");

                    b.Property<int>("QtdDiasApresentacao");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ArtistaId");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("Oluchi.Models.Artista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(11);

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("CategoriaId");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Artista");
                });

            modelBuilder.Entity("Oluchi.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataExposicao");

                    b.Property<string>("Descricao");

                    b.Property<string>("NomeCategoria");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Oluchi.Models.Agenda", b =>
                {
                    b.HasOne("Oluchi.Models.Artista", "Artista")
                        .WithMany("QtdDiasApresentacao")
                        .HasForeignKey("ArtistaId");
                });

            modelBuilder.Entity("Oluchi.Models.Artista", b =>
                {
                    b.HasOne("Oluchi.Models.Categoria", "Categoria")
                        .WithMany("Artistas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
