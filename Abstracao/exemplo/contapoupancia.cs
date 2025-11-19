
namespace exemplo
{
    public class contapoupancia : contabancaria
    {
         public override void Sacar(double valor)
        {
            double taxa = 5.0;
            Saldo -= (valor + taxa);
        }
    }
}