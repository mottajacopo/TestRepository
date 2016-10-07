using System;

namespace es_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero di 4 cifre");
            string numero = Console.ReadLine();

            //somma cifre 
            int a = (int)Char.GetNumericValue(numero[0]);
            int b = (int)Char.GetNumericValue(numero[1]);
            int c = (int)Char.GetNumericValue(numero[2]);
            int d = (int)Char.GetNumericValue(numero[3]);
            int somma = a+b+c+d;
            Console.WriteLine("la somma delle cifre e' : {0}", somma);

            //inverti numero
            Console.WriteLine("il numero invertito e':{0}{1}{2}{3}" ,
               numero[3], numero[2], numero[1], numero[0]);

            //scambia prima e ultima cifra
            Console.WriteLine("il numero con la prima e l' ultima cifra scambiate e':{0}{1}{2}{3}", 
                numero[3], numero[1], numero[2], numero[0]);

            //scambia seconda e terza cifra
            Console.WriteLine("il numero con la seconda e la terza cifra scambiate e':{0}{1}{2}{3}",
               numero[0], numero[2], numero[1], numero[3]);


        }
    }
}
