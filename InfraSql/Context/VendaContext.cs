﻿using Dominio.Entidades;
using InfraSql.Mapping;
using Microsoft.EntityFrameworkCore;
using VendasAPI.Domínio.Entidades;
using VendasAPI.Infra.Mapping;

//Caso esteja dando merda , instalar os pacotes Nuget: EntityFrameworkCore,EntityFrameworkCore.SqlServer,EntityFrameworkCore.Tools
namespace VendasAPI.Infra.Context
{
    public class VendaContext : DbContext
    {
        public VendaContext()
        { }

        public VendaContext(DbContextOptions<VendaContext> options) : base(options)
        { }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Item> Item { get; set; }

        public DbSet<PedidoDeVenda> Pedido { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
                builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;DataBase=BancoDeVendas;persist security info=True");
            //Leonardo : "Data Source=DESKTOP-DGFAPKG\\SQLEXPRESS;Initial Catalog=BancoDeVendas;persist security info=True;user id=sa;Password=saadmin"
            //Andre : "Data Source=(localdb)\\MSSQLLocalDB;DataBase=BancoDeVendas;persist security info=True"
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Cliente>(new ClienteMapping().Configure);

            builder.Entity<Item>(new ItemMapping().Configure);

            builder.Entity<PedidoDeVenda>(new PedidoDeVendaMapping().Configure);

            builder.Entity<Vendedor>(new VendedorMapping().Configure);

            builder.Entity<PedidoDeVenda>().HasMany(b => b.ListaDeItem);

            builder.Entity<PedidoDeVenda>().HasOne(b => b.Vendedor);
        }

    }
}
