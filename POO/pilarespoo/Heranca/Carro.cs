
namespace Heranca
{
    public class Carro : Veiculo
    {
        public int QtdPortas;

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"ano: {ano}");
            Console.WriteLine($"quantas portas: {QtdPortas}");

            
        }
    }
}