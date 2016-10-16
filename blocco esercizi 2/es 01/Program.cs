using System;


namespace es_01
{
    public class Program
    {
        public static bool greater(float num1, float num2)
        {
            float a = num1;
            float b = num2;
            bool c = a > b;
            return c;
        }    //restituisce true se a > b

        public static bool smaller(float num1, float num2)
        {
            float a = num1;
            float b = num2;
            bool c = a < b;
            return c;
        }    //restituisce true se a < b

        public static void isFloat(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {                    
           int i = 0;
           bool testDigit = false;

           while (testDigit == false)
                testDigit = true;
            for (; i < input.Length; i++)
            {
                if (!Char.IsDigit(input[i]))         //se il char non è un numero ritorna falso
                {
                    if (input[i] != ',' && input[i] != '-')             //permette l 'inserimento di numeri con la virgola
                    {
                        Console.WriteLine("errore inserisci di nuovo numero : ");
                        input = Console.ReadLine();
                        testDigit = false;
                        i = 0;
                    }
                }
                   
            }
            return ;
        }

        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            bool big;
            bool small;
            string input;

            Console.WriteLine("Inserisci 2 numeri per sapere qual è il maggiore e qual è il minore dei due:");

            Console.WriteLine("Numero 1: ");
            input = Console.ReadLine();

            isFloat(ref input);          //controllo se l 'input inserito è un numero 
            num1 = float.Parse(input);

            Console.WriteLine("Numero 2: ");
            input = Console.ReadLine();

            isFloat(ref input);          //controllo se l 'input inserito è un numero 
            num2 = float.Parse(input);

            big = greater(num1, num2);        //se a > b big = true
            small = smaller(num1, num2);      //se a < b small = false

            Console.WriteLine("{1} è maggiore di {2} ? {0}" ,big , num1 ,num2);
            Console.WriteLine("{1} è minore di {2} ? {0}", small , num1 ,num2);

        }
    }
}
