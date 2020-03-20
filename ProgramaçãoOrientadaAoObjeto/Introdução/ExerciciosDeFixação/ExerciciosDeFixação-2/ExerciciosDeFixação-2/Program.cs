using System;
using System.Globalization;

namespace ExerciciosDeFixação_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario empregado = new Funcionario();
            Console.Write("Nome: ");
            empregado.Nome = Console.ReadLine();
            Console.Write("Sálario bruto: ");
            empregado.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            empregado.Impoto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + empregado);

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            empregado.AumentarSalario(porc);

            Console.WriteLine("\nDados atualizados: " + empregado);
        }
    }
}
