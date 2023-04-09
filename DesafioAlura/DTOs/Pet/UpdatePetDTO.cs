using DesafioAlura.Enums;

namespace DesafioAlura.DTOs.Pet
{
    public class UpdatePetDTO
    {
        public string Nome { get; set; }
        public Especie Especie { get; set; }
        public Tamanho Tamanho { get; set; }

        public string Personalidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public PetStatus Status { get; set; }
    }
}
