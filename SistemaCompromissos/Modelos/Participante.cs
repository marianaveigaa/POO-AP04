namespace SistemaCompromissos.Modelos;

public class Participante
{
    public string Nome { get; private set; }
    private List<Compromisso> _compromissos = new List<Compromisso>();
    public IReadOnlyCollection<Compromisso> Compromissos => _compromissos.AsReadOnly();

    public Participante(string nome) => Nome = nome;

    public void AdicionarCompromisso(Compromisso compromisso)
    {
        if (compromisso == null) throw new ArgumentNullException();
        _compromissos.Add(compromisso);
        compromisso.AdicionarParticipante(this);
    }
}