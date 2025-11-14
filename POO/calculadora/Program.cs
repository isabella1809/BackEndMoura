using calculator;

int opcao;
do
{
    
    Console.Clear();

    Calculator calc = new Calculator();

    Console.WriteLine($"-------------------------------------------------------------");
    Console.WriteLine($"                                                             ");
    Console.WriteLine($"                            Bem                              ");
    Console.WriteLine($"                          vindo(a)                           ");
    Console.WriteLine($"                                                             ");
    Console.WriteLine($"-------------------------------------------------------------");

    Console.WriteLine($"escolha uma das opção abaixo");
    Console.WriteLine();
    Console.WriteLine($"1) Somar");
    Console.WriteLine($"2) Subtrair");
    Console.WriteLine($"3) Multiplicar");
    Console.WriteLine($"4) Dividir");
    Console.Write($"Opção: ");
    opcao = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o primeiro numero");
    calc.numero1 = double.Parse(Console.ReadLine());
Console.WriteLine($"Digite o segundo numero");
   calc.numero2 = double.Parse(Console.ReadLine());
    

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"saindo ...");

            break;
        case 1:
            somar();
            break;
        case 2:
            Subtrair();

            break;
        case 3:
            Multiplicar();
            break;

        case 4:
            Dividir();
            break;
        default:
            Console.WriteLine($"Opção invalálida");
            break;

    }
    Console.WriteLine($"digite <entrer> para continuar");
    Console.ReadLine();

void somar ()
{
  Console.WriteLine($"somar {calc.somar()}");
Console.WriteLine();
}
void Subtrair ()
{
   Console.WriteLine($"subtrair {calc.subtrair()}");
Console.WriteLine();
}
void Multiplicar ()
{
   Console.WriteLine($"multiplicar{calc.multiplicar()}");
Console.WriteLine();
}
void Dividir ()
{
   Console.WriteLine($"dividir{calc.dividir()} ");
Console.WriteLine();
}  
} while (opcao != 0);

