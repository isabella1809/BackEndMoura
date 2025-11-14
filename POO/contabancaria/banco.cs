
// Crie uma classe ContaBancaria com titular e saldo.
// Faça dois construtores:
// Um que define o titular e saldo inicial.
// Outro que define apenas o titular (saldo começa com zero).
namespace contabancaria
{
    public class banco
    {
        public string titular;

        public double saldo = 0;

        //   public void ExibirDados()
        //     {
        //         Console.WriteLine($" titular da conta: {titular}, saldo bancario: {saldo} ");

        //     }

        //     public banco(string T, double S)
        //     {
        //         titular = T;
        //         saldo = S;
        //     } 


         public void ExibirDados()
        {
             Console.WriteLine($" titular da conta: {titular}");

        }
    }
}