using System;

namespace FormataçõesDeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper(); //Para Maiúscula
            string s2 = original.ToLower(); //Para Minúscula
            string s3 = original.Trim(); // Apaga espaços em branco

            int n1 = original.IndexOf("bc"); //Achar primeira ocorrência de uma string
            int n2 = original.LastIndexOf("bc"); // Achar última ocorrência de uma string

            string s4 = original.Substring(3); //Recorta a string em um determinado índice
            string s5 = original.Substring(3, 5); //Recorta a string em um determinado índice e com um comprimento definido

            string s6 = original.Replace('a', 'x'); // Substituí um char por outro
            string s7 = original.Replace("abc", "xy"); //Substituí uma string por outra

            bool b1 = String.IsNullOrEmpty(original); //Indica se a string é vazia
            bool b2 = String.IsNullOrWhiteSpace(original); //Indica se a string é nula ou se só possuí espaços em branco

            Console.WriteLine("Original: -"+ original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("Indice de 'bc': " + n1 );
            Console.WriteLine("Último Indice de 'bc': " + n2);
            Console.WriteLine("SubString(3): -" + s4 + "-");
            Console.WriteLine("SubString(3,5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace:" + b2);
        }
    }
}
