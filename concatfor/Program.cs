int qtdletras = 0;

Console.WriteLine($"olá usuario, quantas letras tem seu nome");
qtdletras = int.Parse(Console.ReadLine());
string nome = "";

for (int i = 1; i <= qtdletras; i++)
{
    Console.WriteLine($"qual é a {i}ª letra?");
    nome += Console.ReadLine();
}
Console.WriteLine($"seu nome é {nome}");
