int contador = 1;
Console.WriteLine($"quantas vezes você quer rodar o while?");

int qtdvezes = int.Parse(Console.ReadLine());
while (contador <= qtdvezes)
{
    Console.WriteLine($"contador é: {contador}");
    contador++;
}