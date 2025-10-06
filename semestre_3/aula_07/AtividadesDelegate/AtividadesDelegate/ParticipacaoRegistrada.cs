using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesDelegate
{
    class ParticipacaoRegistrada
    {
        public static void Registrar(Object? sender, RegistroEventArgs r)
        {
            //Console.WriteLine(sender);
            Console.WriteLine($"Participação registrada!\n");
        }

        public static void Exibir(Object? sender, RegistroEventArgs r)
        {
            //Console.WriteLine(sender);
            Console.Write($"Nome: {r.Aluno}\nEvento: {r.Evento}\n");
        }
    }
}