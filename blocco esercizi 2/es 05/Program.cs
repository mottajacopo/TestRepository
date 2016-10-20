using System;


namespace es_05
{
    public class Program
    {

        public static void isFloat(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int i = 0;
            bool isDigit = false;

            while (isDigit == false)
            {
                for (; i < input.Length; i++)
                {
                    if (!Char.IsDigit(input[i]))         //se il char non è un numero ritorna falso
                    {
                        Console.Write("Errore! Inserisci di nuovo un numero: ");
                        input = Console.ReadLine();
                        isDigit = false;
                        i = -1;
                    }
                    isDigit = true;
                }
            }
            return;
        }
        public static float factorial (float n)        // funzione ricorsiva per calcolare fattoriale
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

        public static float exponential(float x , float n)
        {
            float p = 1;
            for (int h = 0; h < n; h++)
            {
                p *= x;
            }
            return p;
        }
        public static float calculate(float x, float n)         
        {
            float s = 0;
            for (int i = 0; i <=n; i++)
            {
                s += factorial(i) / exponential(x , i);
            }
            return s;
        }
        static void Main(string[] args)
        {
            float n;
            float x;
            string input;
            float s;

            Console.WriteLine("Inserisci n e x per calcolare s = 1 + 1!/x + 2!/x^2 + … + n!/x^n");

            Console.Write("Inserisci x: ");
            input = Console.ReadLine();
            isFloat(ref input);
            x = float.Parse(input);

            Console.Write("Inserisci n: ");
            input = Console.ReadLine();
            isFloat(ref input);
            n = float.Parse(input);

            s = calculate(x, n);
            Console.WriteLine("La somma è: {0}", s);
        }
    }
}
