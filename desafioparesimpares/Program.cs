using System.Net.WebSockets;
Console.WriteLine($"olá usuario, quantos numeros vc quer digitar");
int qtdnumeros = int.Parse(Console.ReadLine());
string pares = "pares: ";
string impares = "impares:";
int numerodigitado = 0;

for (int i = 1; i < qtdnumeros; i++)
{
    Console.WriteLine($"qual é a {i}ª numero?");
    numerodigitado = int.Parse(Console.ReadLine());

    if (numerodigitado % 2 == 0)
    {
        pares += numerodigitado.ToString() + ", ";
    }
    else
    {
        impares += numerodigitado.ToString() + ", ";
    }
}



Console.Clear();
Console.WriteLine($"RESULTADO:");
Console.WriteLine();
Console.WriteLine(pares);
Console.WriteLine(impares);