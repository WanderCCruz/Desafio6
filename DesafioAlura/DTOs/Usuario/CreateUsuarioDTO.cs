using DesafioAlura.Entidades;
using System.ComponentModel.DataAnnotations;

namespace DesafioAlura.DTOs.Usuario
{
    public class CreateUsuarioDTO
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public String? Foto { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public string Sobre { get; set; }
        public Endereco Endereco { get; set; }
    }
}
