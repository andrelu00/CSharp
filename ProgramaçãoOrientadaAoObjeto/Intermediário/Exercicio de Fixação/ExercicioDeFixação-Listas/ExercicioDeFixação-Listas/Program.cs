using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioDeFixação_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Funcionários seram registrados? ");
            int NumFunc = int.Parse(Console.ReadLine());
           

            List<Empregado> listaFuncionarios = new List<Empregado>();

            for (int i = 1; i<=NumFunc; i++) 
            {
                Console.WriteLine("Empregado #{0}", i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listaFuncionarios.Add(new Empregado(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre o ID do funcinário que terá um aumento de salário: ");
            int IdSalario = int.Parse(Console.ReadLine());

            Empregado emp = listaFuncionarios.Find(x => x.Id == IdSalario);
            if (emp != null)
            {
                Console.Write("Entre a porcentagem do aumento: ");
                double Porc = double.Parse(Console.ReadLine());
                emp.AumentarSalario(Porc);
            }
            else 
            {
                Console.WriteLine("Esse ID não existe");
            }

            Console.WriteLine("\nLista Atualizada:");
            foreach(Empregado obj in listaFuncionarios) 
            {
                Console.WriteLine(obj);
            }
            
        }
    }
}
