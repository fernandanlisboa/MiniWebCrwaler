﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniWebCrawler.DAL;

namespace MiniWebCrawler.Migrations
{
    [DbContext(typeof(ReceitaContext))]
    partial class ReceitaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MiniWebCrawler.Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("MiniWebCrawler.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("MiniWebCrawler.Models.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AutorId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Receita");
                });

            modelBuilder.Entity("MiniWebCrawler.Models.Receita", b =>
                {
                    b.HasOne("MiniWebCrawler.Models.Autor", "Autor")
                        .WithMany()
                        .HasForeignKey("AutorId");

                    b.HasOne("MiniWebCrawler.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");
                });
#pragma warning restore 612, 618
        }
    }
}