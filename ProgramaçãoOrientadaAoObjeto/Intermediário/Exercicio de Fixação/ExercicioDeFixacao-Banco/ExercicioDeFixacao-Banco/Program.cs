using System;
using System.Globalization;

namespace ExercicioDeFixacao_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            float depositoInicial;
            Conta NovaConta = new Conta
            Console.Write("Entre o número da conta: ");
            string numConta = Console.ReadLine();
            Console.Write("Entre o titular da conta: ");
            string NomeConta = Console.ReadLine();
            Console.Write("Haverá deposito inicial?(s/n) ");
            string deposito = Console.ReadLine().ToLower();
            
            
            
            if (deposito == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                depositoInicial = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                NovaConta = new Conta(numConta, NomeConta, depositoInicial);
            
            }
            else 
            {
                NovaConta = new Conta(numConta, NomeConta);
            }

            

            Console.WriteLine("\nDados Atualizados: \n" + NovaConta + "\n");
            
            Console.Write("Digite um valor para depósito: ");
            float Deposito = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            NovaConta.Deposito(Deposito);

            Console.WriteLine("Dados Atualizados: \n" + NovaConta + "\n");

            Console.Write("Digite um valor para saque: ");
            float Saque = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            NovaConta.Saque(Saque);

            Console.WriteLine("Dados Atualizados: \n" + NovaConta + "\n");
        }
    }
}
