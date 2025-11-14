using execicioPolimorfismo;

pagamentopix comprapix  = new pagamentopix();

comprapix.valorcompra = 15000;

float valorpagar = comprapix.calculartotal();

Console.WriteLine($"produto : swartphone");
Console.WriteLine($"preco: {comprapix.valorcompra}");
Console.WriteLine($"pagamento com desconto:{valorpagar}");

Console.WriteLine();

pagamentocartao compracartao = new pagamentocartao();
compracartao.valorcompra = 50;

Console.WriteLine($"produto: caneta ");
Console.WriteLine($"preco: {compracartao.valorcompra} ");
Console.WriteLine($"forma de pagamento: cartao  ");
Console.WriteLine($"pagamento com acrecimo : {compracartao.calculartotal()}");


