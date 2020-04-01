using System;
using System.Collections.Generic;

namespace ExerciciosDeFixacao_Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int qtdA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código dos alunos:");
            for(int i = 1; i <= qtdA; i++) 
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso B possui quantos alunos? ");
            int qtdB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código dos alunos:");
            for (int i = 1; i <= qtdB; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso C possui quantos alunos? ");
            int qtdC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código dos alunos:");
            for (int i = 1; i <= qtdC; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }

            A.UnionWith(B);
            A.UnionWith(C);

            Console.WriteLine("Total de Alunos: {0}",A.Count);
        }
    }
}
