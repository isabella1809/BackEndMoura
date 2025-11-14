// Exercício 3 – Veículos
// Crie uma classe Veiculo com as propriedades Marca e Modelo e um método virtual MostrarInfo().
// Crie as classes Carro e Moto que herdem de Veiculo e sobrescrevam o método MostrarInfo()
//  para incluir informações específicas (como número de portas no carro e tipo de capacete na moto).
// Na Program, crie objetos e exiba as informações no console.

namespace exercicio03
{
    public class CarroEMoto : veiculo
    {

        public int qtdeportas;

        public int  tipodecapacete;

         public override string MostrarInfo()
        {
            return Marca = Modelo + qtdeportas;
        }
    }
}