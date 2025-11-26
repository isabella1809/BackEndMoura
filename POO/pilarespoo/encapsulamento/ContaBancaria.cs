

namespace encapsulamento
{
    
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }
        public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial > 0)
            {
                Saldo = saldoInicial;
            }else
            {
                Saldo = 0;
            }
        }
        public void Depositar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"valor inválodo");

            }
            else
            {
                 Saldo += valor;
            }
           
        } 

        public float Getsaldo()
        {
           return Saldo;
        }
        public void sacar(float valor)
        {
               if (valor >=0 && valor <= Saldo)
            {
                Saldo = valor;
                Console.WriteLine($"so pode sacar valores positiveis");

            }
            else
            {
                Console.WriteLine($"so pode sacar valores positiveis");
                
            }
            
        }
    }
}