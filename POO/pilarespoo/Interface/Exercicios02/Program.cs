using Exercicios02;


// List<IImprimivel> Documentos = new List<IImprimivel>();

// Fatura fatbella = new Fatura();
// Documentos.Add(fatbella);
// Fatura fatisa = new Fatura();
// Documentos.Add(fatisa);

// Contrato conbella = new Contrato();
// Documentos.Add(conbella);
// Contrato ConIsa = new Contrato();
// Documentos.Add(ConIsa);

// Relatorio relbella = new Relatorio();
// Documentos.Add(relbella);
// Relatorio RelaIsa = new Relatorio();
// Documentos.Add(RelaIsa);

// Console.WriteLine($"FATURA:");
// foreach(var Fatura in Documentos)
// {
//     Fatura.Imprimir();
// }
// Console.WriteLine($"CONTRATO:");
// foreach(var contrato in Documentos)
// {
//     contrato.Imprimir();
// }

// Console.WriteLine($"RELATORIO:");
// foreach(var relatorio in Documentos)
// {
//     relatorio.Imprimir();
// }
// // for(int i = 0; i < listaFaturas.Count; i++)
// // {
// //     listaFaturas[i].Imprimir();
// // }


List<IImprimivel> documentos = new List<IImprimivel>();


int opcao;

do
{
    Console.Clear();
    Console.WriteLine($@"
Escolha uma das opções:

1) Cadastrar fatura
2) Cadastrar relátorio
3) Cadastrar contrato
4) Listar faturas
5) Listas relátorios
6) Listar contratos
0) Sair
");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
        Console.WriteLine($"Cadastrar Fatura em desenvolvimento");
            break;
        case 2:
        Console.WriteLine($"Cadastrar Relátorio em desenvolvimento");
            break;
        case 3:
        Console.WriteLine($"Cadastrar Contrato em desenvolvimento");
            break;
        case 4:
        Console.WriteLine($"Listar Fatura em desenvolvimento");
            break;
        case 5:
        Console.WriteLine($"Listar Relátorios em desenvolvimento");
            break;
        case 6:
        Console.WriteLine($"Listar Contrato em desenvolvimento");
            break;
        case 0:
        Console.WriteLine($"Sair");
            break;

        default:
        Console.WriteLine($"Opção Inválida :( )");
        
        break;
    }

    Console.WriteLine($"Pressione <ENTER> para continuar");
    Console.ReadLine();
    

} while (opcao !=0);