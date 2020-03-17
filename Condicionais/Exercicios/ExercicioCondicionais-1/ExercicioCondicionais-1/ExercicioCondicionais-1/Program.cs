using System;

namespace ExercicioCondicionais_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificar Numero!");
            Console.WriteLine("Digite um numero inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0) 
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

        }
    }
}
