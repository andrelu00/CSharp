using System;

namespace ExercicioSobreEstrutraSequencial_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Diferença maluca! ((A*B)-(C*D))");

            Console.WriteLine("Digite o primeiro valor, A");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor, B");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor, C");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor, D");
            int D = int.Parse(Console.ReadLine());

            int res = (A * B) - (C * D);

            Console.WriteLine("DIFERENÇA = "+ res);
        }
    }
}
