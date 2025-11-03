using System.Text;
using System.Text.Json;

var caminho = "pessoas.json";

List<Pessoa> listaPessoas = new List<Pessoa>
{
    new Pessoa { Nome = "Ana", Idade = 20},
    new Pessoa { Nome = "João", Idade = 19},
    new Pessoa { Nome = "Kaique", Idade = 21}
};

// Serialização em Arquivo
if (!File.Exists(caminho))
{
    string jsonString = JsonSerializer.Serialize(listaPessoas, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(caminho, jsonString);
    Console.WriteLine("Arquivo json gravado!\n");
}

// Desserialização
if (File.Exists(caminho))
{
    string conteudo = File.ReadAllText(caminho);
    List<Pessoa> listaConteudo = JsonSerializer.Deserialize<List<Pessoa>>(conteudo);
    Console.WriteLine("Lista de Pessoas");
    foreach(var pessoa in listaConteudo)
    {
        Console.WriteLine($"Nome: {pessoa.Nome}\nIdade: {pessoa.Idade}\n");
    }
}

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}