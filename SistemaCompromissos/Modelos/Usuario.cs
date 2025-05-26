namespace SistemaCompromissos.Modelos;

public class Usuario
{
    public string Nome { get; private set; }
    private List<Compromisso> _compromissos = new List<Compromisso>();
    public IReadOnlyCollection<Compromisso> Compromissos => _compromissos.AsReadOnly();

    public Usuario(string nome) => Nome = nome;

    public void AdicionarCompromisso(Compromisso compromisso)
    {
        if (compromisso == null || compromisso.DataHora <= DateTime.Now)
            throw new ArgumentException("Compromisso inválido ou data no passado!");
        _compromissos.Add(compromisso);
    }
}