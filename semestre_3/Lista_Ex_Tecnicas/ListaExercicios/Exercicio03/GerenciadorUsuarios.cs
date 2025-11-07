using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Exercicio03
{
    public delegate void NotificacaoHandler(Usuario usuario);
    public class GerenciadorUsuarios
    {
        // Criação do evento de novo usuário cadastrado
        public event NotificacaoHandler UsuarioCadastrado;
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();

        public GerenciadorUsuarios()
        {
            DesserializarJson(); // Carregar usuários do JSON ao iniciar
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            if (usuario == null) return;

            Usuarios.Add(usuario);

            // Disparando o evento para exibir mensagem de novo usuário cadastrado, passa o usuário inteiro para o evento de UsuarioCadastrado
            // Ele será usado no Program.cs posteriormente
            UsuarioCadastrado.Invoke(usuario);
        }

        public void SerializarJson()
        {
            if (Usuarios.Count == 0) return;

            Console.WriteLine($"--- SUCESSO ---\n");

            string caminho = "usuarios.json";

            string jsonString = JsonSerializer.Serialize(Usuarios, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            });

            File.WriteAllText(caminho, jsonString);
        }

        public void DesserializarJson()
        {
            string caminho = "usuarios.json";

            if (File.Exists(caminho))
            {
                string conteudoJson = File.ReadAllText(caminho);
                var users = JsonSerializer.Deserialize<List<Usuario>>(conteudoJson);

                if (users != null)
                {
                    Usuarios.AddRange(users); // adiciona uma lista de novos usuários no final da propriedade Usuarios
                }
            }
        }

        public void ExibirUsuarios()
        {
            Console.Clear();
            Console.WriteLine($"--- Lista de Usuários ---");

            if (Usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário cadastrado!");
                return;
            }

            foreach (var user in Usuarios)
            {
                Console.WriteLine($"\nNome: {user.Nome}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"Idade: {user.Idade}");
                Console.WriteLine($"Data de Cadastro: {user.DataCadastro}");
            }
        }

        public void ExibirUsuarioFiltrado(List<Usuario> usuarios)
        {
            if (Usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário cadastrado!");
                return;
            }

            foreach (var user in usuarios)
            {
                Console.WriteLine($"Nome: {user.Nome}");
                Console.WriteLine($"E-mail: {user.Email}");
                Console.WriteLine($"Idade: {user.Idade} anos");
                Console.WriteLine($"Data de Cadastro: {user.DataCadastro}\n");
            }
        }
    }
}
