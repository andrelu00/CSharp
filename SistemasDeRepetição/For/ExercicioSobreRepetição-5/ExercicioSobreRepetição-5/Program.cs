using System;

namespace ExercicioSobreRepetição_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descobrir o fatorial de um numero!\n");
            Console.WriteLine("Digite um numero: ");
            int N = int.Parse(Console.ReadLine());


            int fator = 1;

            for (int i = 1; N >= i; i++)    
            {
                fator = fator * i;
                
            }

            Console.WriteLine("O fatorial desse número é: "+ fator);

        }
    }
}
