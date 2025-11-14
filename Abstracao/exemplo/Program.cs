
using exemplo;

// gato birobinha = new gato ();

// cachorro Mariavictoria = new cachorro();

// Pessoa bella = new Pessoa();
// bella.nome = "bellabella"; 
// bella.idade = 17; 

// Console.WriteLine($"Nome: {bella.nome}");
// Console.WriteLine($"Idade do {bella.nome}: {bella.idade} anos");

// Console.WriteLine($"Som do {bella.nome}: ");
// bella.FazerSom();
// Console.WriteLine($"{bella.nome} está se movendo: ");
// bella.Mover();

// Console.WriteLine($"{bella.nome} foi dormir");
// bella.Dormir();


contacorrente cc = new contacorrente();
contapoupancia cp = new contapoupancia();

cc.Depositar(500);
cp.Depositar(500);

Console.WriteLine("=== CONTA CORRENTE ===");
Console.WriteLine($"Saldo inicial: {cc.Saldo}");
cc.Sacar(100);
Console.WriteLine($"Saldo após saque: {cc.Saldo}");

Console.WriteLine("\n=== CONTA POUPANÇA ===");
Console.WriteLine($"Saldo inicial: {cp.Saldo}");
cp.Sacar(100);
Console.WriteLine($"Saldo após saque: {cp.Saldo}");

