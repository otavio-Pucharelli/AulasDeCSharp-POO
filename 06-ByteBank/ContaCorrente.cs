namespace _06_ByteBank
{
    public class ContaCorrente//pode se declarar valores padrões nas classes
    {
        public Cliente? Titular { get; set; }
        private int Agencia { get; set; }
        private int Numero { get; set; }
        private double _saldo = 100;



        public double Saldo
        {
            get 
            {
                return _saldo; 
            }
            set 
            {
                if(value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Trasnferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

    }
}

