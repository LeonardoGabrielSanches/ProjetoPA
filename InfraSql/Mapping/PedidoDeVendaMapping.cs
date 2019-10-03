using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraSql.Mapping
{
    public class PedidoDeVendaMapping
    {
        public void Configure(EntityTypeBuilder<PedidoDeVenda> builder)
        {
            builder.ToTable("PedidoDeVenda");
            builder.HasKey(b => b.VendaId).HasName("VendaId");
            builder.Property(b => b.VendaId).HasColumnName("VendaId").ValueGeneratedOnAdd();
            builder.Property(b => b.DataDeEntrega).HasColumnName("DataDeEntrega").IsRequired().HasMaxLength(11);
            builder.Property(b => b.DataDoPedido).HasColumnName("DataDoPedido").IsRequired().HasMaxLength(11);
            builder.Property(b => b.Desconto).HasColumnName("Desconto").IsRequired().HasMaxLength(100);
            builder.Property(b => b.PrecoFinal).HasColumnName("PrecoFinal").IsRequired().HasMaxLength(100);

        }

    }
}
