using System;
using System.Globalization;

namespace VetoresArmazenandoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for(int i = 0; i < n; i++) 
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto(nome, preco);
            }

            double soma = 0;
            for(int i =0; i<n; i++) 
            {
                soma += vect[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine(media.ToString("2F", CultureInfo.InvariantCulture));
        }
    }
}
