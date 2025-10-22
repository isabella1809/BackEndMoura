Console.WriteLine($"olá usuario, quantos numeros vc quer digitar");
int qtdnumeros = int.Parse(Console.ReadLine());
int contador = 0;
int batata = 0;

while (contador <= qtdnumeros )
{
    Console.WriteLine($"digite um numero?");
    batata = int.Parse(Console.ReadLine());


    if (batata % 2 == 0)
    {
        Console.WriteLine($"numero digitado eh par: {batata}");

    }
    contador++;
}

