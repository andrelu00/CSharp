using System;
using System.Globalization;

namespace ExercicioSobreRepetição_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média de 3 Valores, quantas vezes precisar! \n");

            Console.WriteLine("Quantas médias você quer fazer?");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Os pesos dos valores são respectivamente 2,3 e 5");

            for(int i = 1; N >= i; i++) 
            {
                
                Console.WriteLine("Digite os numeros com até uma casa decimal(Separados por espaço): ");
                string[] valores = Console.ReadLine().Split(' ');
                float n1 = float.Parse(valores[0], CultureInfo.InvariantCulture);
                float n2 = float.Parse(valores[1], CultureInfo.InvariantCulture);
                float n3 = float.Parse(valores[2], CultureInfo.InvariantCulture);

                float resultado = media(n1, n2, n3);

                Console.WriteLine("Resultado: "+resultado.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
        static float media(float a2, float b3, float c5)
        {
            float m = ((2 * a2) + (3 * b3) + (5 * c5)) / 10;

            return m;
        }
    }
}
