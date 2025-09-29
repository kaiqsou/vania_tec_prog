Console.WriteLine("Iniciando o Pedido");
Pedido pedido = new Pedido();

// Registra os assinantes - relaciona as classes como se fossem 'triggers'
pedido.OnPedidoPendente += EnviarEmail.EmailPendente; // -= caso não necessite de algum
pedido.OnPedidoPendente += EnviarSMS.SMSPendente;

pedido.OnCriarPedido += EnviarEmail.Email; 
pedido.OnCriarPedido += EnviarSMS.SMS;

// Criar o pedido - ao ser criado, realiza os 'triggers'
pedido.PedidoPendente();
pedido.CriarPedido();

Console.ReadKey();

public delegate void PedidoEvent();
class Pedido
{
    public event PedidoEvent? OnCriarPedido;
    public event PedidoEvent? OnPedidoPendente;
    public void CriarPedido() 
    {
        if (OnCriarPedido != null && OnPedidoPendente != null)
        {
            OnCriarPedido();

            Console.WriteLine("Pedido sendo criado...");
            Console.WriteLine("Finalizando o pedido");
        }  
    }

    public void PedidoPendente() 
    {
        if (OnPedidoPendente != null)
        {
            OnPedidoPendente();
        }
    }
}

class EnviarEmail
{
    public static void Email()
    {
        Console.WriteLine("E-mail confirmado!");
    }

    public static void EmailPendente()
    {
        Console.WriteLine("E-mail enviado! Por favor, confirme.");
    }
}

class EnviarSMS
{
    public static void SMS()
    {
        Console.WriteLine("SMS confirmado!");
    }

    public static void SMSPendente()
    {
        Console.WriteLine("SMS enviado! Por favor, confirme");
    }
}