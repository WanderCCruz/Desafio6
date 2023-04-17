using DesafioAlura.Enums;
using System.ComponentModel.DataAnnotations;

namespace DesafioAlura.DTOs.Pet
{
    public class CreatePetDTO
    {
        public string Nome { get; set; }
        public Especie Especie { get; set; }
        public Tamanho Tamanho { get; set; }
   
        public string Personalidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
