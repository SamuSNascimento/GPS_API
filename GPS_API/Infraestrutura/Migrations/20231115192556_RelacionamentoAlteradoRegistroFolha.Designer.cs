﻿// <auto-generated />
using System;
using Infraestrutura.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestrutura.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231115192556_RelacionamentoAlteradoRegistroFolha")]
    partial class RelacionamentoAlteradoRegistroFolha
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Infraestrutura.DTOs.EnderecoDTO", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEndereco"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEndereco");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Infraestrutura.DTOs.FeriasDTO", b =>
                {
                    b.Property<int>("IdFerias")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFerias"));

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<string>("TipoFerias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFerias");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("Ferias");
                });

            modelBuilder.Entity("Infraestrutura.DTOs.FolhaPagamentoDTO", b =>
                {
                    b.Property<int>("IdFolhaPagemento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFolhaPagemento"));

                    b.Property<double>("Adicionais")
                        .HasColumnType("float");

                    b.Property<double>("Beneficios")
                        .HasColumnType("float");

                    b.Property<double>("ContribuicoesPrevidenciarias")
                        .HasColumnType("float");

                    b.Property<DateTime>("DataFolhaPagamento")
                        .HasColumnType("datetime2");

                    b.Property<double>("Deducoes")
                        .HasColumnType("float");

                    b.Property<double>("HorasExtras")
                        .HasColumnType("float");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<double>("Impostos")
                        .HasColumnType("float");

                    b.Property<double>("SalarioBase")
                        .HasColumnType("float");

                    b.HasKey("IdFolhaPagemento");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("FolhaPagamento");
                });

            modelBuilder.Entity("Infraestrutura.DTOs.FuncionarioDTO", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFuncionario"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContaBancaria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SalarioBase")
                        .HasColumnType("float");

                    b.HasKey("IdFuncionario");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("Infraestrutura.DTOs.RegistroPontoDTO", b =>
                {
                    b.Property<int>("IdRegistroPonto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRegistroPonto"));

                    b.Property<int>("Atrasos")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHoraEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraSaida")
                        .HasColumnType("datetime2");

                    b.Property<int>("Faltas")
                        .HasColumnType("int");

                    b.Property<double>("HorasExtras")
                        .HasColumnType("float");

                    b.Property<int>("IdFolhaDePagamento")
                        .HasColumnType("int");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.HasKey("IdRegistroPonto");

                    b.HasIndex("IdFolhaDePagamento");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("RegistroPonto");
                });

            modelBuilder.Entity("Infraestrutura.DTOs.TelefoneDTO", b =>
                {
                    b.Property<int>("IdTelefone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTelefone"));

                    b.Property<int>("DDD_Celular")
                        .HasColumnType("int");

                    b.Property<int>("DDD_Telefone")
                        .HasColumnType("int");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<int>("NumeroCell")
                        .HasColumnType("int");

                    b.Property<int>("NumeroFixo")
                        .HasColumnType("int");

                    b.HasKey("IdTelefone");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("Infraestrutura.DTOs.UsuarioDTO", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.Property<int>("NivelDeAcesso")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("IdFuncionario")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Infraestrutura.DTOs.EnderecoDTO", b =>
                {
                    b.HasOne("Infraestrutura.DTOs.FuncionarioDTO", "Funcionario")
                        .WithMany("Enderecos")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("Infraestrutura.DTOs.FeriasDTO", b =>
                {
                    b.HasOne("Infraestrutura.DTOs.FuncionarioDTO", "Funcionario")
                        .WithMany("Ferias")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("Infraestrutura.DTOs.FolhaPagamentoDTO", b =>
                {
                    b.HasOne("Infraestrutura.DTOs.FuncionarioDTO", "Funcionario")
                        .WithMany("FolhasPagamentos")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("Infraestrutura.DTOs.RegistroPontoDTO", b =>
                {
                    b.HasOne("Infraestrutura.DTOs.FolhaPagamentoDTO", "FolhaPagamento")
                        .WithMany("RegistroPonto")
                        .HasForeignKey("IdFolhaDePagamento")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Infraestrutura.DTOs.FuncionarioDTO", "Funcionario")
                        .WithMany("RegistroPonto")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FolhaPagamento");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("Infraestrutura.DTOs.TelefoneDTO", b =>
                {
                    b.HasOne("Infraestrutura.DTOs.FuncionarioDTO", "Funcionario")
                        .WithMany("Telefones")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("Infraestrutura.DTOs.UsuarioDTO", b =>
                {
                    b.HasOne("Infraestrutura.DTOs.FuncionarioDTO", "Funcionario")
                        .WithOne("Usuario")
                        .HasForeignKey("Infraestrutura.DTOs.UsuarioDTO", "IdFuncionario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("Infraestrutura.DTOs.FolhaPagamentoDTO", b =>
                {
                    b.Navigation("RegistroPonto");
                });

            modelBuilder.Entity("Infraestrutura.DTOs.FuncionarioDTO", b =>
                {
                    b.Navigation("Enderecos");

                    b.Navigation("Ferias");

                    b.Navigation("FolhasPagamentos");

                    b.Navigation("RegistroPonto");

                    b.Navigation("Telefones");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
