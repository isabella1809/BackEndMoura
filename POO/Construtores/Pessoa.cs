
namespace Contrutores
{
    public class Pessoa
    {
        public string Nome;

        public int idade;
        public Pessoa()
        {
            Console.WriteLine($"objeto crido");

        }
        public Pessoa(string n, int i, string xpto)
        {
            Nome = n;
            idade = i;
            Console.WriteLine($"seu texto é {xpto}");
            
        }

        public Pessoa(string n, int i)
        {
            Nome = n;
            idade = i;
        }
        
        public Pessoa(string n)
        {
            Nome = n; 
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, idade: {idade} ");

        }
    }
}