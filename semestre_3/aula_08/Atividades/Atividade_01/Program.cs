// 1. Um sistema que calcula a média de um aluno com base em duas notas.
// Se a quantidade de provas for 0, trata a exceção.

using Atividade_01;

var aluno = new Aluno("Kaique");

aluno.AdicionarProva(new Prova(aluno, 10));
aluno.AdicionarProva(new Prova(aluno, 7));

float Media(ICollection<Prova> provas)
{
    if (provas.Count == 0)
    {
        throw new Exception("Não há provas");
    }

    float total = 0;

    foreach (var prova in provas)
    {
        total += prova.Nota;
    }

    return total / provas.Count;
}

try
{
    Console.WriteLine(Media(aluno.Provas));
}
catch (Exception e)
{
    Console.WriteLine($"{e.Message}");
}
