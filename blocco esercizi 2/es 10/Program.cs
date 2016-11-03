using System;

namespace es_10
{
    public class Program
    {
        public static int IsInteger(ref string input)
        {
            int num = 0;
            while (!Int32.TryParse(input, out num) || input[0] == '-')
            {
                Console.WriteLine("Errore! Inserisci di nuovo un numero: ");
                input = Console.ReadLine();
            }
            return num;
        }

        public static void PrintArray(int[,] array, int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.Write("{0}\t", array[row, column]);
                }
                Console.WriteLine("\n");
            }
        }

        public static int[,] FunctionA(int n, int[,] array)
        {

            int element = 1;

            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    array[column, row] = element;
                    element++;
                }
            }
            PrintArray(array, n);
            return array;
        }

        public static int[,] FunctionB(int n, int[,] array)
        {
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
            PrintArray(array, n);
            return array;
        }

        public static int[,] FunctionC(int n, int[,] array)
        {
            int element = 1;
            for (int row = n - 1; row >= 0; row--)
            {
                for (int column = 0; row + column < n; column++)
                {
                    array[row + column, column] = element++;
                }
            }

            for (int column = 1; column < n; column++)
            {
                for (int row = 0; row + column < n; row++)
                {
                    array[row, row + column] = element++;
                }
            }
            PrintArray(array, n);
            return array;
        }

        public static int[,] FunctionD(int n, int[,] array)
        {
            int el = 0;
            int colPos = 0;
            int rowPos = 0;
            int element = 0;

            while (el < n * n)
            {
                el += GoDown(array, colPos, rowPos, n - element, el + 1);
                rowPos += (n - element - 1);
                colPos++;

                element++;

                if (el == (n * n))
                {
                    break;
                }
                
                el += GoRight(array, rowPos, colPos, n - element, el + 1);
                rowPos--;
                colPos += (n - element - 1);

                if (el == (n * n))
                {
                    break;
                }

                el += GoUp(array, colPos, rowPos, n - element, el + 1);
                colPos--;
                rowPos -= (n - element - 1);

                element++;

                if (el == (n * n))
                {
                    break;
                }

                el += GoLeft(array, rowPos, colPos, n - element, el + 1);
                rowPos++;
                colPos -= (n - element - 1);
            }
            PrintArray(array, n);
            return array;
        }

        public static int GoDown(int[,] array, int col, int rowStart, int passes, int valueStart)
        {
            for (int p = rowStart; p < rowStart + passes; p++)
            {
                array[p, col] = valueStart++;
            }

            return passes;
        }

        public static int GoRight(int[,] array, int row, int colStart, int passes, int valueStart)
        {
            for (int p = colStart; p < colStart + passes; p++)
            {
                array[row, p] = valueStart++;
            }

            return passes;
        }

        public static int GoUp(int[,] array, int col, int rowStart, int passes, int valueStart)
        {
            for (int p = rowStart; p > rowStart - passes; p--)
            {
                array[p, col] = valueStart++;
            }

            return passes;
        }

        public static int GoLeft(int[,] array, int row, int colStart, int passes, int valueStart)
        {
            for (int p = colStart; p > colStart - passes; p--)
            {
                array[row, p] = valueStart++;
            }

            return passes;
        }

        static void Main(string[] args)
        {
            Console.Write("Inserisci la dimensione dell'array: ");
            string numString = Console.ReadLine(); //prendo il numero come stringa

            int n = IsInteger(ref numString); //controllo che sia valido

            int[,] arrayA = new int[n, n];
            int[,] arrayB = new int[n, n];
            int[,] arrayC = new int[n, n];
            int[,] arrayD = new int[n, n];

            Console.WriteLine("Gli elementi disposti secondo la funzione A sono:\n");
            arrayA = FunctionA(n, arrayA);

            Console.WriteLine("Gli elementi disposti secondo la funzione B sono:\n");
            arrayB = FunctionB(n, arrayB);

            Console.WriteLine("Gli elementi disposti secondo la funzione C sono:\n");
            arrayC = FunctionC(n, arrayC);

            Console.WriteLine("Gli elementi disposti secondo la funzione D sono:\n");
            arrayD = FunctionD(n, arrayD);

        }
    }
}
