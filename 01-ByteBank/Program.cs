ContaCorrente contaDaGabriela = new ContaCorrente();

contaDaGabriela.titular = "Gabriela";
contaDaGabriela.agencia = 863;
contaDaGabriela.numero = 863452;
contaDaGabriela.saldo = 100.52;

Console.WriteLine("titular: " + contaDaGabriela.titular);
Console.WriteLine("agencia: " + contaDaGabriela.agencia);
Console.WriteLine("numero da conta: " + contaDaGabriela.numero);
//Console.WriteLine("saldo: " + contaDaGabriela.saldo);

contaDaGabriela.saldo += 100;

Console.WriteLine("saldo: " + contaDaGabriela.saldo);