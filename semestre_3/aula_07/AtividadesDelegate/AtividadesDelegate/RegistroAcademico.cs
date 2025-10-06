using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDelegate
{
    class RegistroAcademico
    {
        public event EventHandler<RegistroEventArgs>? OnRegistrar;
        public ICollection<Participacao> Participacoes { get; set; } = new List<Participacao>();

        public void Registrar(Participacao p)
        {
            if (OnRegistrar != null)
            {
                Participacoes.Add(p);

                OnRegistrar(this, new RegistroEventArgs
                {
                    Aluno = p.Aluno,
                    Evento = p.Evento,
                });

                if (p.CargaHoraria > 10)
                {
                    Console.WriteLine($"Participação com carga horária relevante: {p.CargaHoraria} horas");
                }
            }
        }
    }
}
