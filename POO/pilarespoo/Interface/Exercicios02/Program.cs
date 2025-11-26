using Exercicios02;
int opcao; 

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




do{

    Console.Clear();
    Console.WriteLine($@"Menu de Opcoes
    Escolha uma das Opcoes: 

    1)Cadastrar fatura 
    2)Cadastrar relátorio 
    3)Cadastrar Contato
    4)Listar faturas 
    5)Listar relatórios 
    6)Listar contratos 
    0)Sair 
    ");

    opcao = int.Parse(Console.ReadLine());

    switch(opcao)
    {

    case 1: 
    Console.WriteLine($"Cadastrar fatura em desenvolvimento");
    break; 

    case 2: 
    Console.WriteLine($"Cadastrar relatório em desenvolvimento");
   break;
   
    case 3:
    Console.WriteLine($"Cadastrar relatório em desenvolvimento");
    break;
    
    case 4:
    Console.WriteLine($"Listar fatura em desenvolvimento");
    break;

    case 5:
    Console.WriteLine($"Cadastrar relatórios em desenvolvimento");
    break;

    case 6: 
    Console.WriteLine($"Listar contrato em desenvolvimento");
    break; 

    case 0:
    Console.WriteLine($"Sair");
    break;

    default:
    Console.WriteLine($"Opcão Inválida : ()");
    break; 


    Console.WriteLine($"Pressione <ENTER> para continuar");
    Console.ReadLine();
}
    break;


    Console.WriteLine($"Pressione <ENTER> para continuar");
    Console.ReadLine();
    

 }while (opcao !=0);

    void CadastrarFaturas()
    {
        Console.WriteLine($"Digite o nome do Cliente Devedor");
        string dev = Console.ReadLine();

        Console.WriteLine($"Digite o nome da empresa");
        string epresa = Console.ReadLine();

        Console.WriteLine($"Digite o valor da fatura");
        float valor = float.Parse(Console.ReadLine());

        Console.Write($"Dias de atraso da fatura?");
        int qtdAtraso = int.Parse(Console.ReadLine());
    }

    void  CadastrarContrato()
{
    Console.WriteLine($"informe o nome para o contrato");
    string nome = Console.ReadLine();
    
    Console.WriteLine($"Qual o texto da clausula do contrato?");
    string texto = Console.ReadLine();
    
    Contrato contrato = new Contrato();
    contrato.Nome = nome;
    contrato.textoClausulas = texto;
    documentos.Add(contrato);
    Console.WriteLine($"contrato ");
    
    
}

    void CadastrarRelatorio()
{
    Console.WriteLine($"digite o nome do responsavel");
    string nome =Console.ReadLine();
    Console.WriteLine($"digite o Texto do relatorios");
    string texto =Console.ReadLine();
    Relatorio relatorio= new Relatorio();
    relatorio.Nomeresponsaveis= nome;
    relatorio.textorelatorio = texto;
    documentos.Add(relatorio);
    Console.WriteLine($"relatorio cadastrado com sucesso!");
    

    
}

    void listasFaturas()
{
    Console.WriteLine($"Listando Faturas:");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}

    void listasContratos()
{
    foreach (var item in documentos)
    {
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }
}
    void listasRelatorios()
{
     foreach (var item in documentos)
    {
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }
}














// List <Fatura> listasFaturas = new List<Fatura>();
// List <Relaatorio> listasRelatorios = new List<Relatorio>();
// List <Fatura> listasContratos = new List<Contrato>();

// // Fatura fatEdu = new Fatura();
// listasFaturas.Add(fatEdu);

// Fatura fatAle = new Fatura();
// listasRelatorios.Add(fatAle);

// Contrato contEdu = new Contrato();
// listasContratos.Add(contEdu);

// Console.WriteLIne($"");
// foreach (var fatura in listasFaturas)
// {
//     fatura.Imprimir(); 
// }

// Console.WriteLIne();




