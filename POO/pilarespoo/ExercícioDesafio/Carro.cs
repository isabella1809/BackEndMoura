

namespace ExercícioDesafio
{
    public class Carro
    {
        private string marca;

        private string modelo;

        private int velocidadeAtual;

        public string ObterMarca()
        {
           return marca; 
        }
        public void DefinirMarca(string valor)
        {
            marca = valor;
        }
        public void DefinirModelo(string valor)
        {
            modelo = valor;
        }
        public string ObterModelo()
        {
           return modelo; 
        }
       
        public int ObterVelocidade()
        {
           return velocidadeAtual; 
        }

//         Acelerar(int valor): aumenta a velocidade.

// Frear(int valor): diminui a velocidade, mas nunca pode ficar abaixo de zero.

          public void Acelerar(int valor)
          {
            if (valor > 0)
            {
                velocidadeAtual +=valor;
            }else
            {
                Console.WriteLine($"nao pode acelerar");
                
            }

          }
          public void freiar(int valor)
          {
            if (valor > 0)
            {
                velocidadeAtual +=valor;
            }else
            {
                Console.WriteLine($"nao pode freiar");
                
            }

          }

       


    }
}