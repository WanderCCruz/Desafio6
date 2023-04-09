using System.ComponentModel.DataAnnotations;

namespace DesafioAlura.DTOs.Usuario
{
    public class UpdateUsuarioDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public String? Foto { get; set; }
        public bool Ativo { get; set; } = true;
        public string Sobre { get; set; }
    }
}
