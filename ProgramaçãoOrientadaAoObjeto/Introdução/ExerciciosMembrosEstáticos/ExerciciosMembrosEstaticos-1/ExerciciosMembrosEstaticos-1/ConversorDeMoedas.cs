using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosMembrosEstaticos_1
{
    class ConversorDeMoedas
    {
             
        public static double IOF = 6;

        public static double DolarParaReal(double qtdDolar, double cotacaoDolar) 
        {
            double total = qtdDolar * cotacaoDolar;
            return total + (total * IOF / 100);
        }
    }
}
