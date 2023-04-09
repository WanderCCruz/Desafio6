using DesafioAlura.Enums;

namespace DesafioAlura.Entidades
{
    public class Usuario
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set;}
        public String? Foto { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public string Sobre { get; set; }

    }
}
