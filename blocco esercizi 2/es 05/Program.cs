using System;


namespace es_05
{
    public class Program
    {

        public static int isInteger(ref string input)  //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int num = 0;
            while (!Int32.TryParse(input, out num))
            {
                Console.Write("Errore! Inserisci di nuovo un numero: ");
                input = Console.ReadLine();
            }
            return num;
        } 

        public static double factorial (double n)        // funzione ricorsiva per calcolare fattoriale
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

        public static double exponential(double x , double n)
        {
            double p = 1;
            for (int h = 0; h < n; h++)
            {
                p *= x;
            }
            return p;
        }

        public static double calculate(double x, double n)         
        {
            double s = 0;
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
            double s;

            Console.WriteLine("Inserisci n e x per calcolare s = 1 + 1!/x + 2!/x^2 + … + n!/x^n");

            Console.Write("Inserisci x: ");
            input = Console.ReadLine();
            
            x = isInteger(ref input);

            Console.Write("Inserisci n: ");
            input = Console.ReadLine();
            
            n = isInteger(ref input);

            s = calculate(x, n);
            Console.WriteLine("La somma è: {0}", s);
        }
    }
}
