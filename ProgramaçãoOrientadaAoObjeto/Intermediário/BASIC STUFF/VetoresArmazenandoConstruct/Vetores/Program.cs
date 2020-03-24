using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vetores Armazenando dados struct! ");

            //calcular a média de n numeros

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n]; //Construção do vetor

            for( int i = 0; i<n; i++) 
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;
            for(int i =0; i<n; i++) 
            {
                soma += vect[i];
            }
            double media = soma / n;

            Console.WriteLine(media.ToString(CultureInfo.InvariantCulture));
        }
    }
}
