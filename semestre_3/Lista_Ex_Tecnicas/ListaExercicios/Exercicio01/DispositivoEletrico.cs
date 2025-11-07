namespace Exercicio01
{
    public class DispositivoEletrico
    {
        public string? Nome { get; set; }
        public int ConsumoPorUso { get; set; }
        public bool Ativo { get; set; }
        public SistemaEnergia SistemaEnergia { get; set; }

        public void Usar()
        {
            if (Ativo)
            {
                SistemaEnergia?.AdicionarConsumo(ConsumoPorUso, this);
                Console.WriteLine($"{Nome} consumiu {ConsumoPorUso}W");
            }
            else
            {
                Console.WriteLine($"{Nome} está desligado e não pode ser usado");
            }
        }
    }
}
