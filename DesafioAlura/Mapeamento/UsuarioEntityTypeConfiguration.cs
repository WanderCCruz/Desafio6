using DesafioAlura.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioAlura.Mapeamento
{
    public class UsuarioEntityTypeConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar").HasMaxLength(100);
            builder.Property(x => x.Senha).IsRequired().HasColumnType("varchar").HasMaxLength(150);
            builder.Property(x => x.Email).IsRequired().HasColumnType("varchar").HasMaxLength(150);
            builder.Property(x => x.Foto).HasColumnType("varchar(max)");
            builder.Property(x => x.DataCriacao).HasColumnType("datetime");
            builder.Property(x => x.Sobre).IsRequired().HasColumnType("varchar").HasMaxLength(300);

        }
    }
}
