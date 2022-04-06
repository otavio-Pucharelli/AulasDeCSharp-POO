ContaCorrente contaDaGabriela = new ContaCorrente();

contaDaGabriela.titular = "Gabriela";
contaDaGabriela.agencia = 863;
contaDaGabriela.numero = 836452;

ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

contaDaGabriela.titular = "Gabriela";
contaDaGabriela.agencia = 863;
contaDaGabriela.numero = 836452;

Console.WriteLine("Igualdade de tipo de referencia: " + (contaDaGabriela == contaDaGabrielaCosta));//classes contaDaGabriela

int numero = 30;
int numero2 = 30;

Console.WriteLine("Igualdade de tipo de valor: " + (numero == numero2));// 30 == 30


contaDaGabriela = contaDaGabrielaCosta;

Console.WriteLine("igualde de tipo de referencia após atribuição: " + (contaDaGabriela == contaDaGabrielaCosta));

contaDaGabriela.saldo = 300;

Console.WriteLine("log do saldo da conta atualizado: " + (contaDaGabrielaCosta.saldo));