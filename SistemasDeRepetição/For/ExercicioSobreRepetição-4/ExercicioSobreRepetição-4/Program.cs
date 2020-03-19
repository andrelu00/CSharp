using System;
using System.Globalization;

namespace ExercicioSobreRepetição_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divisão de dois numeros! \n");

            Console.WriteLine("Quantas divisões vai fazer?");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os pares de numeros para fazer a divisão(Separados por espaço)");
            
            for(int i=1; N>= i; i++) 
            {
                
                string[] valores = Console.ReadLine().Split(' ');
                double n1 = double.Parse(valores[0]);
                double n2 = double.Parse(valores[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão Impossivel \n");
                }
                else
                {
                    double res = n1 / n2;
                    Console.WriteLine("A divisão é {0} \n", res.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}
