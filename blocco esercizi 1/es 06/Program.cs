using System;


namespace es_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero per sapere se è pari o dispari:");
            int number = int.Parse(Console.ReadLine());
            int remainder = number % 2;

            if (remainder == 0)
            {
                Console.WriteLine("{0} è pari.\n" , number);
            }
            else
            {
                Console.WriteLine ("{0} è dispari.\n" , number);
            }
            
        }
    }
}
