using System;

namespace ExercicioDeFixacao_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos vão ser alugados? ");
            int n = int.Parse(Console.ReadLine());

            int MaxQuartos = 9;
            Estudante[] vetor = new Estudante[MaxQuartos];

            Console.WriteLine(); 

            for(int i = 1; i <= n; i++) 
            {
                Console.WriteLine("Aluguel " + i);
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vetor[quarto] = new Estudante(name, email, quarto);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos Ocupados: ");

            for (int i = 0; i < MaxQuartos; i ++) 

            {
                if (vetor[i] != null) 
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }
    }
}
