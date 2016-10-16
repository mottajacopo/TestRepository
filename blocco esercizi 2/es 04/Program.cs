using System;


namespace es_04
{
    public class Program
    {
        public static void pronunciationOfNumber(ref short numShort, ref string numString)
        {
            string[] oneToNineteen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                                        "ten", "eleven", "twelve", "thirteen", "fourteen", "fiveteen", "sixteen",
                                        "seventeen", "eighteen", "nineteen"};
            string[] dozens = { "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred" };
            string phrase;

            if (numShort < 20)
            {
              phrase = oneToNineteen(numShort);
            }
        } 
        public static void isInteger(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int i = 0;
            bool testDigit = false;

            while (testDigit == false)
                testDigit = true;
            for (; i < input.Length; i++)
            {
                if (!Char.IsDigit(input[i]) || (input.Length > 3))         //se il char non è un numero o non è compreso tra 0 e 999 lo reinserisco
                {
                        Console.WriteLine("Errore! Inserisci di nuovo un numero (tra 0 e 999): ");
                        input = Console.ReadLine();
                        testDigit = false;
                        i = 0;
                }

            }
            return;
        }
        static void Main(string[] args)
        {
            string numString; //numero scritto in una stringa
            short numShort; //stesso numero ma scritto in una variabile "short"

            Console.WriteLine("Inserisci un numero tra 0 e 999:");

            numString = Console.ReadLine();
            isInteger(ref numString);
            numShort = short.Parse(numString);

            Console.WriteLine("{0} in parole è:", numShort);
            pronunciationOfNumber(ref numShort, ref numString);


        }
    }
}
