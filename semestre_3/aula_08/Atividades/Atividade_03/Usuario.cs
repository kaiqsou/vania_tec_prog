namespace Atividade_03
{
    class Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Usuario(string nome, int idade)
        {
            if (idade < 0 || idade > 150) throw new IdadeInvalidaException();

            Nome = nome;
            Idade = idade;
        }
    }
}
