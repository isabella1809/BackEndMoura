
namespace exemplo
{
    public class gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Miauzinn");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"ploc ploc ploc");
            
        }
    }
}