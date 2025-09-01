using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_01
{
    // 1. Crie uma interface chamada ISalario que tenha um método: 
    // - double CalcularSalario();
    internal interface ISalario
    {
        public double Desconto { get; set; }
        public double CalcularSalario();
    }
}
