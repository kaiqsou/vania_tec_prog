// 3. Crie um programa que solicite ao usuário que informe a sua idade.
// Se a idade for menor que 0 ou maior que 150, dispare uma exceção personalizada chamada IdadeInvalidaException.
// Caso contrário, imprima uma mensagem dizendo que a idade foi registrada com sucesso.

using Atividade_03;

try
{
    Console.Write("Informe o seu nome: ");
    string nome = Console.ReadLine();

    Console.Write("Informe a sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    Usuario usuario = new Usuario(nome, idade);

    Console.WriteLine($"\nOlá, {usuario.Nome}! A sua idade foi registrada com sucesso!");
}
catch(IdadeInvalidaException)
{
    Console.WriteLine("Idade inválida!");
}
catch (FormatException)
{
    Console.WriteLine("Por favor, verifique o formato!");
}
finally
{
    Console.WriteLine("\nFim da operação!");
}