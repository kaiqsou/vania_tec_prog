using System.Text.Json;

namespace Exercicio04
{
    public delegate void ProdutoHandler(Produto p);
    public class CatalogoProdutos
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();
        private string? CaminhoArquivo;
        public event ProdutoHandler? ProdutoAdicionado;

        public void CarregarProdutos(string caminhoArquivo)
        {
            CaminhoArquivo = caminhoArquivo;

            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("Arquivo não encontrado, criando novo: " + caminhoArquivo);
                File.WriteAllText(caminhoArquivo, "[]");
                return;
            }

            try
            {
                string json = File.ReadAllText(caminhoArquivo);
                var lista = JsonSerializer.Deserialize<List<Produto>>(json);

                if (lista != null) Produtos = lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao carregar produtos: " + ex.Message);
            }
        }

        public void AdicionarProduto(Produto p)
        {
            Produtos.Add(p);

            ProdutoAdicionado?.Invoke(p);

            if (CaminhoArquivo != null)
                SalvarProdutos(CaminhoArquivo);
        }

        public void SalvarProdutos(string caminhoArquivo)
        {
            try
            {
                string json = JsonSerializer.Serialize(Produtos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar produtos: " + ex.Message);
            }
        }

        public void ListarProdutos()
        {
            foreach (var item in Produtos)
            {
                Console.WriteLine(item);
            }
        }

        public List<Produto> ListarProdutosPorCategoria(string categoria)
        {
            return Produtos.Where(p => p.Categoria == categoria).ToList();
        }

        public List<Produto> ListarProdutosEntreOsPrecos(int precoInicial, int precoFinal)
        {
            return Produtos.Where(p => p.Price >= precoInicial && p.Price <= precoFinal).ToList();
        }
    }
}
