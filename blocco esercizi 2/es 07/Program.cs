using System;


namespace es_07
{
    public class Program
    {
        public static void isInteger(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
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
                            Console.WriteLine("Errore! Inserisci di nuovo un numero:");
                            input = Console.ReadLine();
                            testDigit = false;
                            i = 0;
                    }
                }
            }
            return;
        }
        public static void randomizer(int n , ref int []array)
        {
            int[] arrays = new int[n] ;
            int temp;
            int swap;
            Random rand = new Random();

            Console.WriteLine("gli elementi dell array in ordine corretto sono :");
            for (int k = 0; k < n; k++)
            {
                Console.Write("{0}  ", array[k]);
            }

            for (int c = 0; c < n; c++)
            {
                swap = rand.Next(0, n);
                temp = array[c];
                array[c] = array[swap];
                array[swap] = temp;
            }

            Console.WriteLine("");
            Console.WriteLine("gli elementi dell array in ordine casuale sono :");

            for (int h = 0; h < n ; h++)
            {
                Console.Write("{0}  ", array[h]);
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            int n;
            string num;
            Console.WriteLine("inserisci un numero intero N :");
            num = Console.ReadLine();
            isInteger(ref num); //controllo che la stringa contenga unicamente un numero
            n = int.Parse(num); //lo converto in un intero

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }

            randomizer(n , ref array);
        }
    }
}
