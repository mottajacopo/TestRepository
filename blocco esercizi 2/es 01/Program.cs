using System;


namespace es_01
{
    public class Program
    {
        public static int greater(int num1, int num2)
        {
            int a = num1;
            int b = num2;
            int c = a - b;
            int k = (c >> 31) & 0x1;
            int max = a - k * c;

            return max;
        }    

        public static int smaller(int num1, int num2)
        {
            int a = num1;
            int b = num2;
            int c = a - b;
            int k = (c >> 31) & 0x1;
            int min = b + k * c;

            return min;
        }    


        public static int isInteger(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
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
            int big;
            int small;
            string input;

            Console.WriteLine("Inserisci 2 numeri per sapere qual è il maggiore e qual è il minore dei due:");

            Console.Write("Numero 1: ");
            input = Console.ReadLine();
            num1 = isInteger(ref input);          //controllo se l 'input inserito è un numero 

            Console.Write("Numero 2: ");
            input = Console.ReadLine();
            num2 = isInteger(ref input);          //controllo se l 'input inserito è un numero 

            big = greater(num1, num2);        //se a > b big = true
            small = smaller(num1, num2);      //se a < b small = false

            Console.Write("Il maggiore è: {0}\n" ,big);
            Console.Write("Il minore è: {0}\n", small);

        }
    }
}


