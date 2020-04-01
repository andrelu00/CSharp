using System;
using System.Globalization;

namespace ExercicioDeFixação_Listas
{
    class Empregado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set;}

        

        public Empregado(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        

        public void AumentarSalario(double porcentagem) 
        {
            Salario = Salario + (Salario * porcentagem / 100);
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
