using System;


namespace es_05
{
    public class Program
    {

        public static void isfloateger(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int i = 0;
            bool isDigit = false;

            while (isDigit == false)
            {
                for (; i < input.Length; i++)
                {
                    if (!Char.IsDigit(input[i]))         //se il char non è un numero ritorna falso
                    {
                        Console.WriteLine("errore inserisci di nuovo numero : ");
                        input = Console.ReadLine();
                        isDigit = false;
                        i = -1;
                    }
                    isDigit = true;
                }
            }
            return;
        }
        public static int factorial (int n)        // funzione ricorsiva per calcolare fattoriale
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return (n * factorial(n -1));
            } 
        }

        public static int exponential(int x , int n)
        {
            int p = 1;
            for (int h = 0; h < n; h++)
            {
                p *= x;
            }
            return p;
        }
        public static int calculate(int x, int n)         
        {
            int s = 0;
            for (int i = 0; i <=n; i++)
            {
                s += factorial(i) / exponential(x , i);
            }
            return s;
        }
        static void Main(string[] args)
        {
            int n;
            int x;
            string input;
            int s;

            Console.WriteLine("inserisci n e x per calcolare s = 1 + 1!/x + 2!/x^2 + … + n!/x^n");

            Console.WriteLine("inserisci x :");
            input = Console.ReadLine();
            isfloateger(ref input);
            x = int.Parse(input);

            Console.WriteLine("inserisci n :");
            input = Console.ReadLine();
            isfloateger(ref input);
            n = int.Parse(input);

            s = calculate(x, n);
            Console.WriteLine("la somma è : {0}", s);

           

        }
    }
}
