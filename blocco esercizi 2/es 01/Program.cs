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

        public static bool isfloateger(string stringa)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {                    
           int i = 0;

            for (; i < stringa.Length; i++)
            {
                if (!Char.IsDigit(stringa[i]))         //se il char non è un numero ritorna falso
                {
                    if (stringa[i] != ',')             //permette l 'inserimento di numeri con la virgola
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            bool big;
            bool small;
            bool isDigit;
            string input;

            Console.WriteLine("inserisci 2 numeri per sapere quale è il maggiore e quale è il minore dei due");

            Console.WriteLine("numero 1: ");
            input = Console.ReadLine();
            isDigit = isfloateger(input);          //controllo se l 'input inserito è un numero 
            while (isDigit == false)             //ciclo finchè non viene inserito un numero
            {
                    Console.WriteLine("errore inserisci di nuovo numero : ");
                    input = Console.ReadLine();
                    isDigit = isfloateger(input);

            }
            num1 = float.Parse(input);

            Console.WriteLine("numero 2: ");
            input = Console.ReadLine();
            isDigit = isfloateger(input);          //controllo se l 'input inserito è un numero 
            while (isDigit == false)             //ciclo finchè non viene inserito un numero
            {
               
                    Console.WriteLine("errore inserisci di nuovo numero : ");
                    input = Console.ReadLine();
                    isDigit = isfloateger(input);

            }

            num2 = float.Parse(input);

            big = greater(num1, num2);        //se a > b big = true
            small = smaller(num1, num2);      //se a < b small = false

            Console.WriteLine("{1} è maggiore di {2} ? {0}" ,big , num1 ,num2);
            Console.WriteLine("{1} è minore di {2} ? {0}", small , num1 ,num2);

        }
    }
}
