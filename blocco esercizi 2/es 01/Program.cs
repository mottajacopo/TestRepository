using System;

namespace es_01
{
    public class Program
    {
        public static float greater(float a, float b)
        {
            float c = a - b;
            float d = c - 1;         // serve nel caso la differenza sia minore di 1
            float k = ((int)d >> 31) & 0x1;
            float max = a - k * c;
            return max;
        }    

        public static float smaller(float a, float b)
        {
            float c = a - b;
            float d = c - 1;
            //float d = (float)Math.Round(c);
            float k = ((int)d >> 31) & 0x1;
            float min = b + k * c;
            return min;
        }    

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
            string input;

            Console.WriteLine("Inserisci 2 numeri floateri per sapere qual è il maggiore e qual è il minore dei due:");

            Console.Write("Numero 1: ");
            input = Console.ReadLine();
            num1 = isFloat(ref input);          //controllo se l 'input inserito è un numero 

            Console.Write("Numero 2: ");
            input = Console.ReadLine();
            num2 = isFloat(ref input);          //controllo se l 'input inserito è un numero 

            Console.Write("\nIl maggiore è: {0}\n", greater(num1, num2));
            Console.Write("Il minore è: {0}\n\n", smaller(num1, num2));
        }
    }
}


