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

            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.Write("{0}\t", array[row, column]);
                }
                Console.WriteLine("\n");
            }

        }

        public static void functionA(int n)
        {
            int[,] array = new int[n, n];
            int element = 1;

            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
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
            printArray(array, n);
        }

        public static void functionD(int n)
        {
            int[,] array = new int[n, n];
            int el = 0;
            int colPos = 0;
            int rowPos = 0;
            int element = 0;

            while (el < n * n)
            {
                el += goDown(array, colPos, rowPos, n - element, el + 1);
                rowPos += (n - element - 1);
                colPos++;

                element++;

                if (el == (n * n))
                {
                    break;
                }

                el += goRight(array, rowPos, colPos, n - element, el + 1);
                rowPos--;
                colPos += (n - element - 1);

                if (el == (n * n))
                {
                    break;
                }

                el += goUp(array, colPos, rowPos, n - element, el + 1);
                colPos--;
                rowPos -= (n - element - 1);

                element++;

                if (el == (n * n))
                {
                    break;
                }

                el += goLeft(array, rowPos, colPos, n - element, el + 1);
                rowPos++;
                colPos -= (n - element - 1);
            }
            printArray(array, n);
        }

        public static int goDown(int[,] array, int col, int rowStart, int passes, int valueStart)
        {
            for (int p = rowStart; p < rowStart + passes; p++)
            {
                array[p, col] = valueStart++;
            }

            return passes;
        }

        public static int goRight(int[,] array, int row, int colStart, int passes, int valueStart)
        {
            for (int p = colStart; p < colStart + passes; p++)
            {
                array[row, p] = valueStart++;
            }

            return passes;
        }

        public static int goUp(int[,] array, int col, int rowStart, int passes, int valueStart)
        {
            for (int p = rowStart; p > rowStart - passes; p--)
            {
                array[p, col] = valueStart++;
            }

            return passes;
        }

        public static int goLeft(int[,] array, int row, int colStart, int passes, int valueStart)
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
                isInteger(ref numString); //controllo che sia valido
                int n = int.Parse(numString); //lo converto in un intero e lo passo alla funzione

                Console.WriteLine("Gli elementi disposti secondo la funzione A sono:\n");
                functionA(n);

                Console.WriteLine("Gli elementi disposti secondo la funzione B sono:\n");
                functionB(n);

                Console.WriteLine("Gli elementi disposti secondo la funzione C sono:\n");
                functionC(n);

                Console.WriteLine("Gli elementi disposti secondo la funzione D sono:\n");
                functionD(n);
            }
        }
    }