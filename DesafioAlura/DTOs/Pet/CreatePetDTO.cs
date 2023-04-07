using DesafioAlura.Enums;
using System.ComponentModel.DataAnnotations;

namespace DesafioAlura.DTOs.Pet
{
    public class CreatePetDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(150, ErrorMessage = "O tamanho do nome não pode ultapassar 150 caracteres")]
        [MinLength(10, ErrorMessage = "O tamanho do nome não pode ser menor que 10 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A especie é obrigatória")]
        public Especie Especie { get; set; }
        [Required(ErrorMessage = "O tamanho é obrigatório")]
        public Tamanho Tamanho { get; set; }
        [Required(ErrorMessage = "A personalidade é obrigatória")]
        [MaxLength(150, ErrorMessage = "O tamanho do nome não pode ultapassar 150 caracteres")]
        [MinLength(10, ErrorMessage = "O tamanho do nome não pode ser menor que 10 caracteres")]
        public string Personalidade { get; set; }
        [Required(ErrorMessage = "A cidade é obrigatória")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "O estado é obrigatório")]
        public string Estado { get; set; }
        //public Tutor? Tutor { get; set;}
        public PetStatus Status { get; set; } = PetStatus.Novo;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}
