// See https://aka.ms/new-console-template for more information
string nome;
string sobrenome;
int idade;
float saldobancario;
float investimentos;

Console.WriteLine("Olá, qual é o seu nome ?") ;
nome = Console.ReadLine();

Console.WriteLine("qual é o seu sobrenome ?") ; 
 sobrenome = Console.ReadLine();

 Console.WriteLine("qual é o sua idade ?") ;
 idade =int.Parse( Console.ReadLine() ) ;

  Console.WriteLine("qual é o saldo bancario ?") ;
 saldobancario =float.Parse( Console.ReadLine() ) ;

  Console.WriteLine("qual é investimento para este ano?") ;
 investimentos =float.Parse( Console.ReadLine() ) ;

//Console.Clear();
//Console.WriteLine("nome:" + nome);
//Console.WriteLine("sobrenome:" + sobrenome);
//Console.WriteLine("idade:" + idade);
//Console.WriteLine("saldobancario: R$" + saldobancario);
//Console.WriteLine("investimentos: R$" + investimentos);

Console.Clear();
Console.WriteLine($"nome: {nome} {sobrenome}");
Console.WriteLine($"idade do {nome} é {idade}");
Console.WriteLine($"saldo bancario: {saldobancario}");
Console.WriteLine($"investimento este ano: {investimentos}");
