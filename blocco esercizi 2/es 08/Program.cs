﻿using System;

namespace es_08
{
    public class Program
    {
        public static int IsInteger(string input)
        {
            int num = 0;
            while (!Int32.TryParse(input, out num))
            {
                Console.Write("Errore! Inserisci di nuovo un numero: ");
                input = Console.ReadLine();
            }        
            return num;
        } //controllo per verificare che vengano inseriti numeri e non lettere o altro

        public static int GCD(int a, int b)
        {
            int c = 1; //variabile che contiene il massimo comun divisore, come minimo è 1
            int bigger;
            int smaller;

            if(a == 0)  //se uno dei due è zero ritorno il modulo dell'altro
            {
                return Math.Abs(b);
            }
            if (b == 0)
            {
                return Math.Abs(a);
            }
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

            for(int k = 1; k < Math.Abs(smaller); k++)
            {
                if ((smaller % k == 0) && (bigger % k == 0))
                {
                    c = k;
                }
            }
            return c;
        } //massimo comun divisore

        public static int LCM(int a, int b, int gcd)
        {
            return (Math.Abs(a * b) / gcd);
        } //minimo comune multiplo

        static void Main(string[] args)
        {
            int num1Int;
            int num2Int;
            string num1Str;
            string num2Str;

            Console.Write("Inserisci due numeri interi per vedere il massimo comun divisore e il minimo comune multiplo:\nNumero 1: ");
            num1Str = Console.ReadLine();
            num1Int = IsInteger(num1Str); //controllo che la stringa contenga unicamente un numero

            Console.Write("Numero 2: ");
            num2Str = Console.ReadLine();
            num2Int = IsInteger(num2Str); //controllo che la stringa contenga unicamente un numero
            
            Console.WriteLine("Il massimo comun divisore tra {0} e {1} è: {2}", num1Int, num2Int, GCD(num1Int, num2Int)); //stampo il MCD
            Console.WriteLine("Il minimo comune multiplo tra {0} e {1} è: {2}", num1Int, num2Int, LCM(num1Int, num2Int, GCD(num1Int, num2Int))); //stampo il mcm
        }
    }
}
