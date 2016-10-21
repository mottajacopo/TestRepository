using System;


namespace es_07
{
    public class Program
    {
        public static int isInteger(ref string input)  //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int num = 0;
            while (!Int32.TryParse(input, out num) || input[0] == '-')
            {
                Console.Write("Errore! Inserisci di nuovo un numero: ");
                input = Console.ReadLine();
            }
            return num;
        } 

        public static void randomizer(int n , ref int []array)
        {
            int temp;
            int swap;

            int [] testArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                testArray[i] = i + 1;
            }

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

                // controllo per evitare che un numero finisca casualmente nella sua posizione originale
                while (array[c] == testArray[swap] || array[c] == swap +1 || array[swap] == c+1)
                {
                    swap = rand.Next(0, n);
                }

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
            n = isInteger(ref num); //controllo che la stringa contenga unicamente un numero

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }

            randomizer(n , ref array);
        }
    }
}
