
// Crie duas classes que implementem essa interface: Retangulo e Circulo.
// No programa, peça os valores necessários e exiba a área calculada para cada forma.
// No Retângulo utilizar o cálculo Area Area = Largura * Altura;
// No Círculo utilizar o cálculo Area = PI * Raio * Raio;
// Extra: Pesquisar sobre a classe Math do C# e utilizar a constante PI - Math.PI

namespace ExerciciosInterface
{
    public class Círculo : IForma
    {
       
        public  float PI = 3.14f;
        public  float Raio;
        

        public void CalcularArea()
        {
            float Area = PI * Raio * Raio;
            Console.WriteLine($"Area do circulo é: {Area}");
            
        }
    }
}