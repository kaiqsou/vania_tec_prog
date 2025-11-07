using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Exercicio05
{
    public delegate void OcorrenciaHandler(Ocorrencia o);
    public class CentralDeOcorrencias
    {
        public event OcorrenciaHandler OcorrenciaRegistrada;
        public List<Ocorrencia> Ocorrencias { get; set; } = new List<Ocorrencia>();

        public CentralDeOcorrencias()
        {
            CarregarJson();
        }

        public void Registrar(Ocorrencia o)
        {
            if (o == null) return;

            Ocorrencias.Add(o);
            OcorrenciaRegistrada.Invoke(o);
        }

        public void SalvarJson()
        {
            if (Ocorrencias.Count == 0) return;

            string caminho = "ocorrencias.json";

            string jsonString = JsonSerializer.Serialize(Ocorrencias, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            });

            File.WriteAllText(caminho, jsonString);
        }

        public void CarregarJson()
        {
            string caminho = "ocorrencias.json";

            if (File.Exists(caminho))
            {
                string conteudoJson = File.ReadAllText(caminho);
                var users = JsonSerializer.Deserialize<List<Ocorrencia>>(conteudoJson);

                if (users != null)
                {
                    Ocorrencias.AddRange(users);
                }
            }
        }

        public void ListarOcorrencias()
        {
            if (Ocorrencias.Count == 0)
            {
                Console.WriteLine("\nNenhuma ocorrência registrada!");
                return;
            }

            foreach (var ocorrencia in Ocorrencias)
            {
                string urgencia = string.Empty;

                if (ocorrencia.Urgente) urgencia = "Sim"; else urgencia = "Não";

                Console.WriteLine($"\nTipo: {ocorrencia.Tipo}");
                Console.WriteLine($"Local: {ocorrencia.Local}");
                Console.WriteLine($"Urgente: {urgencia}");
                Console.WriteLine($"Data de Registro: {ocorrencia.Data}");;
            }
        }

        public void ListarOcorrenciasFiltradas(List<Ocorrencia> ocorrencias)
        {
            if (Ocorrencias.Count == 0)
            {
                Console.WriteLine("\nNenhuma ocorrência registrada!");
                return;
            }

            foreach (var ocorrencia in ocorrencias)
            {
                string urgencia = string.Empty;

                if (ocorrencia.Urgente) urgencia = "Sim"; else urgencia = "Não";

                Console.WriteLine($"Tipo: {ocorrencia.Tipo}");
                Console.WriteLine($"Local: {ocorrencia.Local}");
                Console.WriteLine($"Urgente: {urgencia}");
                Console.WriteLine($"Data de Registro: {ocorrencia.Data}\n");
            }
        }
    }
}
