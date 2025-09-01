using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_01
{
    internal class FuncionarioMensalista : ISalario
    {
        public double Desconto { get; set; }
        public double Salario { get; set; }
        public double CalcularSalario()
        {
            var salario = Salario - Desconto;

            return salario;
        }
    }
}
