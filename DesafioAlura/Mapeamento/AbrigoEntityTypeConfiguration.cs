using DesafioAlura.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioAlura.Mapeamento
{
    public class AbrigoEntityTypeConfiguration: IEntityTypeConfiguration<Abrigo>
    {
        public void Configure(EntityTypeBuilder<Abrigo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar").HasMaxLength(150);

            //builder.HasMany(p => p.Pets)
            //    .WithOne(a => a.Abrigo)
            //    .HasForeignKey("AbrigoId")
            //    .IsRequired(false);

            builder.HasOne(a => a.Endereco)
                .WithOne()
                .HasForeignKey<Abrigo>("EnderecoId").IsRequired();
        }
    }
}
