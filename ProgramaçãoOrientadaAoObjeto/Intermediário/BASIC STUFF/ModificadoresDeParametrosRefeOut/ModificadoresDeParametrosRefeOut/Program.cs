using System;

namespace ModificadoresDeParametrosRefeOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            int triple;

            Calculator.Triplo(ref a); //Faz a váriavel fazer referência a original, ref exige que a variável seja iniciada 
            Console.WriteLine(a);

            Calculator.Triple(b, out triple); // out indica a váriavel de saída da função
            Console.WriteLine(triple);
        }
    }
}
