using System;


namespace es_01
{
    public class Program
    {
        public static bool greater(float num1, float num2)
        {
            float a = num1;
            float b = num2;
            float c = a - b;

            return c;
        }    //restituisce true se a > b

        public static bool smaller(float num1, float num2)
        {
            float a = num1;
            float b = num2;
            bool c = a < b;
            return c;
        }    //restituisce true se a < b

        public static float isFloat(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            float num = 0;
            while (!float.TryParse(input, out num))
            {
                Console.Write("Errore! Inserisci di nuovo un numero: ");
                input = Console.ReadLine();
            }
            return num;
           
        }

        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            bool big;
            bool small;
            string input;

            Console.WriteLine("Inserisci 2 numeri per sapere qual è il maggiore e qual è il minore dei due:");

            Console.Write("Numero 1: ");
            input = Console.ReadLine();
            num1 = isFloat(ref input);          //controllo se l 'input inserito è un numero 

            Console.Write("Numero 2: ");
            input = Console.ReadLine();
            num2 = isFloat(ref input);          //controllo se l 'input inserito è un numero 

            big = greater(num1, num2);        //se a > b big = true
            small = smaller(num1, num2);      //se a < b small = false

            Console.WriteLine("{1} è maggiore di {2} ? {0}" ,big , num1 ,num2);
            Console.WriteLine("{1} è minore di {2} ? {0}", small , num1 ,num2);

        }
    }
}


