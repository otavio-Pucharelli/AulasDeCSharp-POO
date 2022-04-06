using _05_ByteBank;

Cliente gabriela = new();

gabriela.nome = "gabriela";
gabriela.profissao = "desenvolvedora";
gabriela.cpf = "487.755.268-59";

ContaCorrente conta = new();
//conta.titular = new ContaCorrente();
//conta.titular.


conta.titular = gabriela;
conta.saldo = 100;
conta.agencia = 563;
conta.numero = 5634527;

Console.WriteLine(conta.titular.nome) ;