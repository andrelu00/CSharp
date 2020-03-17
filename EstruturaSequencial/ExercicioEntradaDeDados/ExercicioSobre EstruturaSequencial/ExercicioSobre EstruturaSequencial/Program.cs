using System;

namespace ExercicioSobre_EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de Dois Numeros");
            Console.WriteLine();
            Console.WriteLine("Digite o Primeiro Numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Numero: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1 + n2;

            Console.WriteLine("Soma: " + resultado);
        }
    }
}
