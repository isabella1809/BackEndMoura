using ClasseEObjetos;

Console.Clear();
Console.WriteLine($"== Agência Bancária ==");
Console.WriteLine();

AgenciaBancaria contaDaisa = new AgenciaBancaria();

contaDaisa.Titular = "Elias Huamán";
contaDaisa.Saldo = 1000.80f;

contaDaisa.Depopsitar(500.01f);

contaDaisa.Sacar(1500);