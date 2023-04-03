using DesafioAlura.Entidades;
using DesafioAlura.Mapeamento;
using Microsoft.EntityFrameworkCore;

namespace DesafioAlura.Context
{
    public class AdoPetContext : DbContext
    {

        public AdoPetContext(DbContextOptions<AdoPetContext> opts) : base(opts)
        {
            
        }
        public DbSet<Tutor> Tutores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tutor>().HasKey(t => t.Id);
            modelBuilder.Entity<Tutor>().Property(k => k.Id)
                .IsRequired();
            modelBuilder.Entity<Tutor>().Property(k => k.Nome)
                .IsRequired()
                .HasMaxLength(150);
            modelBuilder.Entity<Tutor>().Property(k => k.Email)
               .IsRequired()
               .HasMaxLength(100);
            modelBuilder.Entity<Tutor>().Property(k => k.Senha)
               .IsRequired()
               .HasMaxLength(25);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UsuarioEntityTypeConfiguration).Assembly);
        }
    }
}
