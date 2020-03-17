using System;
using System.Globalization;

namespace ExercicioCondicionais_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double CQ = 4.00;
            double XS = 4.50;
            double XB = 5.00;
            double TS = 2.00;
            double Refri = 1.50;


            Console.WriteLine("Caixa!");
            Console.WriteLine(" 1- Cachorro Quente R$ 4,00 \n 2- X-Salada R$ 4,50 \n 3- X-Bacon R$ 5,00 \n 4- Torrada simples R$ 2,00 \n 5- Refrigerante R$ 1,50");
            Console.WriteLine("Selecione o Produto(Utilize os numeros) e a quantidade: ");
            string[] total = Console.ReadLine().Split();
            int prod = int.Parse(total[0]);
            int qtd = int.Parse(total[1]);


            if(prod == 1) 
            {
                CachorroQuente();
            }

            if(prod == 2) 
            {
                XSalada();
            }

            if(prod == 3) 
            {
                XBacon();
            }

            if (prod == 4)
            {
                TorradaSimples();
            }

            if (prod == 5)
            {
                Refrigerante();
            }


            void CachorroQuente()
            {
                double valCompra = CQ * qtd;
                Console.WriteLine("Total: R$ "+ valCompra.ToString("F2", CultureInfo.InvariantCulture));
            }

            void XSalada()
            {
                double valCompra = XS * qtd;
                Console.WriteLine("Total: R$ " + valCompra.ToString("F2", CultureInfo.InvariantCulture));
            }

            void XBacon()
            {
                double valCompra = XB * qtd;
                Console.WriteLine("Total: R$ " + valCompra.ToString("F2", CultureInfo.InvariantCulture));
            }

            void TorradaSimples()
            {
                double valCompra = TS * qtd;
                Console.WriteLine("Total: R$ " + valCompra.ToString("F2", CultureInfo.InvariantCulture));
            }

            void Refrigerante()
            {
                double valCompra = Refri * qtd;
                Console.WriteLine("Total: R$ " + valCompra.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
