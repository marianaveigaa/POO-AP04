namespace SistemaCompromissos.Modelos;

public class Anotacao
{
    public string Texto { get; private set; }
    public DateTime DataCriacao { get; } = DateTime.Now;

    public Anotacao(string texto) => Texto = texto ?? throw new ArgumentNullException();
}