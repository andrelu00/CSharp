using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);//Posso enviar vários parâmetros para a funão graças qo params
            int s2 = Calculator.Sum(2, 3, 5);

            Console.WriteLine(s1+"\n"+s2);
        }
    }
}
