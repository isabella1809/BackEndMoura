Console.WriteLine($"subrindo:");
for (int t = 0; t < 3; t++)
{
    Console.WriteLine($"valor do t: {t}");
}

Console.WriteLine($"Descendo:");
for (int t = 3; t < 0; t--)
{
    Console.WriteLine($"valor do t: {t}");
}
//###################################################################################################################################


Console.WriteLine();
Console.WriteLine($"for com variaveis de inicio e fim");

int inicio = 0, fim = 3;
for (int i = inicio; i < fim; i++)
{
    Console.WriteLine($"valor do t: {i}");
}