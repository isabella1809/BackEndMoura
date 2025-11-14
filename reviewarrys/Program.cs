string[] nomes = new string[4];
nomes[0] = "bella";
nomes[1] = "nick";
nomes[2] = "daik";

Console.WriteLine($"1o Nome: {nomes[0]}");
Console.WriteLine($"2o Nome: {nomes[1]}");
Console.WriteLine($"3o Nome: {nomes[2]}");
Console.WriteLine($"4o Nome: {nomes[3]}");
Console.WriteLine($"5o Nome: {nomes[4]}");

Console.WriteLine($"tamanho do array: {nomes.Length}");

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"      {i + 1}o nome : {nomes[1]}");
}