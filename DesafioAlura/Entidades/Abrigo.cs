namespace DesafioAlura.Entidades
{
    public class Abrigo
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public Endereco? Endereco { get; set; }

    }
}
