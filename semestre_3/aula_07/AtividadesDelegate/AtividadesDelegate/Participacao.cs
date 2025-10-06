using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDelegate
{
    class Participacao
    {
        public string Aluno { get; set; }
        public string Evento { get; set; }
        public DateTime Data { get; set; }
        public int CargaHoraria { get; set; }

        public Participacao(string aluno, string evento, DateTime data, int cargaHoraria)
        {
            Aluno = aluno;
            Evento = evento;
            Data = data;
            CargaHoraria = cargaHoraria;
        }
    }
}
