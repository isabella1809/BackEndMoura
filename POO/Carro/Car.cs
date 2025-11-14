
namespace Carro
{
    public class Car
    {
        public string Marca;

        public string Modelo;

        public float Ano;

        public Car()
        {
            Console.WriteLine($"Consultando informações do Carro");

        }

        public Car(string Ma, string M, float A)
        {
            Marca = Ma;
            Modelo = M;
            Ano = A;

        }

        public void ExibirDados()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
            
        }

    }
}