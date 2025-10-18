// 4. Crie uma exceção personalizada chamada PrecoInvalidoError.
// Crie uma função que cadastre um produto (nome e preço).
// Se o preço for menor ou igual a zero, lance essa exceção.

using Atividade_04;

try
{
    Console.Write("Digite o nome do produto: ");
    string nome = Console.ReadLine();

    Console.Write("Digite o preço do produto: ");
    double preco = Convert.ToDouble(Console.ReadLine());

    CadastrarProduto(nome, preco);
}
catch (PrecoInvalidoError)
{
    Console.WriteLine("Preço inválido!");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("\nFim da operação!");
}

void CadastrarProduto(string nome, double preco)
{
    Produto produto = new Produto(nome, preco);

    Console.WriteLine("\nProduto registrado com sucesso!");
    Console.WriteLine($"Nome: {produto.Nome}");
    Console.WriteLine($"Preço: R${produto.Preco}");
}