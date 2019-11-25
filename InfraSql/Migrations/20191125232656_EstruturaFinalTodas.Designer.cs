﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VendasAPI.Infra.Context;

namespace InfraSql.Migrations
{
    [DbContext(typeof(VendaContext))]
    [Migration("20191125232656_EstruturaFinalTodas")]
    partial class EstruturaFinalTodas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominio.Entidades.PedidoDeVenda", b =>
                {
                    b.Property<int>("VendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VendaId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDeEntrega")
                        .HasColumnName("DataDeEntrega")
                        .HasMaxLength(11);

                    b.Property<DateTime>("DataDoPedido")
                        .HasColumnName("DataDoPedido")
                        .HasMaxLength(11);

                    b.Property<double>("Desconto")
                        .HasColumnName("Desconto")
                        .HasMaxLength(100);

                    b.Property<double>("PrecoFinal")
                        .HasColumnName("PrecoFinal")
                        .HasMaxLength(100);

                    b.Property<int?>("VendedorID");

                    b.HasKey("VendaId")
                        .HasName("VendaId");

                    b.HasIndex("VendedorID");

                    b.ToTable("PedidoDeVenda");
                });

            modelBuilder.Entity("VendasAPI.Domínio.Entidades.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ClienteID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnName("Bairro")
                        .HasMaxLength(4000);

                    b.Property<string>("CEP")
                        .HasColumnName("CEP")
                        .HasMaxLength(40000);

                    b.Property<string>("Logradouro")
                        .HasColumnName("Logradouro")
                        .HasMaxLength(4000);

                    b.Property<string>("Municipio")
                        .HasColumnName("Município")
                        .HasMaxLength(4000);

                    b.Property<string>("Nome")
                        .HasColumnName("NomeCliente")
                        .HasMaxLength(4000);

                    b.Property<string>("Numero")
                        .HasColumnName("Número")
                        .HasMaxLength(4000);

                    b.Property<string>("NumeroDocumento")
                        .HasColumnName("Número do documento")
                        .HasMaxLength(4000);

                    b.Property<string>("TipoDocumento")
                        .HasColumnName("TipoDoDocumento")
                        .HasMaxLength(4000);

                    b.Property<string>("UF")
                        .HasColumnName("UF")
                        .HasMaxLength(100);

                    b.Property<string>("email")
                        .HasColumnName("Email")
                        .HasMaxLength(4000);

                    b.HasKey("ClienteID")
                        .HasName("ClienteID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("VendasAPI.Domínio.Entidades.Item", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ItemID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodigoEstoque")
                        .HasColumnName("CodigoEstoque")
                        .HasMaxLength(4000);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao")
                        .HasMaxLength(9);

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnName("Marca")
                        .HasMaxLength(4000);

                    b.Property<double>("MargemMaxima")
                        .HasColumnName("MargemMaxima")
                        .HasMaxLength(4000);

                    b.Property<int?>("PedidoDeVendaVendaId");

                    b.Property<double>("ValorCusto")
                        .HasColumnName("ValorCusto")
                        .HasMaxLength(4000);

                    b.Property<double>("ValorVenda")
                        .HasColumnName("ValorVenda")
                        .HasMaxLength(4000);

                    b.HasKey("ItemID")
                        .HasName("ItemID");

                    b.HasIndex("PedidoDeVendaVendaId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("VendasAPI.Domínio.Entidades.Vendedor", b =>
                {
                    b.Property<int>("VendedorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VendedorID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasMaxLength(4000);

                    b.HasKey("VendedorID")
                        .HasName("VendedorID");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("Dominio.Entidades.PedidoDeVenda", b =>
                {
                    b.HasOne("VendasAPI.Domínio.Entidades.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorID");
                });

            modelBuilder.Entity("VendasAPI.Domínio.Entidades.Item", b =>
                {
                    b.HasOne("Dominio.Entidades.PedidoDeVenda")
                        .WithMany("ListaDeItem")
                        .HasForeignKey("PedidoDeVendaVendaId");
                });
#pragma warning restore 612, 618
        }
    }
}
