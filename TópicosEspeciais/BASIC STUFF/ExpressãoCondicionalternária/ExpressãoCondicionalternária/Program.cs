using System;
using System.Globalization;

namespace ExpressãoCondicionalternária
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sintaxe: (condição) ? valor_se_verdadeiro : valor_se_falso 

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);
        }
    }
}
