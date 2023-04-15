using DesafioAlura.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Metadata;

namespace DesafioAlura.Mapeamento
{
    public class PetEntityTypeConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar").HasMaxLength(150);
            builder.Property(x => x.Personalidade).IsRequired().HasColumnType("varchar").HasMaxLength(150);
            builder.Property(x => x.DataCriacao).HasColumnType("datetime");
            builder.Property(x => x.Especie).IsRequired();
            builder.Property(x => x.Tamanho).IsRequired();
            builder.Property(x => x.Foto).HasColumnType("varchar");

            builder.HasOne(e => e.Abrigo)
            .WithMany(e => e.Pets)
            .HasForeignKey("AbrigoId")
            .IsRequired(false);

        }
    }
}
