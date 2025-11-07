namespace Exercicio04
{
    public class GeradorRelatorio
    {
        private string CaminhoRelatorio;

        public GeradorRelatorio(string caminhoRelatorio)
        {
            CaminhoRelatorio = caminhoRelatorio;
        }


        public void GerarLinhaRelatorio(Produto p)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(CaminhoRelatorio, true))
                {
                    string linha = $"{DateTime.Now:dd/MM/yyyy HH:mm:ss} - Produto Adicionado: {p.Nome} | Categoria: {p.Categoria} | Preço: R$ {p.Price:F2} | Data Cadastro: {p.DataCadastro:dd/MM/yyyy}";
                    writer.WriteLine(linha);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao gravar relatório: ");
            }
        }
    }
}
