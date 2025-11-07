namespace Exercicio01
{
    public class GerenciadorAlertas
    {
        private SistemaEnergia SistemaEnergia;
        public GerenciadorAlertas(SistemaEnergia sistemaEnergia)
        {
            SistemaEnergia = sistemaEnergia;
            // Assinar o evento
            SistemaEnergia.ConsumoElevado += ExibirAlertaConsole;
            SistemaEnergia.ConsumoElevado += DesligarDispositivosAutomaticamente;
        }

        // Método assinante 1: Exibir alerta no console
        private void ExibirAlertaConsole(string nomeDispositivo, double consumoAtual)
        {
            Console.WriteLine($"ALERTA DE CONSUMO ELEVADO!");
            Console.WriteLine($"Consumo total: {consumoAtual}W");
            Console.WriteLine($"Dispositivo de maior consumo: {nomeDispositivo}");
            Console.WriteLine($"Limite: {SistemaEnergia.ConsumoLimite}W");
            Console.WriteLine();
        }

        // Método assinante 2: Simular desligamento automático
        private void DesligarDispositivosAutomaticamente(string nomeDispositivo, double consumoAtual)
        {
            Console.WriteLine("Iniciando desligamento automático de dispositivos...");
            SistemaEnergia.DesligarDispositivosAltoConsumo();
            Console.WriteLine($"Consumo após desligamento: {SistemaEnergia.ConsumoTotal}W");
            Console.WriteLine();
        }
    }
}
