try 
{
    HttpClient client = new HttpClient();
    // var cliente = new HttpClient();
    HttpResponseMessage response = client.GetAsync("https://fatecjahu.edu.br/").Result; // url a ser encontrada

    // se encontrar, entra aqui
    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine($"Acesso: {response.StatusCode}");
        Console.WriteLine($"Código: {(int) response.StatusCode}"); // cast do código
    }
    else
    {
        // se não encontrar, lança uma exceção
        throw new HttpRequestException("Erro: " + (int) response.StatusCode);
    }
}
// exceção com condicional, para quando a mensagem for 404 (NotFound)
catch (HttpRequestException e) when (e.Message.Contains("404"))
{ 
    Console.WriteLine("Página não encontrada!");
}
finally
{
    Console.WriteLine("Fim da requisição");
}