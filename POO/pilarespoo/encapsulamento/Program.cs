
using encapsulamento;

ContaBancaria contabella = new ContaBancaria();

contabella.Depositar ( -100);
contabella.Depositar(20);
contabella.Depositar(-200);
contabella.Depositar(300);

Console.WriteLine();

Console.WriteLine($"saldo atual da bella: r${contabella.Getsaldo}");
Console.WriteLine($"saldo atual da thata: r${contabella.Getsaldo}");

