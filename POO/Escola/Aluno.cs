
//Crie uma classe Aluno com atributos nome e nota.
//Crie dois construtores: um sem parâmetros (define valores padrão) e outro que receba nome e nota.
//Mostre os dados dos alunos criados.

namespace Escola
{
    public class Aluno
    {
        public string Nome;

        public float Nota;


        public Aluno()
        {
            Console.WriteLine($"consultando a lista");

        }
        
        public void ExibirDados()
        {
            Console.WriteLine($"Nome do Aluno: {Nome}, Nota do Aluno: {Nota} ");
        }
        
        public Aluno(string N, float No)
        {
           Nome = N;
            Nota = No;
        }


    }
}