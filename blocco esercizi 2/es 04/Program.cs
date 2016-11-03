using System;

namespace es_04
{
    public class Program
    {
        public static string PronunciationOfNumber(ref int num, ref string numString)
        {
            string[] oneToNineteen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                                        "ten", "eleven", "twelve", "thirteen", "fourteen", "fiveteen", "sixteen",
                                        "seventeen", "eighteen", "nineteen"};
            string[] dozens = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
            string hundred = ""; // centinaia, decine e unità le inizializzo vuote
            string dozen ="";          
            string unit = "";
            byte digit; //valore della cifre che sto esaminando

            if (num < 20)  //se è minore di 20 stampo il numero predefinito
            {
                hundred = (oneToNineteen[num]);
                return hundred;
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
                    numString = "0" + numString; //se il numero è minore di 100 lo interpreto come 0xx
                }

                digit = (byte)Char.GetNumericValue(numString[1]);

                if (digit > 1)
                {
                    dozen = (dozens[digit - 2]);
                }
                
                if (digit == 1)
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

        public static int IsInteger(ref string input)   //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int num = 0;
            while (!Int32.TryParse(input, out num) || input[0] == '-')
            {
                    Console.Write("Errore! Inserisci di nuovo un numero: ");
                    input = Console.ReadLine();
            }
            return num;
        }

        static void Main(string[] args)
        {
            string numString; //numero scritto in una stringa
            int num; //stesso numero ma scritto in una variabile "int"

            Console.Write("Inserisci un numero tra 0 e 999: ");

            numString = Console.ReadLine();
            num = IsInteger(ref numString);

            Console.WriteLine("{0} in parole è:", num);
            numString = PronunciationOfNumber(ref num, ref numString);
            Console.WriteLine("{0}", numString);
        }
    }
}
