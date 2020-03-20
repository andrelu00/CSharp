using System;
using System.Globalization;

namespace ExerciciosDeIntrodução_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Salario funcionario1 = new Salario();
            Salario funcionario2 = new Salario();

            Console.WriteLine("Média de salarios entre dois funcionarios: \n");
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Pagamento = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            Console.WriteLine("\nDados do segundo funcionário: ");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Pagamento = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float SalarioMedio = (funcionario1.Pagamento + funcionario2.Pagamento) / 2;
            Console.WriteLine("Salário médio = " + SalarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
