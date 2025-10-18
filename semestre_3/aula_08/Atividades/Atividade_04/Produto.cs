namespace Atividade_04
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            if (nome.Length == 0) throw new Exception("O nome é obrigatório!");
            if (preco == null) throw new Exception("O preço é obrigatório!");
            if (preco <= 0) throw new PrecoInvalidoError();

            Nome = nome;
            Preco = preco;
        }
    }
}
