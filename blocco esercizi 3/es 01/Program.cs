using System;

namespace es_01
{
    public class Program
    {
        public static int GreaterThanNeighbours(int []array , int n , int position)
        {
            int result = 0;

            if (array[0] > array[1] && position == 0)
            {
                result = 1;
                return result;
            }
            
            if (array[array.Length - 1] > array[array.Length - 2] && position == n-1)
            {
                result = 2;
                return result;
            }
            if (position != 0 && position != n - 1)
                {
                if (array[position] > array[position - 1] && array[position] > array[position + 1])
                {
                    result = 3;
                    return result;
                }
            }
            return result;
        }
        public static int IsInteger(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int num = 0;
            while (!Int32.TryParse(input, out num))
            {
                Console.WriteLine("Errore! Inserisci di nuovo un numero: ");
                input = Console.ReadLine();
            }
            return num;
        }

        public static int FindFirstOccurrence(int [] array , int  n)
        {
            int index = -1;
            int result;

            for (int i = 0; i <n; i++)
            {
                index = i;
                result = GreaterThanNeighbours(array, n, i);
                if (result == 1 || result == 2 || result == 3)
                {
                    return index;
                }
            }

            return index;
        }
        static void Main(string[] args)
        {
            int n;
            string input;
            int result;
            int position;

            Console.Write("Inserisci la lunghezza dell' array: ");

            input = (Console.ReadLine());
            if (input[0] == '-')
            {
                Console.Write("Errore! Inserisci di nuovo un numero: ");
                input = (Console.ReadLine());
            }
            n = IsInteger(ref input);

            int[] array = new int[n];
            Console.WriteLine();
            Console.WriteLine("Inserisci gli elementi dell' array:");

            for (int i = 0; i < n; i++)
            {
                input = (Console.ReadLine());
                array[i] = IsInteger(ref input);
            }

            Console.WriteLine("Inserisci la posizione dell' elemento del quale vuoi verificare se è maggiore dei 2 elementi vicini:");
            input = Console.ReadLine();
            position = IsInteger(ref input);

            result = GreaterThanNeighbours(array, n, position);

            switch (result)
            {
                case 1:
                    Console.WriteLine("Il primo elemento è maggiore del suo vicino, che è {0}", array[1]);
                    break;
                case 2:
                    Console.WriteLine("L'ultimo elemento è maggiore del suo vicino, che è {0}", array[array.Length - 2]);
                    break;
                case 3:
                    Console.WriteLine("L'elemento {0} è maggiore di entrambi i suoi vicini che sono {1} e {2}", array[position], array[position - 1], array[position + 1]);
                    break;
                default:
                    Console.WriteLine("L' elemento {0} non è maggiore di entrambi i suoi vicini che sono {1} e {2}", array[position], array[position - 1], array[position + 1]);
                    break;

                    
            }
            int index = Program.FindFirstOccurrence(array , n);

        }
    }
}
