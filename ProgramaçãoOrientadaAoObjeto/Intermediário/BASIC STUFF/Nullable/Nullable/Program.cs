using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> x = null;
            double? y = 10;

            //Adiquirir valor padrão ou declarado
            Console.WriteLine(x.GetValueOrDefault()); // x = 0
            Console.WriteLine(y.GetValueOrDefault()); // y = 10

            Console.WriteLine();
            
            // Valor Booleano indicando se tem valor
            Console.WriteLine(x.HasValue);  // false
            Console.WriteLine(y.HasValue);  // true

            Console.WriteLine();

            // Escrever o valor da váriavel
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);//impossivel de imprimir, valor nulo
            }
            else 
            {
                Console.WriteLine("X is null");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            Console.WriteLine();
            
            //Operador de coalescência nula
            double a = x ?? 5;// Caso X seja nulo atribuir valor a direita 
            double b = y ?? 5;// Caso Y seja nulo atribuir valor a direita
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
