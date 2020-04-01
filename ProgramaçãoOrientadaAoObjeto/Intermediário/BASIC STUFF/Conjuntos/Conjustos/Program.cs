using System;
using System.Collections.Generic; //Necessário para a utilização de conjuntos

namespace Conjustos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);
            
            
            Console.WriteLine("Quantidade de elementos em A: {0}",A.Count);
            Console.WriteLine("Quantidade de elementos em B: {0}",B.Count);
            
            Console.WriteLine("---------------------------");

            foreach(int x in A) 
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("---------------------------");

            foreach(int x in B) 
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (A.Contains(N)) // contains retorna se um valor existe no conjunto
            {
                Console.WriteLine("O Numero pertence ao conjunto A");
            }
            else 
            {
                Console.WriteLine("O Numero não pertence ao conjunto A");
            }

            Console.WriteLine();

            if (B.Contains(N))
            {
                Console.WriteLine("O Numero pertence ao conjunto B");
            }
            else
            {
                Console.WriteLine("O Numero não pertence ao conjunto B");
            }

            Console.WriteLine("---------------------------");

            A.IntersectWith(B);//Intersecção de A em B
            Console.WriteLine("A após a intersecção com B");
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("A após a união: ");
            A.UnionWith(B);//A União B
            foreach(int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("---------------------------");

            A.ExceptWith(B); //Conjunto A menos o Conjunto B
            Console.WriteLine("A após a operação A - B: ");
            foreach(int x in A) 
            {
                Console.WriteLine(x);
            }
            
            Console.WriteLine("---------------------------");

            B.Remove(4); //Remove um valor do conjunto 
            Console.WriteLine("B após a remoção:\n");
            foreach (int x in B)
            {
                Console.WriteLine(x);
            }
        }
    }
}
