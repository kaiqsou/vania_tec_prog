using System.Reflection.Metadata.Ecma335;

var pessoa = new Pessoa { Nome = "Maria", Idade = 21 };

// Serialização
string json = System.Text.Json.JsonSerializer.Serialize(pessoa);
Console.WriteLine(json);

// Desserialização - a barra inversa é sempre usada antes de um caractere especial
var jsonString = "{\"Nome\":\"João\",\"Idade\":25}";
Pessoa PessoaDesserializada = System.Text.Json.JsonSerializer.Deserialize<Pessoa>(jsonString);
Console.WriteLine(PessoaDesserializada.Nome);

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public Pessoa() { }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}