// 2.Biblioteca

// Você vai criar um pequeno sistema para registrar livros de uma biblioteca.
// Esses livros serão armazenados em uma lista e, em seguida, salvos em um arquivo .json no disco.

// Depois, o sistema deve ler esse arquivo JSON, converter os dados de volta para objetos em memória e exibir os livros no console.

// Crie uma classe Livro com as seguintes propriedades:
// Título(string)
// Autor(string)
// Ano(int)

using ListaExercicios;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

var caminho = "livros.json";

List<Livro> listaLivros = new List<Livro>
{
    new Livro { Titulo = "The Witcher", Autor = "Andrzej Sapkowski", Ano = 1993},
    new Livro { Titulo = "Harry Potter e a Pedra Filosofal", Autor = "JK Rowling", Ano = 1997 },
    new Livro { Titulo = "As crônicas de Nárnia", Autor = "Lewis", Ano = 1950}
};

// Serialização
if (!File.Exists(caminho))
{
    // WriteIndented vai identar automaticamente o arquivo json, o Encoder permite a visualização de caracteres especiais no json
    string jsonString = JsonSerializer.Serialize(listaLivros, new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) });
    File.WriteAllText(caminho, jsonString);
    Console.WriteLine($"Json gravado em {caminho}!");
}

// Desserialização
if (File.Exists(caminho))
{
    string conteudo = File.ReadAllText(caminho);
    List<Livro> listaConteudo = JsonSerializer.Deserialize<List<Livro>>(conteudo);

    Console.WriteLine($"Lista de pessoas do arquivo {caminho}: ");
    foreach(var livro in listaConteudo)
    {
        Console.WriteLine($"\nTítulo: {livro.Titulo}");
        Console.WriteLine($"Autor: {livro.Autor}");
        Console.WriteLine($"Ano: {livro.Ano}");
    }
}

