namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.CPF = "187.755.268-59";
            cliente.Profissao = "desenvolvedor";

            conta.Saldo = -10;
            conta.Titular = cliente; 
            
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
        }
    }
}