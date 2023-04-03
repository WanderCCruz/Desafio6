using System.ComponentModel.DataAnnotations;

namespace DesafioAlura.DTOs
{
    public class UpdateTutorDtO
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(150, ErrorMessage = "O tamanho do nome não pode ultapassar 150 caracteres")]
        [MinLength(10, ErrorMessage = "O tamanho do nome não pode ser menor que 10 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O E-mail é obrigatório")]
        [StringLength(150, ErrorMessage = "O tamanho do E-mail não pode ultapassar 150 caracteres")]
        [MinLength(10, ErrorMessage = "O tamanho do E-mail não pode ser menor que 10 caracteres")]
        public string Email { get; set; }
       
    }
}
