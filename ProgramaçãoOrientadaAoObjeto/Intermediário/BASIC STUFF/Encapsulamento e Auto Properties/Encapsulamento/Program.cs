using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste de encapsulamento");

            Produto p = new Produto("Produto Desconhecido", 500, 10);

            p.Nome = Console.ReadLine();

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

        }
    }
}
