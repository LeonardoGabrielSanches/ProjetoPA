﻿using Microsoft.EntityFrameworkCore;
using VendasAPI.Domínio.Entidades;

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
        }

    }
}
