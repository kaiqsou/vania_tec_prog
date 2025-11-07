using Exercicio04;

CatalogoProdutos catalogo = new CatalogoProdutos();
catalogo.CarregarProdutos("produtos.json");

GeradorRelatorio gerador = new GeradorRelatorio("relatorio.txt");

catalogo.ProdutoAdicionado += gerador.GerarLinhaRelatorio;

catalogo.AdicionarProduto(new Produto(
      "Notebook",
      "Eletrônicos",
      2500
));

catalogo.AdicionarProduto(new Produto(
        "Cadeira Gamer",
        "Móveis",
        2500
));

catalogo.AdicionarProduto(new Produto(
        "Soldado de borracha",
        "Brinquedo",
        60
));

Console.WriteLine("\n=== Produtos entre R$ 50 e R$ 200 ===");
var produtosFaixaPreco = catalogo.ListarProdutosEntreOsPrecos(50, 200);
foreach (var p in produtosFaixaPreco)
{
    Console.WriteLine(p.Nome);
}

Console.WriteLine("\n=== Produtos agrupados por categoria ===");
var agrupados = catalogo.Produtos.GroupBy(p => p.Categoria);
foreach (var grupo in agrupados)
{
    Console.WriteLine($"\nCategoria: {grupo.Key}");
    foreach (var p in grupo)
    {
        Console.WriteLine($"  - {p.Nome} - R$ {p.Price:F2}");
    }
}