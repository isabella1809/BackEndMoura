
namespace Exercicios02
{
    public class Relatorio : IImprimivel
    {
        public string Nomeresponsaveis;

        public string  textorelatorio;
        public void Imprimir()
        {
           Console.WriteLine($@"
           responsavel:{Nomeresponsaveis}
           relatorio: {textorelatorio}
           ");
        }
    }
}