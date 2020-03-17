using System;
using System.Globalization;

namespace ExercicioSobreEstruturaSequencial_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de Salário!");


            Console.WriteLine("Digite seu número de indentificação:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas trabalhadas:");
            int qtdHoras = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quanto você recebe por hora:");
            float valorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float pagamento = qtdHoras * valorHora;
            
            Console.WriteLine("Numero de Identificação = " + id);
            Console.WriteLine("Pagamento = R$" + pagamento.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
