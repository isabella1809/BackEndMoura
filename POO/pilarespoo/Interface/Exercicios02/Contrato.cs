

namespace Exercicios02
{
    public class Contrato : IImprimivel
    {
        public string Nome;

        public string textoClausulas;

        
        public void Imprimir()
        {
           Console.WriteLine($@"
           cantratante:{Nome}
           clausulas: {textoClausulas}
           
           ");
           
        }
    }
}