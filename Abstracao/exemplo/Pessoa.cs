

namespace exemplo
{
    public class Pessoa : Animal
    {
        public string nome;

        public int idade;
        public override void FazerSom()
        {
            Console.WriteLine($"oi todo bemmmmm");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"desculpa mãe, desculpa mãeeeeeeee");
            
        }

        public void Dormir()
        {
            Console.WriteLine($"zzzZZZzzzZZZzzzZZ");
            
        }
        
    }
}