using DesafioAlura.Enums;

namespace DesafioAlura.Entidades
{
    public class Endereco
    {
        public int Id { get; set; } 
        public string Logradouro { get; set; }
        public Estados Estado { get; set; }
        public string Cidade { get; set; }
        public string? Numero { get; set;}
    }
}