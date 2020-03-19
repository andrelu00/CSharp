using System;

namespace ExerciciosSobreReptição_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular os multiplos de um número!\n");

            Console.WriteLine("Insira um numero inteiro");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDivisores desse número: ");
            
            for(int i=1; i<=num; i++) 
            {
                if(num % i == 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
