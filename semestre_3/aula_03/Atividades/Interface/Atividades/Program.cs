// b. Criar um programa principal que instancie diferentes tipos de funcionários e exiba seus salários.

using atividade_01;

var funcionarioHorista = new FuncionarioHorista(150, 100, 2.5) { };
double salario = funcionarioHorista.CalcularSalario();

Console.WriteLine(salario);