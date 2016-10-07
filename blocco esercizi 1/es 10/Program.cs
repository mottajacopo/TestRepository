using System;

namespace es_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero per vedere se e' un numero primo(1<n>100)");
            int number = int.Parse(Console.ReadLine());

            while (number < 0 || number > 100)
            {
                Console.WriteLine("errore : numero non compreso tra 0 e 100");
                Console.WriteLine("inserisci un numero per vedere se e' un numero primo (1<n>100)");
                number = int.Parse(Console.ReadLine());
            }

            int k= 2;
            bool condition = true;
            while (k <= Math.Sqrt(number))
            {
                if (number % k == 0)
                {
                    Console.WriteLine("{0} non è un numero primo.", number);
                    condition = false;
                    return;
                }
                k++;
            }
            if (condition == true)
            {
                Console.WriteLine("{0} è primo.", number);
            }
        }
    }
}
