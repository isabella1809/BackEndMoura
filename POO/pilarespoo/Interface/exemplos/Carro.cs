

namespace exemplos
{
    public class Carro : IMotor
    {

        public string cor;
        public string Marca;
        public string Modelo;
        public int Ano;

         public Carro(string c, string M, string Md, int A)
        {
            cor = c;
            Marca = M;
            Modelo = Md;
            Ano = A;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($@"
            Informações do Veiculo:
                Marca: {Marca}
                Modelo: {Modelo}
                Ano: {Ano}
                Cor: {cor}");
            
        }

        public void Acelerar()
        {
           
        }

        public void Frear()
        {
            throw new NotImplementedException();
        }
    }
}