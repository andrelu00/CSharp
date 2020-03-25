using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] { "Maria", "Alex", "Bob" };

            foreach(string obj in vetor) //Forma de fazer um for mais fácil
            {
                Console.WriteLine(obj);
            }
        }
    }
}
