using DesafioAlura.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioAlura.Mapeamento
{
    public class AdocaoEntityTypeConfiguration : IEntityTypeConfiguration<Adocao>
    {
        public void Configure(EntityTypeBuilder<Adocao> builder)
        {

            builder.HasKey(a => new { a.PetId, a.UsuarioId });
            builder.HasOne(a => a.Pet)
                .WithOne(a => a.Adocao)
                .HasForeignKey<Adocao>();

            builder.HasOne(a => a.Usuario)
                .WithMany(a => a.Adocoes);
        }
    }
}
