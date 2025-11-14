//criar um menu igual ao menu abaixo:

//=== SISTEMA BANCARIO SIMPLES ===
// 1. Cadastrar Cliente
// 2. Depositar
// 3. Sacar
// 4. Transferir
// 5. Listar Clientes
// 0. Sair

//criar a variavel de opcao do menu 
//criar a estrutura do while
//dentro da estrututura do while, criar ao menu, e ao final exibir uma mensagem;
//"Pressione ENTER para continuar..." e fazer o sistema parar até o usuário digitar o <ENTER>
string[] nomes = new string[10];
float[] saldos = new float[10];
int totalclientes = 0;

Console.WriteLine();
Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine($"                       Bem Vindo                       ");
Console.WriteLine($"                          ao                           ");
Console.WriteLine($"                     Agencia Moura                     ");
Console.WriteLine($"-------------------------------------------------------");
Console.WriteLine();

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"escolha uma opcao:");
    Console.WriteLine($"1)  Cadastrar Cliente");
    Console.WriteLine($"2)  Depositar");
    Console.WriteLine($"3)  Sacar");
    Console.WriteLine($"4)  Transferir");
    Console.WriteLine($"5)  Listar Clientes");
    Console.WriteLine($"0)  Sair");
    Console.Write($"digite a opção: ");
    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine($"Pressione <enter> Para continuar ...");

    switch (opcao)
    {
        case 1:
            cadastrarcliente();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            Transferir();
            break;
        case 5:
             ListarClientes();
            break;
        case 0:
             Sair();
            break;
        default:
        Console.WriteLine($"opção invalida");
        
            break;
    }
    
} while (opcao != 0);

void cadastrarcliente()
{
    Console.WriteLine($"função cadastrar cliente em desenvolvimento");
    if (totalclientes >= 10)
    {
        Console.WriteLine($"limite de clientes atingido");
        return;
    }
    Console.WriteLine($"nome do criente: ");
    nomes[totalclientes] = Console.ReadLine();
    saldos[totalclientes] = 0;
    totalclientes++;
    Console.WriteLine($"cliente cadastrado com sucesso");
     
}
void Depositar()
{
    Console.WriteLine($"função Depositar em desenvolvimento");
    
}
void Sacar()
{
    Console.WriteLine($"função Sacar em desenvolvimento");
    
}
void Transferir()
{
    Console.WriteLine($"função Transferir em desenvolvimento");
    
}
void  ListarClientes()
{
    Console.WriteLine($"==== lista de clientes ====");

}
void Sair()
{
    Console.WriteLine($"função Sair em desenvolvimento");
    
}

