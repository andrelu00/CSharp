using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];
            
            Console.WriteLine(mat.Length); //Indica o total de elementos da Matriz

            Console.WriteLine(mat.Rank); //Indica o numero de linhas

            Console.WriteLine(mat.GetLength(0)); //Indica o tamanho da Primeira Dimensão da Matriz

            Console.WriteLine(mat.GetLength(1)); //Indica o tamanhoa da Segunda Dimensão da Matriz
        }
    }
}
