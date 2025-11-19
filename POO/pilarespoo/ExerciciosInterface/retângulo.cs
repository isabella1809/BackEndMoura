
// Crie duas classes que implementem essa interface: Retangulo e Circulo.
// No programa, peça os valores necessários e exiba a área calculada para cada forma.
// No Retângulo utilizar o cálculo Area Area = Largura * Altura;
// No Círculo utilizar o cálculo Area = PI * Raio * Raio;
// Extra: Pesquisar sobre a classe Math do C# e utilizar a constante PI - Math.PI

namespace ExerciciosInterface
{
    public class retângulo : IForma
    {
        public float Largura;
        public float Altura;


        public retângulo(float largura, float altura)
        {
            Largura = largura;

            Altura = altura;
        }
        public void CalcularArea()
        {
            float Area = Largura * Altura;
            Console.WriteLine($"Area do retângulo: {Area}");
            
        }
    }
}