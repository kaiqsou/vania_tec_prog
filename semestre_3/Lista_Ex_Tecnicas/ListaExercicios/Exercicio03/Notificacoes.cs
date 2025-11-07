namespace Exercicio03
{
    public static class Notificacoes
    {
        public static void NovoUsuario(Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine($"--- SUCESSO ---\n");
            Console.WriteLine($"Novo usuário: {usuario.Nome}, cadastrado em {usuario.DataCadastro}");
        }

        public static void SalvarLog(Usuario usuario)
        {
            var caminho = "log.txt";
            var mensagem = $"Novo usuário: {usuario.Nome}, cadastrado em {usuario.DataCadastro}\n";

            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, mensagem); // se o arquivo não existir, ele é criado
                return;
            }

            File.AppendAllText(caminho, mensagem); // acrescenta no log.txt, se o arquivo já existir
        }
    }
}

