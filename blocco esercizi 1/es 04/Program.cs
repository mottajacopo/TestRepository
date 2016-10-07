using System;

namespace es_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci i dati del dipendente:");

            Console.WriteLine("Nome :");
            string firstName = Console.ReadLine();

            Console.WriteLine("Cognome :");
            string lastName = Console.ReadLine();

            Console.WriteLine("Genere (uomo = m , donna = f):");
            char gender = Char.Parse(Console.ReadLine());

            Console.WriteLine("Età :");
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine("Numero identificativo :");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("La scheda anagrafica è:");
            Console.WriteLine("Nome : {0} ", firstName);
            Console.WriteLine("Cognome : {0} ", lastName);
            Console.WriteLine("Genere: {0} ", gender);
            Console.WriteLine("Età : {0} ", age);
            Console.WriteLine("Numero identificativo : {0}\n", number);
        }
    }
}
