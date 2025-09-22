using exercicio_vania;

Fabrica fabrica1 = new Fabrica("Fabrica 1", "Modelo 1", "15:34", "Máquina 1", DateTime.Now);
fabrica1.ListarMaquinas();

Maquina maquina2 = new Maquina("Modelo 2", "15:04", "Equipamento 2", DateTime.Now);
fabrica1.AdicionarMaquina(maquina2);
Console.WriteLine($"Adicionando a máquina modelo: {maquina2.Modelo}");
fabrica1.ListarMaquinas();
Console.WriteLine($"Buscando a máquina modelo: 'Modelo 2'");
fabrica1.BuscarMaquinaPorModelo("Modelo 2");

var operador = new Operador("José", maquina2);
await operador.OperarMaquinaAsync(fabrica1, "Modelo 2");