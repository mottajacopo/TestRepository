using System;


namespace es_10
{
    public class Program
    {
        public static void isInteger(ref string input)
        {
            int i = 0;
            bool testDigit = false;

            while (testDigit == false)
            {
                testDigit = true;

                for (; i < input.Length; i++)
                {
                    if (!Char.IsDigit(input[i]))         //se il char non è un numero lo reinserisco
                    {
                        Console.Write("Errore! Inserisci di nuovo un numero: ");
                        input = Console.ReadLine();
                        testDigit = false;
                        i = -1;
                    }
                }
            }
            return;
        }
        public static void printArray(int[,] array, int n) {
            
            for(int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.Write("{0}\t", array[row, column]);
                }
                Console.WriteLine("\n");
            }

            }
        public static void functionA (int n)
        {
            int[,] array = new int[n, n];
            int element = 1;

            for(int row = 0; row < n; row++ )
            {
                for(int column = 0; column < n; column++)
                {
                    array[column, row] = element;
                    element++;
                }
            }
            printArray(array, n);
        }
        public static void functionB(int n)
        {
            int[,] array = new int[n, n];
            int element = 1;
            bool x = true;  

            for (int row = 0; row < n; row++)
            {
            if (x)
                {
                    for (int column = 0; column < n; column++)
                    {
                        array[column, row] = element;
                        element++;
                    }
                    x = false;
                }
            else
                {
                    for (int column = n - 1; column >= 0; column--)
                    {
                        array[column, row] = element;
                        element++;
                    }
                    x = true;
                }
            }
            printArray(array, n);
        }
        public static void functionC(int n)
        {
            int[,] array = new int[n, n];
            int element = 1;
            int x = 0;

            for (int k = 0; k < n; k++)
            {
                for (int i = n - 1; i <= x; i++)
                {
                array[i, k] = element;
                element++;
                }
                x += x;
            }
            printArray(array, n);
        }

        static void Main(string[] args)
        {
            Console.Write("Inserisci la dimensione dell'array: ");
            string numString = Console.ReadLine(); //prendo il numero come stringa
            isInteger(ref numString); //controllo che sia valido
            int n = int.Parse(numString); //lo converto in un intero e lo passo alla funzione

            Console.WriteLine("Gli elementi disposti secondo la funzione A sono:\n");
            functionA(n);

            Console.WriteLine("Gli elementi disposti secondo la funzione B sono:\n");
            functionB(n);

            Console.WriteLine("Gli elementi disposti secondo la funzione C sono:\n");
            functionC(n);
        }
    }
}
