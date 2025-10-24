  int opcao = -1;

do
{

    Console.Clear();
    Console.WriteLine($"--------------------------------------------");
    Console.WriteLine($"                Bem vindo                   ");
    Console.WriteLine($"                   ao                       ");
    Console.WriteLine($"                Festa Japa                  ");
    Console.WriteLine($"--------------------------------------------");
    Console.WriteLine();
    Console.WriteLine();


    Console.WriteLine($"escolha uma das opção abaixo");
    Console.WriteLine();
    Console.WriteLine($" 1) hot holl ............................... R$ 29,90");
    Console.WriteLine($" 2) temaki   ............................... R$ 30,00");
    Console.WriteLine($" 3) sashimi  ............................... R$ 67,20");
    Console.WriteLine($" 4) yakisoba ............................... R$ 35,90");
    Console.WriteLine($" 5) guioza   ............................... R$ 49,00");
    Console.WriteLine($" 6) shimeji  ............................... R$ 50,00");
    Console.WriteLine($" 0) Sair");
    Console.Write($"Opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"saindo ...");

            break;
        case 1:
            HotHoll ();
            break;
        case 2:
            temaki();
            
            break;
        case 3:
            sashimi();
            break;
          
        case 4:
            yakisoba();
            break;
        case 5:
            guioza();
            break;
        case 6:
            shimeji();
            break;
        default:
            Console.WriteLine($"Opção invalálida");
            break;

    }
    Console.WriteLine($"digite <entrer> para continuar");
    Console.ReadLine();

} while (opcao != 0);

void HotHoll ()
{
    Console.WriteLine($"Boa escolha, vamos prepara seu HotHoll com carinho");
}
void temaki ()
{
    Console.WriteLine($"Boa escolha, vamos prepara seu temaki com carinho");
}
void sashimi ()
{
    Console.WriteLine($"Boa escolha, vamos prepara seu sashimi com carinho");
}
void yakisoba ()
{
    Console.WriteLine($"Boa escolha, vamos prepara seu yakisoba com carinho");
}
void guioza ()
{
    Console.WriteLine($"Boa escolha, vamos prepara seu guioza com carinho");
  }
void shimeji ()
{
 Console.WriteLine($"Boa escolha, vamos prepara seu shimeji com carinho");}



