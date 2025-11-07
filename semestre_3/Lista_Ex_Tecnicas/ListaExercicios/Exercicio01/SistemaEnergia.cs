namespace Exercicio01
{
    public delegate void AlertaConsumoHandler(string nomeDispositivo, double consumoAtual);
    public class SistemaEnergia
    {
        public int ConsumoLimite = 1000;
        private double consumoTotal = 0;
        public event AlertaConsumoHandler ConsumoElevado;
        public List<DispositivoEletrico> DispositivoEletricos { get; set; } = new List<DispositivoEletrico>();

        public double ConsumoTotal
        {
            get => consumoTotal;
            private set
            {
                consumoTotal = value;

                if (consumoTotal > ConsumoLimite)
                {
                    var dispositivoMaiorConsumo = ObterDispositivoMaiorConsumo();
                    ConsumoElevado?.Invoke(dispositivoMaiorConsumo?.Nome ?? "Desconhecido", consumoTotal);
                }
            }
        }

        public void AdicionarConsumo(int consumo, DispositivoEletrico dispositivo)
        {
            ConsumoTotal += consumo;
        }

        private DispositivoEletrico ObterDispositivoMaiorConsumo()
        {
            return DispositivoEletricos.OrderByDescending(d => d.ConsumoPorUso).FirstOrDefault();
        }

        public void DesligarDispositivosAltoConsumo()
        {
            var dispositivosAltosConsumo = DispositivoEletricos.Where(d => d.Ativo && d.ConsumoPorUso > 200).OrderByDescending(d => d.ConsumoPorUso).ToList();

            foreach (var dispositivo in dispositivosAltosConsumo)
            {
                dispositivo.Ativo = false;
                Console.WriteLine($"Dispositivo {dispositivo.Nome} foi desligado automaticamente!");

                ConsumoTotal -= dispositivo.ConsumoPorUso;

                if (ConsumoTotal <= ConsumoLimite) break;
            }
        }
    }
}
