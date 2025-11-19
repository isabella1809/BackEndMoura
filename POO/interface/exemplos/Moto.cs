using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplos
{
    public class Moto : IMotor
    {
        
        public string cor;
        public string Marca;
        public string Modelo;
        public int Ano;

         public Moto(string c, string M, string Md, int A)
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
            Console.WriteLine($"vuuuuuuuuuuuuuuuuuuuuuuuuuuum");
            
        }

        public void Frear()
        {
            Console.WriteLine($"iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii");
            
        }
    }
}