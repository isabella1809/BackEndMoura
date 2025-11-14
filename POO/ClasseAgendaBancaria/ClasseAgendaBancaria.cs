namespace ClasseAgendaBancaria
{
    public class ClasseAgendaBancaria
    {
        public string titular;

        public float saldo;

        public void depositar(float valor)
        {
            saldo += valor;
            Console.WriteLine($"Deposito efetuado com sucesso");
            Console.WriteLine($"saldo atualizado: {saldo}");
        }

        public void sacar(float valor)
        {
            saldo -= valor;
            Console.WriteLine($"saque realizado com ");
            Console.WriteLine($"novo saldo: {saldo}");
            
            
        }
    }
}