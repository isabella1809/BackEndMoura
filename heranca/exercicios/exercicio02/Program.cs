// Exercício 2 – Funcionários de uma empresa
// Crie uma classe Funcionario com as propriedades Nome e SalarioBase.
// Crie uma classe Gerente que herde de Funcionario e possua um bônus adicional.
// Implemente um método CalcularSalario() que retorne o salário total considerando o bônus do gerente.
// Crie objetos das duas classes e exiba os salários no console

using exercicio02;

funcionario funcomum = new funcionario();
Gerente gerente = new Gerente();

funcomum.SalarioBase = 1000;
gerente.SalarioBase = 10000;

float salfinalcomum = funcomum.CalcularSalario();
float salfinalger = funcomum.CalcularSalario();

Console.WriteLine($"salario do funcionario : {salfinalcomum}");
Console.WriteLine($"salario do funcionario : {salfinalger}");

