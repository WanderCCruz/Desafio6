using DesafioAlura.Enums;

namespace DesafioAlura.Entidades
{
    public class Pet
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Especie Especie { get; set;}
        public Tamanho Tamanho { get; set;}
        public string Personalidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set;}
        public string Tutor { get; set;}
        public PetStatus Status { get; set; }
        public DateTime DataCriacao { get; set; }

    }
}
