using System;

namespace es_04
{
    public class Program
    {
        public static string pronunciationOfNumber(ref short numShort, ref string numString)
        {
            string[] oneToNineteen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                                        "ten", "eleven", "twelve", "thirteen", "fourteen", "fiveteen", "sixteen",
                                        "seventeen", "eighteen", "nineteen"};
            string[] dozens = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
            string hundred = ""; // centinaia, decine e unità le inizializzo vuote
            string dozen ="";          
            string unit = "";
            byte digit; //valore della cifre che sto esaminando

            if (numShort < 20)  //se è minore di 20 stampo il numero predefinito
            {
              hundred = (oneToNineteen[numShort]);
            }
            else
            {

             if (numString.Length > 2)
                {
                    digit = (byte)Char.GetNumericValue(numString[0]);
                    hundred = (oneToNineteen[digit]) + " hundred";
                }
             else
                {
                    numString = "0" + numString;
                }
      
                digit = (byte)Char.GetNumericValue(numString[1]);

            if (digit > 1)
                {
                    dozen = (dozens[digit - 2]);
                }
            else
                {
                    digit = (byte)Char.GetNumericValue(numString[2]);
                    dozen = oneToNineteen[digit + 10];
                    hundred = hundred + " " + dozen;
                    return hundred;

                }
      
                digit = (byte)Char.GetNumericValue(numString[2]);

                if (digit != 0)
                {
                    unit = (oneToNineteen[digit]);

                }
            }
            hundred = hundred + " " + dozen + " " + unit;

            return hundred;
        }
        public static void isInteger(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int i = 0;
            bool testDigit = false;

            while (testDigit == false) { 
                testDigit = true;

                for (; i < input.Length; i++) 
                {
                    if (!Char.IsDigit(input[i]) || (input.Length > 3))         //se il char non è un numero o non è compreso tra 0 e 999 lo reinserisco
                    {
                        Console.WriteLine("Errore! Inserisci di nuovo un numero (tra 0 e 999): ");
                        input = Console.ReadLine();
                        testDigit = false;
                        i = -1;
                    }
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
            numString = pronunciationOfNumber(ref numShort, ref numString);
            Console.WriteLine("{0}", numString);
        }
    }
}
