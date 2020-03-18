using System;

namespace ExerciciosSobreRepetição_3
{
    class Program
    {
        static void Main(string[] args)
        {   int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            
            
            Console.WriteLine("PostoX! \nTeste de Qualidade \n");

            Console.WriteLine("Com qual combustivel você abasteceu?(Use os numeros) \n \n1-Álcool \n2-Gasolina \n3-Diesel \n4-Fim");
            int escolha = int.Parse(Console.ReadLine());

            while(escolha != 4) 
            {
                

                if (escolha == 1)
                    {
                        alcool++;
                        escolha = int.Parse(Console.ReadLine());
                        Console.WriteLine("Obrigado :)");
                    }

                else if (escolha == 2)
                    {
                        gasolina++;
                        escolha = int.Parse(Console.ReadLine());
                        Console.WriteLine("Obrigado :)");
                    }

                else if(escolha == 3)
                    {
                        diesel++;
                        escolha = int.Parse(Console.ReadLine());
                        Console.WriteLine("Obrigado :)");
                    }
                else 
                    {
                        Console.WriteLine("Código Inválido");
                        escolha = int.Parse(Console.ReadLine());
                    } 
            }

            Console.WriteLine("BOM DIA \nAlcool: "+alcool +"\nGasolina: "+gasolina+"\nDiesel: "+diesel);

        }
    }
}
