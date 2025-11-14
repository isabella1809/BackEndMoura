
namespace Abstracao
{
    public class Contapoupanca : ContaBancaria
    {
           public override void Sacar(double valor)
        {
            double taxa = 1.0;
            Saldo -= (valor + taxa);
        }
    }
}