﻿// <auto-generated />
using System;
using DevSmash___Projeto_Final;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DevSmash___Projeto_Final.Migrations
{
    [DbContext(typeof(SiteContext))]
    [Migration("20220131222209_recuperacao")]
    partial class recuperacao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("DevSmash___Projeto_Final.Models.Entidades.Adm", b =>
                {
                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("email");

                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("telefone");

                    b.ToTable("adm", (string)null);
                });

            modelBuilder.Entity("DevSmash___Projeto_Final.Models.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("email");

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("clientes", (string)null);
                });

            modelBuilder.Entity("DevSmash___Projeto_Final.Models.Entidades.Integrante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Funcao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("funcao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<string>("RedeSocial")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("redeSocial");

                    b.Property<string>("Sobre")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("sobre");

                    b.HasKey("Id");

                    b.ToTable("integrantes", (string)null);
                });

            modelBuilder.Entity("DevSmash___Projeto_Final.Models.Entidades.Midia", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Alt")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("alt")
                        .HasDefaultValueSql("''");

                    b.Property<string>("Link")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("link")
                        .HasDefaultValueSql("''");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome")
                        .HasDefaultValueSql("''");

                    b.HasKey("Id");

                    b.ToTable("midias", (string)null);
                });

            modelBuilder.Entity("DevSmash___Projeto_Final.Models.Entidades.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Autor")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("autor");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("conteudo");

                    b.Property<DateTime>("Criacao")
                        .HasColumnType("datetime")
                        .HasColumnName("criacao");

                    b.Property<string>("DescricaoFront")
                        .HasColumnType("longtext");

                    b.Property<string>("Imagem")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("titulo");

                    b.HasKey("Id");

                    b.ToTable("posts", (string)null);
                });

            modelBuilder.Entity("DevSmash___Projeto_Final.Models.Entidades.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("descricao");

                    b.Property<string>("DescricaoFront")
                        .HasColumnType("longtext");

                    b.Property<string>("Icone")
                        .HasColumnType("longtext");

                    b.Property<string>("Imagem")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nomeServico");

                    b.Property<int?>("Valor")
                        .HasColumnType("int")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.ToTable("servicos", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
