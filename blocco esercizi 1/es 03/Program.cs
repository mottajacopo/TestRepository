using System;

namespace es_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Ciao";
            string b = "mondo!";
            object ab = a + " " + b;

            Console.WriteLine("La stringa completa e': {0}", ab);
        }
    }
}
