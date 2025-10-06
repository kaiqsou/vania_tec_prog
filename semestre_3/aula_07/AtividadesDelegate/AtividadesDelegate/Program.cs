using AtividadesDelegate;

Participacao participacao = new Participacao("Kaique", "Palestra", DateTime.Now, 10);
Participacao part2 = new Participacao("Kaique", "Congresso", DateTime.Now, 15);
RegistroAcademico registro = new RegistroAcademico();

// Registra os assinantes
//participacao.OnCriar += RegistroAcademico.Registrar;

registro.OnRegistrar += ParticipacaoRegistrada.Registrar;
registro.OnRegistrar += ParticipacaoRegistrada.Exibir;

registro.Registrar(participacao);
registro.Registrar(part2);

