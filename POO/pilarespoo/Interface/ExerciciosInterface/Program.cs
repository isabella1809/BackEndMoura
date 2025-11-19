// No Retângulo utilizar o cálculo Area Area = Largura * Altura;
// No Círculo utilizar o cálculo Area = PI * Raio * Raio;
// Extra: Pesquisar sobre a classe Math do C# e utilizar a constante PI - Math.PI
using ExerciciosInterface;

Console.Clear();
Console.WriteLine($"Bem vindo ao programa de Geometria");
Console.WriteLine();

Console.WriteLine($"Vamos calcular a área do retangulo!");

Console.WriteLine($"Informe a altura:");
float altura = float.Parse(Console.ReadLine());
Console.WriteLine($"Informe a largura: ");
float largura = float.Parse(Console.ReadLine());

retângulo retangulo = new retângulo(largura, altura);
Console.WriteLine();

Console.WriteLine($"Agora vamos calcular a área do circulo");
Console.WriteLine($"Informe o raio do circulo");
float raio = float.Parse(Console.ReadLine());

Círculo circulo = new Círculo();
circulo.Raio = raio;

retangulo.CalcularArea();
circulo.CalcularArea();
