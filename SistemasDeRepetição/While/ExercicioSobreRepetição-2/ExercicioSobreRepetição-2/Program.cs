using System;

namespace ExercicioSobreRepetição_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadrante de um ponto num plano cartesiano \n");

            Console.WriteLine("Digite as coordenadas inteiras do ponto(Separados por espaço)");
            string[] cord = Console.ReadLine().Split(' ');
            int x = int.Parse(cord[0]);
            int y = int.Parse(cord[1]);

            while(x != 0 && y != 0) 
            {
                if(x > 0 && y > 0) 
                {
                    Console.WriteLine("Primeiro");
                }
                else if(x < 0 && y > 0) 
                {
                    Console.WriteLine("Segundo");
                }
                else if(x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else 
                {
                    Console.WriteLine("Quarto");
                }

                cord = Console.ReadLine().Split(' ');
                x = int.Parse(cord[0]);
                y = int.Parse(cord[1]);
            }
            
        }
    }
}
