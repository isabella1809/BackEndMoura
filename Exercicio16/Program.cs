using System.Security.AccessControl;

string cargo;
double salario, salarioNovo;

Console.WriteLine($"Digite o cargo do funcionario, producao, administrativo ou diretoria...");
cargo = Console.ReadLine();

Console.WriteLine($"Digite o salario do funcionario");
salario = double.Parse(Console.ReadLine());

if (cargo == "producao");
{
    salarioNovo = salario + (salario * 0.065);

}else if (cargo == "administrativo")
{
    salarioNovo = salario + (salario * 0.075);

}

else if (cargo == "diretoria")
{
    salarioNovo = salario + (salario * 0.12);
}

else
{
    Console.WriteLine($"Cargo invalido");

}

Console.WriteLine($"O novo salario rajustado e {salarioNovo}");

CuidaConsole.WriteLine("qual é seu cargo");
cargo = Console.ReadLine();