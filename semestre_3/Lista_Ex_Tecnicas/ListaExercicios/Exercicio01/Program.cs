// Criar o sistema de energia
using Exercicio01;

var sistema = new SistemaEnergia();

// Configurar gerenciador de alertas (assina os eventos)
var gerenciador = new GerenciadorAlertas(sistema);

// Criar dispositivos elétricos
var arCondicionado = new DispositivoEletrico
{
    Nome = "Ar Condicionado",
    ConsumoPorUso = 800,
    Ativo = true,
    SistemaEnergia = sistema
};

var geladeira = new DispositivoEletrico
{
    Nome = "Geladeira",
    ConsumoPorUso = 150,
    Ativo = true,
    SistemaEnergia = sistema
};

var computador = new DispositivoEletrico
{
    Nome = "Computador",
    ConsumoPorUso = 300,
    Ativo = true,
    SistemaEnergia = sistema
};

var chuveiro = new DispositivoEletrico
{
    Nome = "Chuveiro",
    ConsumoPorUso = 600,
    Ativo = true,
    SistemaEnergia = sistema
};

// Adicionar dispositivos ao sistema
sistema.DispositivoEletricos.Add(arCondicionado);
sistema.DispositivoEletricos.Add(geladeira);
sistema.DispositivoEletricos.Add(computador);
sistema.DispositivoEletricos.Add(chuveiro);

// Simular uso dos dispositivos
Console.WriteLine("=== SIMULAÇÃO DE CONSUMO DE ENERGIA ===");
Console.WriteLine();

geladeira.Usar();        // 150W
computador.Usar();       // 300W (total: 450W)
arCondicionado.Usar();   // 800W (total: 1250W) -> DISPARA EVENTO!
chuveiro.Usar();         // 5500W (total: 6750W) -> DISPARA EVENTO NOVAMENTE!