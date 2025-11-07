// 5. Sistema de Registro de Ocorrências

// Você irá criar um sistema que registra ocorrências de incidentes em um condomínio. 

using Exercicio05;

CentralDeOcorrencias centralOcorrencias = new CentralDeOcorrencias();

centralOcorrencias.OcorrenciaRegistrada += OcorrenciasOuvinte.GravarLog;
centralOcorrencias.OcorrenciaRegistrada += OcorrenciasOuvinte.ExibirAlertasConsole;

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n--- Menu de Ocorrências ---");
    Console.WriteLine("1. Registrar Ocorrência");
    Console.WriteLine("2. Listar todas as ocorrências");
    Console.WriteLine("3. Filtrar ocorrências urgentes");
    Console.WriteLine("4. Agrupar ocorrências por tipo");
    Console.WriteLine("5. Salvar ocorrências em JSON");
    Console.WriteLine("6. Sair");
    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Tipo: ");
            string tipo = Console.ReadLine();

            Console.Write("Local: ");
            string local = Console.ReadLine();

            Console.Write("Urgente? (y/n) ");
            string ehUrgente = Console.ReadLine().ToLower();
            bool urgente = false;

            if (ehUrgente == "y")
            {
                urgente = true;
            }

            var novaOcorrencia = new Ocorrencia(tipo, local, urgente);
            centralOcorrencias.Registrar(novaOcorrencia);
            break;

        case "2":
            Console.Clear();
            Console.WriteLine($"--- Lista de Ocorrências ---");

            centralOcorrencias.ListarOcorrencias();
            break;

        case "3":
            var urgentes = centralOcorrencias.Ocorrencias.Where(o => o.Urgente == true).ToList();
            var existe = true;

            Console.Clear();
            Console.WriteLine("--- Ocorrências Urgentes ---");

            if (urgentes.Count() == 0)
            {
                Console.WriteLine("\nNenhuma ocorrência urgente registrada!");
            }
            else
            {
                centralOcorrencias.ListarOcorrenciasFiltradas(urgentes);
            }

            break;

        case "4":
            var gruposPorTipo = centralOcorrencias.Ocorrencias.GroupBy(o => o.Tipo).ToList();

            Console.Clear();
            Console.WriteLine("--- Ocorrências Urgentes ---");

            if (centralOcorrencias.Ocorrencias.Count == 0)
            {
                Console.WriteLine("\nNenhuma ocorrência registrada!");
            }

            foreach (var grupo in gruposPorTipo)
            {
                Console.WriteLine($"\n[Tipo: {grupo.Key}]");
                foreach (var ocorrencia in grupo)
                {
                    Console.WriteLine($" - {ocorrencia.Local} ({ocorrencia.Data})");
                }
            }
            break;

        case "5":
            Console.Clear();
            centralOcorrencias.SalvarJson();
            Console.WriteLine("\nUsuários salvos em ocorrencias.json");
            break;

        case "6":
            Console.WriteLine("Saindo...");
            continuar = false;
            break;

        default:
            Console.Clear();
            Console.WriteLine("Opção inválida!");
            break;
    }
}



// Toda vez que uma ocorrência for registrada:

// • O evento OcorrenciaRegistrada deve ser disparado.
// • Ouvintes(assinantes) devem reagir de formas diferentes:
//   - Um grava no log ocorrencias.txt.
//   - Outro exibe no console.
//   - Se a ocorrência for urgente, exibir "ALERTA URGENTE" no console.

// • As ocorrências devem ser salvas em formato JSON.
// • O sistema deve permitir buscar ocorrências por tipo ou urgência com LINQ.

// ----------------------------------------------------------
// Requisitos:

// 1. Classe Ocorrencia
// - Tipo, Local, Data, Urgente (bool).

// 2. Classe CentralDeOcorrencias
// - Método Registrar(Ocorrencia o) que dispara o evento.
// - Lista de ocorrências.
// - Métodos para salvar/carregar em JSON.

// 3. Evento e Delegate
// - Delegate void OcorrenciaHandler(Ocorrencia o).
// - Evento OcorrenciaRegistrada.

// 4. Ouvintes(assinantes)
// - Um grava no arquivo.
// - Outro escreve alertas no console.
// - Condicional especial para Urgente igual a true.

// 5. Consultas LINQ
// - Filtrar ocorrências urgentes.
// - Agrupar por tipo.
