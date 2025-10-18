// 5. Crie uma função chamada vender_produto que recebe dois argumentos:
// • Quantidade Disponível (int)
// • Quantidade Vendida (int)
// Se a quantidade vendida for maior que a quantidade disponivel, imprima: "Quantidade indisponível no estoque"
// No programa principal, trate esse erro com try/catch.

using Atividade_05;

try
{
    Console.Write("Digite o nome do produto: ");
    string nomeProduto = Console.ReadLine();

    Console.Write("Digite o preço do produto: ");
    double precoProduto = Convert.ToDouble(Console.ReadLine());

    Produto produto = new Produto(nomeProduto, precoProduto);

    Console.Write("Digite a quantidade disponível do produto: ");
    int qtdDisponivel = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite a quantidade vendida do produto: ");
    int qtdVendida = Convert.ToInt32(Console.ReadLine());

    produto.VenderProduto(qtdDisponivel, qtdVendida);
    produto.Exibir();
}
catch (FormatException)
{
    Console.WriteLine("Por favor, verifique o formato!");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}