using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VendasAPI.Domínio.Entidades;

namespace VendasAPI.Infra.Mapping
{
    public class VendedorMapping
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            builder.ToTable("Vendedor");
            builder.HasKey(b => b.VendedorID).HasName("VendedorID");
            builder.Property(b => b.VendedorID).HasColumnName("VendedorID").IsRequired().ValueGeneratedOnAdd();
            builder.Property(b => b.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(4000);

        }
    }
}
