using System;
using System.Collections.Generic; //Biblioteca necessária para usar listas

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>(); //Lista instanciada sem válores

            List<string> list2 = new List<string> { "Maria", "Alex", "Anna" }; //Lista instanciada com valores

            //Listas possuem tamanhos váriaveis e podem facilmente aceitar novos termos e apagar termos existentes

            // Add - Adiciona no final da lista
            list1.Add("Maria");
            list1.Add("Alex");
            list1.Add("Bob");
            list1.Add("Anna");

            foreach (string obj in list1) 
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------------------------");

            //Insert inseri valor no índice que você desejar 
            list2.Insert(0, "Marco");
            list2.Insert(1, "Lara");

            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------");

            //Mostrar tamanho da Lista
            Console.WriteLine(list1.Count+"\n"+list2.Count);

            Console.WriteLine("---------------------------");

            //Achar primeira ocorrencia de um item numa lista
            string s1 = list1.Find(Test);
            Console.WriteLine(s1);
            string s2 = list2.Find(x => x[0] == 'A'); //Usando Lambda(Função anônima)
            Console.WriteLine(s2);

            Console.WriteLine("---------------------------");

            //Achar última ocorrência de um item numa lista
            string s3 = list1.FindLast(Test);
            Console.WriteLine(s3);
            string s4 = list2.FindLast(x => x[0] == 'A');
            Console.WriteLine(s4);

            Console.WriteLine("---------------------------");

            //Econtrar posição da primeira ocorrência de um item numa lista
            int n1 = list1.FindIndex(Test);
            Console.WriteLine(n1);
            int n2 = list2.FindIndex(x => x[0] == 'A');
            Console.WriteLine(n2);

            Console.WriteLine("---------------------------");

            //Encontrar posição da última ocorrencia de um item na lista
            int n3 = list1.FindLastIndex(Test);
            Console.WriteLine(n3);
            int n4 = list2.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(n4);

            Console.WriteLine("---------------------------");

            //Filtrar Resultados numa lista
            List<string> ListaFiltro1 = list1.FindAll(x => x.Length == 5); //Encontrar todos os termos com 5 caractéres 
            foreach (string obj in ListaFiltro1) { Console.WriteLine(obj);}
            Console.WriteLine();
            List<string> ListaFiltro2 = list2.FindAll(x => x.Length == 5);
            foreach (string obj in ListaFiltro2) { Console.WriteLine(obj);}

            Console.WriteLine("---------------------------");

            //Remover Itens específicos, caso o valor não existir a lista permanece inalterada
            list1.Remove("Alex");
            foreach (string obj in list1) {Console.WriteLine(obj);}
            Console.WriteLine();
            list2.Remove("Lara");
            foreach (string obj in list2) {Console.WriteLine(obj);}

            Console.WriteLine("---------------------------");

            //Remover todos os itens com base em um fíltro específico
            list1.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list1) {Console.WriteLine(obj);}
            Console.WriteLine();
            list2.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list2) {Console.WriteLine(obj);}

            Console.WriteLine("---------------------------");

            //Remover itens com base em sua posição
            list1.RemoveAt(0);
            foreach (string obj in list1) {Console.WriteLine(obj);}
            Console.WriteLine();
            list2.RemoveAt(0);
            foreach (string obj in list2) {Console.WriteLine(obj);}

            //Remover uma quantidade de elementos com base na posição
            list1.RemoveRange(0, 1);
            foreach (string obj in list1) { Console.WriteLine(obj);}
            list2.RemoveRange(0, 1);
            foreach (string obj in list2) { Console.WriteLine(obj);}
        }

        static bool Test(string s) //Exemplo de função para definir filtros de busca em Find nas listas
        {
            return s[0] == 'A';
        }
    }
}
