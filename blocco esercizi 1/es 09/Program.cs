using System;

namespace es_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int position;
            int i = 1;

            Console.WriteLine("Inserisci un numero intero:");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il numero della posizione del bit:");
            position = int.Parse(Console.ReadLine());

            int mask = i << position;
            Console.WriteLine("Il bit nella posizione {0} del numero {1} e':", position, number);
            Console.WriteLine((number & mask) != 0 ? "1" : "0");
        }
    }
}
