// Forma 1
MeuDelegate del1 = new MeuDelegate(MeuMetodo);

// Forma 2
MeuDelegate del2 = MeuMetodo;

// Forma 3
MeuDelegate del3 = (msg) => { return msg; };

del1("Bom dia");
del2("Boa tarde");
del3("Boa noite");

// Assinatura: mesmo retorno e tipo de parâmetro
static string MeuMetodo(string mensagem)
{
    return mensagem;
}

Console.ReadKey();

// Sem o MAIN, o Delegate deve ficar aqui embaixo
public delegate string MeuDelegate(string msg);