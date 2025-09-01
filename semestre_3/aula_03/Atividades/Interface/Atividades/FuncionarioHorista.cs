using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_01
{
    // a. Criar duas classes que implementem a interface:
    // - FuncionarioHorista: salário baseado em horas trabalhadas e valor por hora.
    // - FuncionarioMensalista: salário fixo mensal.
    internal class FuncionarioHorista : ISalario
    {
        public double Desconto { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }

        public FuncionarioHorista(double desconto, int horas, double valorHora)
        {
            Desconto = desconto;
            HorasTrabalhadas = horas;
            ValorHora = valorHora;
        }

        public double CalcularSalario()
        {
            var salario = (ValorHora * HorasTrabalhadas) - Desconto;

            return salario;
        }
    }
}
