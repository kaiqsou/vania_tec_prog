namespace Exercicio03
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public Usuario(string nome, string email, int idade) 
        {
            Nome = nome;
            Email = email;
            Idade = idade;
        }
    }
}
