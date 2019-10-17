using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VendasAPI.Domínio.Entidades;

namespace VendasAPI.Infra.Mapping
{
    public class ItemMapping
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item");
            builder.HasKey(b => b.ItemID).HasName("ItemID");
            builder.Property(b => b.ItemID).HasColumnName("ItemID").ValueGeneratedOnAdd();
            builder.Property(b => b.CodigoEstoque).HasColumnName("CodigoEstoque").HasMaxLength(4000).IsRequired();
            builder.Property(b => b.Descricao).HasColumnName("Descricao").HasMaxLength(9).IsRequired();
            builder.Property(b => b.Marca).HasColumnName("Marca").HasMaxLength(4000).IsRequired();
            builder.Property(b => b.ValorCusto).HasColumnName("ValorCusto").HasMaxLength(4000).IsRequired();
            builder.Property(b => b.ValorVenda).HasColumnName("ValorVenda").HasMaxLength(4000).IsRequired();
            builder.Property(b => b.MargemMaxima).HasColumnName("MargemMaxima").HasMaxLength(4000).IsRequired();
                      
        }
    }
}
