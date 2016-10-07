using System;

namespace es_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero per vedere se e' un numero primo(1<n>100)");
            double numero = double.Parse(Console.ReadLine());

            if (numero < 0 || numero > 100)
            {
                Console.WriteLine("errore : numero non compreso tra 0 e 100");
                Console.WriteLine("inserisci un numero per vedere se e' un numero primo(1<n>100)");
            }

            int k= 1;
            while (k <= Math.Sqrt(numero))
            {
                if (numero % k == 0)
                {
                    Console.WriteLine("non e' un numero primo");
                    break;
                }

                k++;
            }
            
        }
    }
}
