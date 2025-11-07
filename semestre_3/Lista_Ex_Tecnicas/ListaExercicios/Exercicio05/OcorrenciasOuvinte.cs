namespace Exercicio05
{
    public static class OcorrenciasOuvinte
    {
        public static void GravarLog(Ocorrencia o)
        {
            var caminho = "ocorrencias.txt";
            var mensagem = $"Nova ocorrência do tipo [{o.Tipo}] em {o.Local}! Registrada em: {o.Data}\n";

            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, mensagem);
                return;
            }

            File.AppendAllText(caminho, mensagem);
        }

        public static void ExibirAlertasConsole(Ocorrencia o)
        {
            Console.Clear();

            if (o.Urgente)
            {
                Console.WriteLine("--- ALERTA URGENTE! ---");
            }
            
            Console.WriteLine($"Nova ocorrencia registrada!");
            Console.WriteLine($"Tipo: {o.Tipo}");
            Console.WriteLine($"Local: {o.Local}");
            Console.WriteLine($"Data: {o.Data}");
        }
    }
}
