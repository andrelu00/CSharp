using System;

namespace ExercicioSobreRepetição_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dentro = 0;
            int fora = 0;

            Console.WriteLine("Números inteiros dentro de um intervalo [10,20]! \n");
            Console.WriteLine("Quantos números voce irá digitar?");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; N >= i; i++) 
            {
                Console.Write("Digite o {0}º numero: ", i);
                int num = int.Parse(Console.ReadLine());

                if(num >= 10 && num <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            Console.WriteLine(dentro + " in \n" + fora + " out");
        }
    }
}
