//1) Faça um programa que o usuário informe o salário recebido e o total gasto.
//  Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto 
// não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

float SalarioRecebido;
float Totalgosto;


    Console.WriteLine($"Qual é o salario que voçê recebe?");
SalarioRecebido = float.Parse(Console.ReadLine());
 Console.WriteLine($"Qual é o total gasto?");
    Totalgosto = float.Parse(Console.ReadLine());


    if (SalarioRecebido >= Totalgosto)
    {
        Console.WriteLine($"Gastos dentro do orçamento");

    }
    else if (SalarioRecebido <= Totalgosto)
    {
        Console.WriteLine($"Orçamento estourado {Totalgosto}");

    }
        



