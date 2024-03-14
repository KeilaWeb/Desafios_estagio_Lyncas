﻿// <auto-generated />
using System;
using Dominio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dominio.Migrations
{
    [DbContext(typeof(AplicacaoDbContext))]
    [Migration("20240311175517_SEgunda")]
    partial class SEgunda
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dominio.Models.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deletado")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Dominio.Models.Entities.ItemVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DescricaoItem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PrecoUnitario")
                        .HasColumnType("real");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<float>("ValorTotal")
                        .HasColumnType("real");

                    b.Property<int>("VendaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Dominio.Models.Entities.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataFaturamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuantidadeItens")
                        .HasColumnType("int");

                    b.Property<float>("ValorTotalVenda")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Dominio.Models.Entities.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("Dominio.Models.Entities.ItemVenda", b =>
                {
                    b.HasOne("Dominio.Models.Entities.Venda", "Venda")
                        .WithMany("Itens")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("Dominio.Models.Entities.Venda", b =>
                {
                    b.HasOne("Dominio.Models.Entities.Cliente", "Cliente")
                        .WithMany("Vendas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Dominio.Models.Entities.Cliente", b =>
                {
                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("Dominio.Models.Entities.Venda", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}
