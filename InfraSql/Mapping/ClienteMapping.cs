using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VendasAPI.Domínio.Entidades;

namespace VendasAPI.Infra.Mapping
{
    public class ClienteMapping
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(b => b.ClienteID).HasName("ClienteID");
            builder.Property(b => b.ClienteID).HasColumnName("ClienteID").ValueGeneratedOnAdd();
            builder.Property(b => b.Bairro).HasColumnName("Bairro").HasMaxLength(4000);
            builder.Property(b => b.CEP).HasColumnName("CEP").HasMaxLength(9);
            builder.Property(b => b.email).HasColumnName("Email").HasMaxLength(4000);
            builder.Property(b => b.Logradouro).HasColumnName("Logradouro").HasMaxLength(4000);
            builder.Property(b => b.Municipio).HasColumnName("Município").HasMaxLength(4000);
            builder.Property(b => b.Nome).HasColumnName("NomeCliente").HasMaxLength(4000);
            builder.Property(b => b.Numero).HasColumnName("Número").HasMaxLength(100);
            builder.Property(b => b.NumeroDocumento).HasColumnName("Número do documento").HasMaxLength(20);
            builder.Property(b => b.TipoDocumento).HasColumnName("TipoDoDocumento").HasMaxLength(50);
            builder.Property(b => b.UF).HasColumnName("UF").HasMaxLength(5);
        }
    }
}
