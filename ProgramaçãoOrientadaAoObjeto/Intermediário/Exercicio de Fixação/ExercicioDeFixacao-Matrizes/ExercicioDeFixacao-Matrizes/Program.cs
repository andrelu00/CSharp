using System;

namespace ExercicioDeFixacao_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da matriz, quantidade de linhas e colunas(Separados por espaço): ");
            string[] tam = Console.ReadLine().Split(' ');
            int linhas = int.Parse(tam[0]);
            int colunas = int.Parse(tam[1]);

            int[,] mat = new int[linhas, colunas];

            for(int i = 0; i < linhas; i++) 
            {
                string[] valores = Console.ReadLine().Split(' ');
                
                for(int j = 0; j < colunas; j++) 
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Digite um número que pertença á matriz: ");
            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                

                for (int j = 0; j < colunas; j++)
                {
                    if(mat[i,j] == X) 
                    {
                        Console.WriteLine("Posisção: " + i + "," + j);
                        
                        if(i > 0) 
                        {
                            Console.WriteLine("Número acima: " + mat[i-1,j]);
                        }
                        else { }

                        if (i  < linhas - 1)
                        {
                            Console.WriteLine("Número abaixo: " + mat[i + 1, j]);
                        }
                        else { }

                        if (j > 0)
                        {
                            Console.WriteLine("Número a esquerda: " + mat[i, j - 1]);
                        }
                        else { }

                        if (j < colunas - 1)
                        {
                            Console.WriteLine("Número a direita: " + mat[i, j + 1]);
                        }
                        else { }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
