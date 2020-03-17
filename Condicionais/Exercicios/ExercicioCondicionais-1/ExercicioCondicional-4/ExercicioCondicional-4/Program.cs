using System;

namespace ExercicioCondicional_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duração de um Jogo!");

            Console.WriteLine("Digite a hora inicial e a final(Separadas por espaço):");
            string[] h = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(h[0]);
            int horaFinal = int.Parse(h[1]);

            if (horaInicial > horaFinal) 
            {
                int duracao = 24 - (horaInicial - horaFinal);
                Console.WriteLine("O jogo durou " + duracao + " horas");
            }

            if(horaInicial < horaFinal) 
            {
                int duracao = horaFinal - horaInicial;
                Console.WriteLine("O jogo durou " + duracao + " horas");
            }

        }
    }
}
