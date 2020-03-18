using System;

namespace ExercicioSobreRepetição_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros impares num intervalo \n");
            Console.WriteLine("Digite um numero, entre 1 e 100, para limitar o conjunto:");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Lista de numeros: ");

            for(int i=1; i <= X; i++) 
            {
                int check = i % 2;
                
                if(check != 0) 
                {
                    
                    Console.WriteLine(i);
                }
            }
        }
    }
}
