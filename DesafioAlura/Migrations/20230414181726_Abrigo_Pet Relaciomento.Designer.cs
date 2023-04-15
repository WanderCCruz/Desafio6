﻿// <auto-generated />
using System;
using DesafioAlura.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesafioAlura.Migrations
{
    [DbContext(typeof(AdoPetContext))]
    [Migration("20230414181726_Abrigo_Pet Relaciomento")]
    partial class Abrigo_PetRelaciomento
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DesafioAlura.Entidades.Abrigo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("Abrigos");
                });

            modelBuilder.Entity("DesafioAlura.Entidades.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("DesafioAlura.Entidades.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AbrigoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime");

                    b.Property<int>("Especie")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .HasColumnType("varchar");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<string>("Personalidade")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Tamanho")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AbrigoId");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("DesafioAlura.Entidades.Tutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Tutores");
                });

            modelBuilder.Entity("DesafioAlura.Entidades.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar");

                    b.Property<string>("Sobre")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("DesafioAlura.Entidades.Abrigo", b =>
                {
                    b.HasOne("DesafioAlura.Entidades.Endereco", "Endereco")
                        .WithOne()
                        .HasForeignKey("DesafioAlura.Entidades.Abrigo", "EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("DesafioAlura.Entidades.Pet", b =>
                {
                    b.HasOne("DesafioAlura.Entidades.Abrigo", "Abrigo")
                        .WithMany("Pets")
                        .HasForeignKey("AbrigoId");

                    b.Navigation("Abrigo");
                });

            modelBuilder.Entity("DesafioAlura.Entidades.Usuario", b =>
                {
                    b.HasOne("DesafioAlura.Entidades.Endereco", "Endereco")
                        .WithOne()
                        .HasForeignKey("DesafioAlura.Entidades.Usuario", "EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("DesafioAlura.Entidades.Abrigo", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}