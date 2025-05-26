# POO-AP04: Sistema de Gerenciamento de Compromissos

Um projeto em C# para gerenciar compromissos com persistência em JSON, seguindo os princípios de Orientação a Objetos.


🛠️ Funcionalidades

- Cadastro de usuários, compromissos, participantes e locais.

- Validações de data, descrição e capacidade.

- Persistência automática em arquivo JSON (agenda.json).


📂 Estrutura do Projeto
/Models
  Usuario.cs          
  Compromisso.cs      
  Participante.cs    
  Anotacao.cs        
  Local.cs          
/Persistence
  RepositorioCompromissos.cs  
Program.cs            


🔧 Como Executar
Pré-requisitos:

- .NET 6+

- VS Code (ou outra IDE)


🔃 Fluxo do programa:

1- Insira seu nome para criar/recuperar um usuário.

2- Use o menu interativo para adicionar/listar compromissos.

3- Os dados são salvos automaticamente em agenda.json.


👩‍💻 Feito por:
- Mariana Veiga Dos Santos
