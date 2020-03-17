using System;

namespace ExercicioCondicional_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descobrir se dois numeros são multiplos!");
            Console.WriteLine("Digite dois numeros inteiros(Separados por espaço): ");
            string[] val = Console.ReadLine().Split(' ');
            int n1 = int.Parse(val[0]);
            int n2 = int.Parse(val[1]);
            
            
            if(n1 % n2 == 0|| n2 % n1 == 0) 
            {
                Console.WriteLine("São Multiplos");
            }
            else 
            {
                Console.WriteLine("Não São Multiplos");
            }
        }
    }
}
