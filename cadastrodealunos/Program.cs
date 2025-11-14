string[] nomes = new string[3];
int[] idades = new int[3];
int totalAlunos = 0; 
int opcao = -1;

do
{
    Console.WriteLine($"==== Aplicativo Sala de Aula ====");
    Console.WriteLine($"1) Lista Alunos");
    Console.WriteLine($"2) Cadastrar Alunos");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Escerrando ...");
            break;
        case 1:
            listarAluno();
            break;
        case 2:
            cadastrarAluno();
            break;
        default:
            break;
    }

    Console.WriteLine($"pressione <enter> para continuar ...");
    Console.ReadLine();
} while (opcao != 0);

void listarAluno()
{
    Console.WriteLine($"=== listagem de alunos ===");
for (int i = 0; i < totalAlunos; i++)
{
   Console.WriteLine($"nomes: {nomes[i]}, {idades[i]} anos");
   
}  

}
void cadastrarAluno()
{
    Console.WriteLine($"=== cadastro de alunos ===");
      if (totalAlunos >= 3)
    {
        Console.WriteLine($"limite de vagas atingindo");
        return;
    }
    Console.WriteLine($"digite o nome do aluno ");
    nomes[totalAlunos] = Console.ReadLine();

    Console.WriteLine($"digite a idade de {nomes[totalAlunos]}");
    idades[totalAlunos] = int.Parse(Console.ReadLine());
    totalAlunos++;
    Console.WriteLine($"Aluno cadastrado co sucesso!");
    
    
}