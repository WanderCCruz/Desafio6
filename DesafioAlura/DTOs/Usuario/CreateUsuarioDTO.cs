using System.ComponentModel.DataAnnotations;

namespace DesafioAlura.DTOs.Usuario
{
    public class CreateUsuarioDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(150, ErrorMessage = "O tamanho do nome não pode ultapassar 150 caracteres")]
        [MinLength(10, ErrorMessage = "O tamanho do nome não pode ser menor que 10 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A senha é obrigatório")]
        [StringLength(50, ErrorMessage = "A senha não pode ultapassar 50 caracteres")]
        [MinLength(6, ErrorMessage = "A senha não pode ser menor que 6 caracteres")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O E-mail é obrigatório")]
        [StringLength(150, ErrorMessage = "O tamanho do E-mail não pode ultapassar 150 caracteres")]
        [MinLength(10, ErrorMessage = "O tamanho do E-mail não pode ser menor que 10 caracteres")]
        public string Email { get; set; }
        public String? Foto { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(300, ErrorMessage = "O tamanho do nome não pode ultapassar 300 caracteres")]
        [MinLength(10, ErrorMessage = "O tamanho do nome não pode ser menor que 10 caracteres")]
        public string Sobre { get; set; }
    }
}
