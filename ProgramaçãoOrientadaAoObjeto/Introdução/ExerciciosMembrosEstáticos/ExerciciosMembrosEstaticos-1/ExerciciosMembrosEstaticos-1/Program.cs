using System;
using System.Globalization;

namespace ExerciciosMembrosEstaticos_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            Console.Write("Qual a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoedas.DolarParaReal(qtdDolar, cotacaoDolar);

            Console.WriteLine("Valo a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
