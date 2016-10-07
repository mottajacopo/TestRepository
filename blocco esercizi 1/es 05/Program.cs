using System;

namespace es_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int temp;

            Console.WriteLine("I valori di a e b prima della sostituzione sono:\na = {0}\nb = {1}\n", a, b);

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("I valori di a e b dopo la sostituzione sono:\na = {0}\nb = {1}", a, b);
        }
    }
}
