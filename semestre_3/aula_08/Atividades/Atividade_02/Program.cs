// 2. Simula o cadastro de um produto com tratamento para entrada inválida e exceções genéricas.
// Lidar com entrada do usuário, múltiplos catch, e validação de regra de negócio. (FormatException e outros).

using Atividade_02;

try
{
    Console.Write("Digite o nome do produto: ");
    string nomeProduto = Console.ReadLine();

    Console.Write("Digite a descrição do produto: ");
    string descricaoProduto = Console.ReadLine();

    Console.Write("Digite a quantidade do produto: ");
    int quantidadeProduto = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o preço do produto: ");
    double precoProduto = Convert.ToDouble(Console.ReadLine());

    Produto produto = new Produto(nomeProduto, descricaoProduto, quantidadeProduto, precoProduto);
    Console.WriteLine("Produto adicionado!");

    produto.Exibir();
}
catch (FormatException)
{
    Console.WriteLine("Por favor, verifique o formato!");
}
catch (OverflowException)
{
    Console.WriteLine("Por favor, digite um número entre 1 e 9999!");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Fim da operação!");
}