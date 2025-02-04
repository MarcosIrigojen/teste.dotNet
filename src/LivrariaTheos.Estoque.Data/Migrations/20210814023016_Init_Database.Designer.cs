﻿// <auto-generated />
using System;
using LivrariaTheos.Estoque.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LivrariaTheos.Estoque.Data.Migrations
{
    [DbContext(typeof(EstoqueContext))]
    [Migration("20210814023016_Init_Database")]
    partial class Init_Database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LivrariaTheos.Estoque.Domain.Autores.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("InformacoesRelevantes")
                        .HasColumnType("varchar(2000)");

                    b.Property<int>("Nacionalidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UsuarioInclusao")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Autor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified),
                            InformacoesRelevantes = "Informações sobre o autor",
                            Nacionalidade = 3,
                            Nome = "Stephen King",
                            UsuarioInclusao = "Seed"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified),
                            InformacoesRelevantes = "Informações sobre o autor",
                            Nacionalidade = 1,
                            Nome = "Paulo Coelho",
                            UsuarioInclusao = "Seed"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified),
                            InformacoesRelevantes = "Informações sobre o autor",
                            Nacionalidade = 6,
                            Nome = "Akira Toryama",
                            UsuarioInclusao = "Seed"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified),
                            InformacoesRelevantes = "Informações sobre o autor",
                            Nacionalidade = 5,
                            Nome = "Thomas Mann",
                            UsuarioInclusao = "Seed"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified),
                            InformacoesRelevantes = "Informações sobre o autor",
                            Nacionalidade = 4,
                            Nome = "J.K Rowling",
                            UsuarioInclusao = "Seed"
                        });
                });

            modelBuilder.Entity("LivrariaTheos.Estoque.Domain.Generos.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UsuarioInclusao")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Genero");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified),
                            Nome = "Drama",
                            UsuarioInclusao = "Seed"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified),
                            Nome = "Mistério/Suspense",
                            UsuarioInclusao = "Seed"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified),
                            Nome = "Romance",
                            UsuarioInclusao = "Seed"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified),
                            Nome = "Épico/Aventura",
                            UsuarioInclusao = "Seed"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified),
                            Nome = "Distopia",
                            UsuarioInclusao = "Seed"
                        },
                        new
                        {
                            Id = 6,
                            Ativo = true,
                            DataInclusao = new DateTime(2021, 1, 1, 1, 1, 1, 0, DateTimeKind.Unspecified),
                            Nome = "Fantasia/Sobrenatural",
                            UsuarioInclusao = "Seed"
                        });
                });

            modelBuilder.Entity("LivrariaTheos.Estoque.Domain.Livros.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<string>("CaminhoCapa")
                        .HasColumnType("varchar(350)");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime2");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<int>("QuantidadePaginas")
                        .HasColumnType("int");

                    b.Property<string>("Sinopse")
                        .IsRequired()
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UsuarioInclusao")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("LivrariaTheos.Estoque.Domain.Livros.Livro", b =>
                {
                    b.HasOne("LivrariaTheos.Estoque.Domain.Autores.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LivrariaTheos.Estoque.Domain.Generos.Genero", "Genero")
                        .WithMany("Livros")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("LivrariaTheos.Estoque.Domain.Autores.Autor", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("LivrariaTheos.Estoque.Domain.Generos.Genero", b =>
                {
                    b.Navigation("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}
