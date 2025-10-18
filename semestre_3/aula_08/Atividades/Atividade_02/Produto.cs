using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_02
{
    class Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, string descricao, int quantidade, double preco)
        {
            // Regras de negócio
            if (nome.Length == 0) throw new Exception("O nome é obrigatório!");
            if (nome.All(char.IsDigit)) throw new Exception("O nome não pode possuir apenas números!");
            if (descricao.Length == 0) throw new Exception("A descrição é obrigatória!");
            if (descricao.All(char.IsDigit)) throw new Exception("A descrição não pode possuir apenas números!");
            if (quantidade <= 0) throw new Exception("A quantidade deve ser maior do que 0!");
            if (preco <= 0) throw new Exception("O preço deve ser maior do que 0!");

            Nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;
            Preco = preco;
        }

        public void Exibir()
        {
            Console.WriteLine($"\nProduto: {Nome}");
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Quantidade: {Quantidade}");
            Console.WriteLine($"Preço: {Preco}");
        }
    }
}
