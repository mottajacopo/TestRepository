using System;

namespace es_01
{
    public class Program
    {
        public static float Greater(float a, float b)
        {
            float c = a - b;
            float d = c - 1;         // serve nel caso la differenza sia minore di 1
            float k = ((int)d >> 31) & 0x1;
            float max = a - k * c;
            return max;
        }    

        public static float Smaller(float a, float b)
        {
            float c = a - b;
            float d = c - 1;
            float k = ((int)d >> 31) & 0x1;
            float min = b + k * c;
            return min;
        }    

        public static float IsFloat(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
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

            Console.WriteLine("Inserisci 2 numeri per sapere qual è il maggiore e qual è il minore dei due:");

            Console.Write("Numero 1: ");
            input = Console.ReadLine();
            num1 = IsFloat(ref input);          //controllo se l 'input inserito è un numero 

            Console.Write("Numero 2: ");
            input = Console.ReadLine();
            num2 = IsFloat(ref input);          //controllo se l 'input inserito è un numero 

            Console.Write("\nIl maggiore è: {0}\n", Greater(num1, num2));
            Console.Write("Il minore è: {0}\n\n", Smaller(num1, num2));
        }
    }
}


