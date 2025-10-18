namespace Atividade_05
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public int QuantidadeVendida { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void VenderProduto(int qtdDisponivel, int qtdVendida)
        {
            if (qtdDisponivel < qtdVendida) throw new Exception("Quantidade indisponível no estoque!");

            Console.WriteLine("\nProduto vendido!");

            QuantidadeDisponivel = qtdDisponivel;
            QuantidadeVendida = qtdVendida;
        }

        public void Exibir()
        {
            Console.WriteLine($"\nProduto: {Nome}");
            Console.WriteLine($"Preço: R${Preco}");
            Console.WriteLine($"Quantidade Disponível: {QuantidadeDisponivel}");
            Console.WriteLine($"Quantidade Vendida: {QuantidadeVendida}");
        }
    }
}