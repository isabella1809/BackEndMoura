
namespace exemplo
{
    public class contacorrente : contabancaria
    {
       public override void Sacar(double valor)
        {
            double taxa = 1.0;
            Saldo -= (valor + taxa);
        }  
    }
}