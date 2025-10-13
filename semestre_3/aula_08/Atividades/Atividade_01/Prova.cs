using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01
{
    class Prova
    {
        public Aluno Aluno {  get; set; }
        public float Nota { get; set; }

        public Prova(Aluno aluno, float nota)
        {
            Aluno = aluno;
            Nota = nota;
        }
    }
}
