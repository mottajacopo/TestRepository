using System;


namespace es_08
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
                        if (input[i] != '-')             //permette l 'inserimento di numeri negativi
                        {
                            Console.WriteLine("Errore! Inserisci di nuovo un numero:");
                            input = Console.ReadLine();
                            testDigit = false;
                            i = 0;
                        }
                    }
                }
            }
            return;
        }
        public static int GCD(int a, int b)
        {
            int c = 1; //variabile che contiene il massimo comun divisore, come minimo è 1
            int bigger;
            int smaller;

            if (Math.Abs(a) > Math.Abs(b))
            {
                bigger = a;
                smaller = b;
            }
            else
            {
                bigger = b;
                smaller = a;
            }

            for(int k = 1; k < smaller; k++)
            {
                if ((smaller % k == 0) && (bigger % k == 0))
                {
                    c = k;
                }
            }
            return c;
        }
        public static int LCM(int a, int b, int gcd)
        {
            return (Math.Abs(a * b) / gcd);
        }
        static void Main(string[] args)
        {
            int num1Int;
            int num2Int;
            string num1Str;
            string num2Str;

            Console.WriteLine("Inserisci due numeri interi per vedere il massimo comun divisore e il minimo comune multiplo:\nNumero 1:");
            num1Str = Console.ReadLine();
            isInteger(ref num1Str); //controllo che la stringa contenga unicamente un numero
            num1Int = int.Parse(num1Str); //lo converto in un intero

            Console.WriteLine("Numero 2:");
            num2Str = Console.ReadLine();
            isInteger(ref num2Str); //controllo che la stringa contenga unicamente un numero
            num2Int = int.Parse(num2Str); //lo converto in un intero
            
            Console.WriteLine("Il massimo comun divisore tra {0} e {1} è: {2}", num1Int, num2Int, GCD(num1Int, num2Int)); //stampo il MCD
            Console.WriteLine("Il minimo comune multiplo tra {0} e {1} è: {2}", num1Int, num2Int, LCM(num1Int, num2Int, GCD(num1Int, num2Int))); //stampo il mcm
        }
    }
}