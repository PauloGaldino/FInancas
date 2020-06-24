﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(FinanceiroDbContext))]
    partial class FinanceiroDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Entity.Entities.Base", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Bases");
                });

            modelBuilder.Entity("Entity.Entities.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdSistema")
                        .HasColumnType("int");

                    b.HasKey("CategoriaId");

                    b.HasIndex("IdSistema");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Entity.Entities.Compra", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.HasKey("CompraId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("Entity.Entities.Despesa", b =>
                {
                    b.Property<int>("DespesaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Mes")
                        .HasColumnType("int");

                    b.Property<bool>("Pago")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("TipoDespesa")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("DespesaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Despesa");
                });

            modelBuilder.Entity("Entity.Entities.ItemCompra", b =>
                {
                    b.Property<int>("ItemCoompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<bool>("Comprado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ItemCoompraId");

                    b.HasIndex("CompraId");

                    b.ToTable("ItemCompra");
                });

            modelBuilder.Entity("Entity.Entities.SistemaFinanceiro", b =>
                {
                    b.Property<int>("SistemaFinanceiroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("AnoCopia")
                        .HasColumnType("int");

                    b.Property<int>("DiaFechamento")
                        .HasColumnType("int");

                    b.Property<bool>("GerarCopiaDespesa")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Mes")
                        .HasColumnType("int");

                    b.Property<int>("MesCopia")
                        .HasColumnType("int");

                    b.HasKey("SistemaFinanceiroId");

                    b.ToTable("SistemaFinanceiro");
                });

            modelBuilder.Entity("Entity.Entities.Sugestao", b =>
                {
                    b.Property<int>("SugestaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DescricaoSugestao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EmailUsuario")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("SugestaoId");

                    b.ToTable("Sugestao");
                });

            modelBuilder.Entity("Entity.Entities.UsuarioSistemaFinanceiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Administrador")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("EmailUsuario")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("SistemaAtual")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("SistemaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SistemaId");

                    b.ToTable("UsuarioSistemaFinanceiro");
                });

            modelBuilder.Entity("Entity.Entities.Categoria", b =>
                {
                    b.HasOne("Entity.Entities.SistemaFinanceiro", "SistemaFinanceiro")
                        .WithMany()
                        .HasForeignKey("IdSistema")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Entities.Compra", b =>
                {
                    b.HasOne("Entity.Entities.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Entities.Despesa", b =>
                {
                    b.HasOne("Entity.Entities.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Entities.ItemCompra", b =>
                {
                    b.HasOne("Entity.Entities.Compra", "Compra")
                        .WithMany()
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Entities.UsuarioSistemaFinanceiro", b =>
                {
                    b.HasOne("Entity.Entities.SistemaFinanceiro", "SistemaFinanceiro")
                        .WithMany()
                        .HasForeignKey("SistemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}