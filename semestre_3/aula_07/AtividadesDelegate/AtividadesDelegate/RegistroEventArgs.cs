using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDelegate
{
    class RegistroEventArgs : EventArgs
    {
        public string? Aluno { get; set; }
        public string? Evento { get; set; }
    }
}
