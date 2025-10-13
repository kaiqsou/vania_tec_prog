try
{
    Console.WriteLine("Digite o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = dividendo / divisor;
    Console.WriteLine($"Divisão de {dividendo} por {divisor}: {resultado}");
}
catch(FormatException) // exceção de formatação
{
    Console.Clear();
    Console.WriteLine("Digite um número inteiro!");
}
catch(Exception ex) when (ex.Message.Contains("format")) // exceção com condicional
{
    Console.WriteLine(ex.Message);
}
catch(OverflowException) // exceção de limite
{
    Console.Clear();
    Console.WriteLine("Digite um número entre 1 e 9999!");
}
catch(DivideByZeroException) // exceção de divisão por zero
{
    Console.Clear();
    Console.WriteLine("O divisor não pode ser 0!");
}
finally
{
    Console.WriteLine("A divisão terminou!");
}