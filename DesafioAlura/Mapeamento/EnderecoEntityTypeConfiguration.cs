using DesafioAlura.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioAlura.Mapeamento
{
    public class EnderecoEntityTypeConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Logradouro).IsRequired().HasColumnType("varchar").HasMaxLength(150);
            builder.Property(x => x.Cidade).IsRequired().HasColumnType("varchar").HasMaxLength(150);
            builder.Property(x => x.Numero).IsRequired().HasColumnType("varchar").HasMaxLength(5);
        }
    }
}
