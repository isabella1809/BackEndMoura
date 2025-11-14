
namespace calculator
{
    public class Calculator
    {
        public double numero1;
        public double numero2;
        public double Resultado;


        public double somar()
        {
            Resultado = numero1 + numero2;
            Console.WriteLine($"resultado da soma: {Resultado}");
            return Resultado;
        }
        public double subtrair()
        {
            Resultado = numero1 + numero2;
            Console.WriteLine($"resultado da subtração: {Resultado}");
            return Resultado;
        }
        public double multiplicar()
        {
            Resultado = numero1 * numero2;
            Console.WriteLine($"resultado da multiplicação: {Resultado}");
            return Resultado;
        }
        public double dividir()
        {
            if (numero2 == 0)
            {
                Console.WriteLine($"não existe divisão por zero");
                return -1;
            }
            Resultado = numero1 / numero2;
            Console.WriteLine($"resultado da divisão: {Resultado}");
            return Resultado;
        }
    }
}