namespace SistemaCompromissos.Modelos;

public class Compromisso
{
    public DateTime DataHora { get; private set; }
    public string Descricao { get; private set; }
    public Local Local { get; private set; }
    public List<Participante> Participantes { get; private set; } = new List<Participante>();
    public List<Anotacao> Anotacoes { get; private set; } = new List<Anotacao>();

    public Compromisso(DateTime dataHora, string descricao, Local local)
    {
        if (string.IsNullOrEmpty(descricao) || dataHora <= DateTime.Now)
            throw new ArgumentException("Descrição vazia ou data inválida!");
        DataHora = dataHora;
        Descricao = descricao;
        Local = local;
    }

    public void AdicionarParticipante(Participante participante) => Participantes.Add(participante);
    public void AdicionarAnotacao(string texto) => Anotacoes.Add(new Anotacao(texto));
    public override string ToString() => $"{DataHora:dd/MM/yyyy HH:mm} - {Descricao} ({Local.Nome})";
}