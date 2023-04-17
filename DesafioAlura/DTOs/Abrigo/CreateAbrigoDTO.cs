using DesafioAlura.Entidades;

namespace DesafioAlura.DTOs.Abrigo
{
    public class CreateAbrigoDTO
    {
        public string Nome { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
