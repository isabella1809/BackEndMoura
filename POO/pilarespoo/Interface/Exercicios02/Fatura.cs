
using System.Security.Cryptography.X509Certificates;

namespace Exercicios02
{
    public class Fatura : IImprimivel
    {
        public string devedor = "";

        public string credor = "";

        public float valor = 0; 
        public int diasAtraso = 0;
        private float juros = 0.10f;

        public Fatura (string nomedevedor, string nomeempresa, float valorfatura, int qtdDiasAtraso)
        {
            devedor = nomedevedor;
            credor = nomeempresa;
            valor = valorfatura;
            diasAtraso = qtdDiasAtraso;
        }

        public void calcularValorDividas()
        {
            if (diasAtraso > 0)
            {
                valor = valor + diasAtraso* juros;
            }

            if (diasAtraso >= 5)
            {
              Console.WriteLine($"divida encaminhada paa o SERASA");
              
            }
        }

        public void Imprimir()    
        {
    
            Console.WriteLine($@"
            credor: {credor}
            devedo: {devedor}
            dias de atraso: {diasAtraso}
            juros: r${juros * diasAtraso}
            valor total:{valor}");
        }
    }
}