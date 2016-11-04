using System;

namespace es_01
{
    public class Program
    {
        public static int Greater(int a, int b)
        {
            return (a + b + Math.Abs(a - b)) / 2;
        }    

        public static int Smaller(int a, int b)
        {
            return (a + b - Math.Abs(a - b)) / 2;
        }    

        public static int IsInteger(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int num = 0;
            while (!int.TryParse(input, out num))
            {
                Console.Write("Errore! Inserisci di nuovo un numero: ");
                input = Console.ReadLine();
            }
            return num;  
        }

        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string input;

            Console.WriteLine("Inserisci 2 numeri per sapere qual è il maggiore e qual è il minore dei due:");

            Console.Write("Numero 1: ");
            input = Console.ReadLine();
            num1 = IsInteger(ref input);          //controllo se l 'input inserito è un numero 

            Console.Write("Numero 2: ");
            input = Console.ReadLine();
            num2 = IsInteger(ref input);          //controllo se l 'input inserito è un numero 

            Console.Write("\nIl maggiore è: {0}\n", Greater(num1, num2));
            Console.Write("Il minore è: {0}\n\n", Smaller(num1, num2));
        }
    }
}


