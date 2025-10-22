//Faça um programa que solicite ao usuário um número de repetições “x”. Para cada repetição solicite dois números e imprima qual é o maior deles.
int numero;
int contador = 1;
int n1,n2;

Console.WriteLine("quantos numeros vc quer digitar");
numero = int.Parse(Console.ReadLine());

while (contador <= numero)
{
    Console.WriteLine("digite o primeiro numero");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("digite o segundo numero");
    n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($"o numero {n1} é maior que {n2}");
    }
    else if (n2 > n1)
    {
        Console.WriteLine($"o numero {n2} é maior que {n1}");
    }
    else if (n1 == n2)
    {
        Console.WriteLine("os dois numeros sao iguais");
    }
    contador++;
}


