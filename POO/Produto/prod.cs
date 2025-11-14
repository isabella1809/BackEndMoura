
// Classe Produto:
// Crie uma classe Produto com atributos nome, preco e estoque.
// Crie um construtor que receba os valores e um método que mostre os dados

namespace Produto
{
    public class prod
    {

        public string Nome;

        public float Preco;

        public int Estoque;

        public prod(string n, float p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Produto: {Nome}, Preco: {Preco}, Quantidade em estoque: {Estoque}");
            
        }


    }
}