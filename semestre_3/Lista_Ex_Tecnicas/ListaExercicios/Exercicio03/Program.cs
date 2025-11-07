// 3. Controle de Usuário

// Você irá desenvolver um sistema simples para gerenciar usuários de um aplicativo.
// O sistema deve permitir o cadastro de usuários e realizar algumas ações automáticas ao longo do processo.

using Exercicio03;
using System.Text.Json;

GerenciadorUsuarios gerenciador = new GerenciadorUsuarios();

// Assinantes
gerenciador.UsuarioCadastrado += Notificacoes.NovoUsuario;
gerenciador.UsuarioCadastrado += Notificacoes.SalvarLog;

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n--- Menu de Usuários ---");
    Console.WriteLine("1. Cadastrar Usuário");
    Console.WriteLine("2. Listar todos os usuários");
    Console.WriteLine("3. Filtrar usuários maiores de idade");
    Console.WriteLine("4. Agrupar usuários por domínio de e-mail");
    Console.WriteLine("5. Listar 3 usuários mais recentes");
    Console.WriteLine("6. Salvar usuários em JSON");
    Console.WriteLine("7. Sair");
    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            var novoUsuario = new Usuario(nome, email, idade);
            gerenciador.CadastrarUsuario(novoUsuario);
            break;

        case "2":
            gerenciador.ExibirUsuarios();
            break;

        case "3":
            var maiores = gerenciador.Usuarios.Where(u => u.Idade >= 18).ToList();

            Console.Clear();
            Console.WriteLine("--- Usuários maiores de idade ---\n");
            gerenciador.ExibirUsuarioFiltrado(maiores);
            break;

        case "4":
            var gruposPorDominios = gerenciador.Usuarios.Select(u => u.Email.Split('@')[1]).Distinct();

            Console.Clear();
            Console.WriteLine("--- Usuários por domínios de e-mail ---");

            if (gerenciador.Usuarios.Count == 0)
            {
                Console.WriteLine("\nNenhum usuário cadastrado!");
            }

            foreach (var dominio in gruposPorDominios)
            {
                Console.WriteLine($"\n[Domínio: {dominio}]");
                foreach (var user in gerenciador.Usuarios.Where(u => u.Email.EndsWith("@" + dominio)))
                {
                    Console.WriteLine($"- {user.Nome} ({user.Email})");
                }
            }
            break;

        case "5":
            var recentes = gerenciador.Usuarios.OrderByDescending(u => u.DataCadastro).Take(3).ToList();

            Console.Clear();
            Console.WriteLine("--- 3 usuários mais recentes ---\n");
            gerenciador.ExibirUsuarioFiltrado(recentes);
            break;

        case "6":
            Console.Clear();
            gerenciador.SerializarJson();
            Console.WriteLine("Usuários salvos em usuarios.json");
            break;

        case "7":
            Console.WriteLine("Saindo...");
            continuar = false;
            break;

        default:
            Console.Clear();
            Console.WriteLine("Opção inválida!");
            break;
    }
}

// Cada vez que um novo usuário for cadastrado:
    // Um evento chamado UsuarioCadastrado deve ser disparado.
    // Esse evento deve ser baseado em um delegate personalizado, que define a assinatura dos métodos de notificação (ex: enviar e-mail, registrar log etc.).

// Os ouvintes do evento deverão executar ações diferentes, como:
    // Exibir uma mensagem no console.
    // Gravar uma entrada em um arquivo de log .txt com data e hora do cadastro.
    // O sistema deve manter uma lista de usuários na memória.

// Deve permitir que o usuário consulte os dados utilizando LINQ:
    // Filtrar usuários maiores de idade.
    // Agrupar usuários por domínio do e-mail.
    // Listar os 3 mais recentes cadastrados.
    // A lista de usuários deve ser serializada em JSON e salva em um arquivo.
    // O sistema também deve permitir desserializar esse arquivo JSON para carregar os dados ao iniciar.

// Requisitos:
// 1.Classe Usuario
    // Propriedades: Nome, Email, Idade, DataCadastro.

// 2. Classe GerenciadorUsuarios
    // Contém lista de usuários.
    // Método CadastrarUsuario(Usuario usuario):
    // Adiciona o usuário à lista.
    // Dispara o evento UsuarioCadastrado.

// 3. Delegate e Evento
    // Crie um delegate chamado NotificacaoHandler(Usuario usuario).
    // O evento UsuarioCadastrado será do tipo NotificacaoHandler.

// 4. Ouvintes (assinantes) do Evento
    // Um método escreve no console:
    // "Novo usuário: {Nome}, cadastrado em {DataCadastro}".
    // Outro grava no arquivo log.txt a mesma mensagem.