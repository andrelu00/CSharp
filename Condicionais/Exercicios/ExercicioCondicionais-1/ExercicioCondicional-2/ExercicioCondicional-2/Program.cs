using System;

namespace ExercicioCondicional_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificar se o numero é par ou impar");

            Console.WriteLine("Digite um numero inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0) 
            {
                Console.WriteLine("PAR");
            }
            else 
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
