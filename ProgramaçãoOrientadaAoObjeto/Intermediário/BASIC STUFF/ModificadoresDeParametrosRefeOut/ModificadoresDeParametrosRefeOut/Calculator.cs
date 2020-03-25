using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadoresDeParametrosRefeOut
{
    class Calculator
    {
        public static void Triplo(ref int x) // Faz a váriavel fazer referência á original, ref exige que a variável seja iniciada
        {
            x = x * 3;
        }

        public static void Triple(int origin, out int result) // Out indica a váriavel de saída da função
        {
            result = origin * 3;
        }
    }
}
