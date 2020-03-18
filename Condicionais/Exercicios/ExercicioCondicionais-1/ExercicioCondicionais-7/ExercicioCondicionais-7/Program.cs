using System;
using System.Globalization;

namespace ExercicioCondicionais_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Definir o quadrante de um ponto no plano cartesiano");

            //x>0 e y>0 = q1, x>0 e y<0 = q4, x<0 e y>0 = q2, x<0 e y<0 = q3
            Console.WriteLine("Digite as coordenadas do ponto(Separados por espaço)");
            string[] cord = Console.ReadLine().Split(' ');
            float x = float.Parse(cord[0], CultureInfo.InvariantCulture);
            float y = float.Parse(cord[1], CultureInfo.InvariantCulture);

            if(x>0 && y > 0) 
            {
                Console.WriteLine("Q1");
            }

            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }

            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }

            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }

            else if (x == 0) 
            {
                Console.WriteLine("eixo X");
            }

            else if(y == 0) 
            {
                Console.WriteLine("Eixo Y");
            }

            else 
            {
                Console.WriteLine("Origem");
            }
        }
    }
}
