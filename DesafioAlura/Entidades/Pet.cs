using DesafioAlura.Enums;
using System.ComponentModel.DataAnnotations;

namespace DesafioAlura.Entidades
{
    public class Pet
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public Especie Especie { get; set;}
        public Tamanho Tamanho { get; set;}
        public string Personalidade { get; set; }
        //public virtual Abrigo? Abrigo { get; set; }// = null;
        public String? Foto { get; set; }
        public PetStatus Status { get; set; } = PetStatus.Novo;
        public DateTime DataCriacao { get; set; } = DateTime.Now;

    }
}
