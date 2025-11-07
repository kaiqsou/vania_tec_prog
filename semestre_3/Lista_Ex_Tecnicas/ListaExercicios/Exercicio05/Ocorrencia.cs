namespace Exercicio05
{
    public class Ocorrencia
    {
        public string Tipo { get; set; }
        public string Local { get; set; }
        public bool Urgente { get; set; } = false;
        public DateTime Data { get; set; }

        public Ocorrencia(string tipo, string local, bool urgente) 
        {
            Tipo = tipo;
            Local = local;
            Urgente = urgente;
            Data = DateTime.Now;
        }
    }
}
