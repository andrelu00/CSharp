using System;
using System.Globalization;

namespace ExerciciosDeFixação_2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Impoto;


        public double SalarioLiquido() 
        {
            return SalarioBruto - Impoto;
        }

        public void AumentarSalario(double porcentagem) 
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * (porcentagem / 100));
        }

        public override string ToString()
        {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
