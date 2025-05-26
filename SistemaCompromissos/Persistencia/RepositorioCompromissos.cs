using System.Text.Json;
using SistemaCompromissos.Modelos;

namespace SistemaCompromissos.Persistencia;

public static class RepositorioCompromissos
{
    private static string _caminhoArquivo = "agenda.json";

    public static void Salvar(List<Usuario> usuarios)
    {
        var opcoes = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(usuarios, opcoes);
        File.WriteAllText(_caminhoArquivo, json);
    }

    public static List<Usuario> Carregar()
    {
        if (!File.Exists(_caminhoArquivo)) return new List<Usuario>();
        string json = File.ReadAllText(_caminhoArquivo);
        return JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();
    }
}