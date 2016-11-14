using System;

namespace es_01
{
    public class Program
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

            switch (position) {
                case 0:
                    if (array[0] > array[1])
                    {
                        Console.WriteLine("Il primo elemento è maggiore del suo vicino, che è {0}", array[1]);
                    }
                    else
                    {
                        Console.WriteLine("Il primo elemento non è maggiore del suo vicino, che è {0}.", array[1]);
                    }
                    break;
             
                default:
                    if (position == (n - 1))
                    {
                        if (array[array.Length - 1] > array[array.Length - 2])
                        {
                            Console.WriteLine("L'ultimo elemento è maggiore del suo vicino, che è {0}", array[array.Length - 2]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("L'ultimo elemento non è maggiore del suo vicino, che è {0}", array[array.Length - 2]);
                            break;
                        }
                    }
                    result = GreaterThanNeighbours(array, n, position);

                    if (result == true)
                    {
                        Console.WriteLine("L'elemento {0} è maggiore di entrambi i suoi vicini che sono {1} e {2}", array[position], array[position - 1], array[position + 1]);
                    }
                    else
                    {
                        Console.WriteLine("L' elemento {0} non è maggiore di entrambi i suoi vicini che sono {1} e {2}", array[position], array[position - 1], array[position + 1]);
                    }
                    break;
            }
        }
    }
}
