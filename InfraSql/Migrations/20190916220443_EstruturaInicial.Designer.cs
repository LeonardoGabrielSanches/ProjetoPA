﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VendasAPI.Infra.Context;

namespace InfraSql.Migrations
{
    [DbContext(typeof(VendaContext))]
    [Migration("20190916220443_EstruturaInicial")]
    partial class EstruturaInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VendasAPI.Domínio.Entidades.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("CEP");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Municipio");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<string>("NumeroDocumento");

                    b.Property<string>("TipoDocumento");

                    b.Property<string>("UF");

                    b.Property<string>("email");

                    b.HasKey("ClienteID");

                    b.ToTable("Cliente");
                });
#pragma warning restore 612, 618
        }
    }
}
