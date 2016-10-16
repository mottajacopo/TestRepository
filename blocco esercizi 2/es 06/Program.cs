using System;


namespace es_06
{
    public class Program
    {
        public static string fromDecToBin (int number) {

            int rest = 0;
            string binary = "";
            string digit = "0";

            while (number >= 1)
            {
                rest = number % 2;
                number = number / 2;

                if (rest == 0)
                {
                    binary = "0" + binary;
                }
                else
                {
                    binary = "1" + binary;
                }   
            }
            return binary;
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero intero:");
            int dec = int.Parse(Console.ReadLine());
            string bin;
            bin = fromDecToBin(dec);
            Console.WriteLine("{0}", bin);
        }
    }
}
