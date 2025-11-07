namespace Exercicio04
{
    public class Produto
    {
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public double Price { get; set; }
        public DateTime DataCadastro { get; set; }

        public Produto(string? nome, string? categoria, double price)
        {
            Nome = nome;
            Categoria = categoria;
            Price = price;
            DataCadastro = DateTime.Now;
        }
    }
}
