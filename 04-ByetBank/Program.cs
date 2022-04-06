ContaCorrente contaDoBruno = new ContaCorrente();

contaDoBruno.titular = "Bruno";

Console.WriteLine(contaDoBruno.saldo);

/*bool resultadoSaque = contaDoBruno.Sacar(50);

Console.WriteLine(contaDoBruno.saldo);
Console.WriteLine(resultadoSaque);
*/
contaDoBruno.Depositar(500);
Console.WriteLine(contaDoBruno.saldo);

ContaCorrente contaDaGabriela = new ContaCorrente();

contaDaGabriela.titular = "Gabriela";

contaDoBruno.Trasnferir(200, contaDaGabriela);

Console.WriteLine(contaDoBruno.saldo);
Console.WriteLine(contaDaGabriela.saldo);