using SistemaCompromissos.Modelos;
using SistemaCompromissos.Persistencia;

var usuarios = RepositorioCompromissos.Carregar();

Console.WriteLine("Digite seu nome:");
var usuario = new Usuario(Console.ReadLine()!);

Console.WriteLine($"Usuário '{usuario.Nome}' criado. Adicione compromissos manualmente.");

RepositorioCompromissos.Salvar(new List<Usuario> { usuario });