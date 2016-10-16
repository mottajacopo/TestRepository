using System;

namespace es_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero di 4 cifre:");
            string number = Console.ReadLine();

            //aggiunto controllo validità del numero
            while (!char.IsDigit(number[0]) || !char.IsDigit(number[1]) || !char.IsDigit(number[2]) || !char.IsDigit(number[3]) || number.Length != 4)  
            {
                Console.WriteLine("Reinserisci un numero di 4 cifre:");
                number = Console.ReadLine();
             
            }
            //somma cifre 
            byte a = (byte)Char.GetNumericValue(number[0]);
            byte b = (byte)Char.GetNumericValue(number[1]);
            byte c = (byte)Char.GetNumericValue(number[2]);
            byte d = (byte)Char.GetNumericValue(number[3]);
            int sum = a + b + c + d;
            Console.WriteLine("La somma delle cifre è: {0}", sum);

            //inverti numero
            Console.WriteLine("Il numero invertito è: {0}{1}{2}{3}" ,
               number[3], number[2], number[1], number[0]);

            //scambia prima e ultima cifra
            Console.WriteLine("Il numero con la prima e l' ultima cifra scambiate è: {0}{1}{2}{3}", 
                number[3], number[1], number[2], number[0]);

            //scambia seconda e terza cifra
            Console.WriteLine("il numero con la seconda e la terza cifra scambiate è: {0}{1}{2}{3}\n",
               number[0], number[2], number[1], number[3]);
        }
    }
}
