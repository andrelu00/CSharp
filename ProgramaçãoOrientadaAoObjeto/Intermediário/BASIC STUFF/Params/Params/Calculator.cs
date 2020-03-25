using System;
using System.Collections.Generic;
using System.Text;

namespace Params
{
    class Calculator
    {
        public static int Sum(params int[] numbers)//Params diz que essa função pode receber uma quantidade váriavel de valores
        {
            int soma = 0;
            for (int i = 0; i < numbers.Length; i++) 
            {
                soma += numbers[i];
            }
            return soma;
        }


    }
}
