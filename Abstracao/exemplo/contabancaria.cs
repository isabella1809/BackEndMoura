
namespace exemplo
{
    public abstract class contabancaria
    {  public double Saldo;

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public abstract void Sacar(double valor);
    }
}


