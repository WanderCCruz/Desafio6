namespace DesafioAlura.Entidades
{
    public class Adocao
    {
        public Guid UsuarioId { get; set; }
        public Guid PetId { get; set; }
        public Usuario Usuario { get; set; }
        public Pet Pet { get; set; }
        public DateTime DataAdocaoInicio { get; set; } = DateTime.Now;
    }
}
