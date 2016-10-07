using System;

namespace es_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero intero per vedere se ha il terzo bit a 1: ");
            int num = int.Parse(Console.ReadLine());
            bool bit3 = (num & 8) != 0;
            Console.WriteLine("{0} ha il terzo bit a 1? {1}", num, bit3);
        }
    }
}
