ContaBancaria conta = new ContaBancaria(300.00m);

try
{
    conta.Sacar("100");
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine($"Erro de Saldo: {ex.Message}");
}

try
{
    conta.Sacar("500");
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine($"Erro de Saldo: {ex.Message}");
}
try 
{
    conta.Sacar("testedeerro");
}
catch (ApplicationException ex)
{
    Console.WriteLine(ex.Message);
}

class SaldoInsuficienteException : Exception
{
    // Três construtores comuns

    // 1. Vazio
    public SaldoInsuficienteException(){}

    // 2. Apenas mensagem
    public SaldoInsuficienteException(string mensagem) : base(mensagem){}
    
    // 3. Mensagem e InnerException
    public SaldoInsuficienteException(string mensagem, Exception innerException){}
}
class ContaBancaria 
{
    public decimal Saldo { get; private set; }

    public ContaBancaria(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public void Sacar(string valorTexto)
    {
        try
        {
            decimal valor = decimal.Parse(valorTexto);

            if (valor > Saldo)
            {
                throw new SaldoInsuficienteException($"Saldo insuficiente. Saldo atual: R${Saldo}. " +
                    $"Tentativa de saque no valor de R${valor}");
            }

            Saldo -= valor;
            Console.WriteLine($"Saldo atual: R${Saldo}");
        }
        catch(FormatException ex)
        {
            throw new ApplicationException("Erro ao converter o valor do saque", ex);
        }
        finally
        {
            Console.WriteLine("Fim do saque");
        }
    }
}