using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01
{
    class Aluno
    {
        public string Nome { get; set; }
        public List<Prova> Provas { get; set; } = new List<Prova>();
        public Aluno(string nome)
        {
            Nome = nome;
        }

        public void AdicionarProva(Prova prova)
        {
            Provas.Add(prova);
        }
    }
}
