using System;

namespace ExerciciosSobreRepetição_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descobrir Quadrados e Cubos de numeros!\n");

            Console.WriteLine("Digite até que numero você quer os quadrados e cubos:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; n >= i; i++) 
            {
                int quad = i * i;
                int cubo = i * i * i;

                Console.WriteLine("{0} {1} {2}", i, quad, cubo );
            }

        }
    }
}
