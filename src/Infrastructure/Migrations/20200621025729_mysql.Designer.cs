﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(FinanceiroDbContext))]
    [Migration("20200621025729_mysql")]
    partial class mysql
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Entity.Entities.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SistemaFinanceiroId")
                        .HasColumnType("int");

                    b.HasKey("CategoriaId");

                    b.HasIndex("SistemaFinanceiroId");

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

            modelBuilder.Entity("Entity.Entities.Categoria", b =>
                {
                    b.HasOne("Entity.Entities.SistemaFinanceiro", "SistemaFinanceiro")
                        .WithMany()
                        .HasForeignKey("SistemaFinanceiroId")
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
#pragma warning restore 612, 618
        }
    }
}
