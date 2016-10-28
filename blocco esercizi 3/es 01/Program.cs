using System;

namespace es_01
{
    class Program
    {
        public static bool GreaterThanNeighbours(int []array , int n , int position)
        {
            bool result = false;

            if (array[position] > array[position -1] && array[position] > array[position + 1])
            {
                result = true;
            }

            return result;
        }
        public static int isInteger(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int num = 0;
            while (!Int32.TryParse(input, out num))
            {
                Console.WriteLine("Errore! Inserisci di nuovo un numero: ");
                input = Console.ReadLine();
            }
            return num;
        }
        static void Main(string[] args)
        {
            int n;
            string input;
            bool result;
            int position;

            Console.Write("Inserisci la lunghezza dell' array: ");

            input = (Console.ReadLine());
            if (input[0] == '-')
            {
                Console.Write("Errore! Inserisci di nuovo un numero: ");
                input = (Console.ReadLine());
            }
            n = isInteger(ref input);

            int[] array = new int[n];
            Console.WriteLine();
            Console.WriteLine("Inserisci gli elementi dell' array:");

            for (int i = 0; i < n; i++)
            {
                input = (Console.ReadLine());
                array[i] = isInteger(ref input);
            }

            Console.WriteLine("inserisci la posizione dell elemento del quale vuoi verificare se è maggiore dei 2 elementi vicini");
            input = Console.ReadLine();
            position = isInteger(ref input);

            result = GreaterThanNeighbours(array, n , position);

            if (result == true)
            {
                Console.WriteLine("l elemento {0} è maggiore di entrambi i suoi vicini che sono {1} e {2}", array[position], array[position - 1], array[position + 1]);
            }
            else
            {
                Console.WriteLine("l elemento {0} non è maggiore di entrambi i suoi vicini che sono {1} e {2}", array[position], array[position - 1], array[position + 1]);
            }
        }
    }
}
