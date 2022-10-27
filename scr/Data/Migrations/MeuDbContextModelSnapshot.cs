﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(MeuDbContext))]
    partial class MeuDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Business.Models.ContaFisica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Agencia")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<string>("ContaCorrente")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("Datetime");

                    b.Property<string>("Senha6dig")
                        .IsRequired()
                        .HasColumnType("varchar(6)");

                    b.Property<string>("Senha8dig")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<string>("UsuarioLogin")
                        .IsRequired()
                        .HasColumnType("varchar(35)");

                    b.HasKey("Id");

                    b.ToTable("ContaFisica", (string)null);
                });

            modelBuilder.Entity("Business.Models.ContaJuridica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<string>("ChaveJ")
                        .IsRequired()
                        .HasColumnType("varchar(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("Datetime");

                    b.Property<string>("Senha6Dig")
                        .IsRequired()
                        .HasColumnType("varchar(6)");

                    b.Property<string>("Senha8Dig")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("varchar(35)");

                    b.Property<string>("UsuarioLogin")
                        .IsRequired()
                        .HasColumnType("varchar(35)");

                    b.HasKey("Id");

                    b.ToTable("ContaJuridica", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
