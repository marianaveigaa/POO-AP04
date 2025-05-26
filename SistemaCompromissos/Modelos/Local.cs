namespace SistemaCompromissos.Modelos;

public class Local
{
    public string Nome { get; private set; }
    public int CapacidadeMaxima { get; private set; }

    public Local(string nome, int capacidade)
    {
        Nome = nome;
        CapacidadeMaxima = capacidade > 0 ? capacidade : throw new ArgumentException("Capacidade inválida");
    }

    public bool ValidarCapacidade(int quantidade) => quantidade <= CapacidadeMaxima;
}