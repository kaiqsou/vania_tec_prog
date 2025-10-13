A.ProcessarA();

class A
{
    public static void ProcessarA()
    {
        B.ProcessarB();
    }
}

// Tratando exceção no B
class B
{
    public static void ProcessarB()
    {
        try
        {
            C.ProcessarC();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

class C
{
    public static void ProcessarC()
    {
        // o throw está lançando uma exceção caso não encontre um tratamento de exceção
        throw new NotImplementedException("Método não implementado");
    }
}