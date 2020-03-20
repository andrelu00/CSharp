using System;
using System.Globalization;

namespace ExercicioDeFixação_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retãngulo");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nAREA: "+ ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + ret.Diagonal().ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
