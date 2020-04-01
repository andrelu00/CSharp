using System;

namespace Matrizes_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a ordem da Matriz quadrada:");
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];
            
            for(int i = 0; i < N; i++)//Percorre as linhas 
            {
                string[] valores = Console.ReadLine().Split(' ');

                for(int j = 0; j < N; j++) //Percorre as Colunas
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Diagonal Principal: ");
            for (int i = 0; i < N; i++) 
            {
                Console.Write(matriz[i,i] + " ");
            }
            Console.WriteLine();
            
            int negativo = 0;
            
            for(int i = 0; i < N; i++) 
            {
                for (int j = 0; j < N; j++) 
                {
                    
                    if(matriz[i,j] < 0) 
                    {
                       negativo++;
                    }
                }
            }
            Console.WriteLine("Quantidades de numeros negativos: {0}",negativo);
        }
    }
}
