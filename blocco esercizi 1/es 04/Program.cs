using System;

namespace es_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci i dati del dipendente");

            Console.WriteLine("nome :");
            string firstName = Console.ReadLine();
            Console.WriteLine("cognome :");
            string lastName = Console.ReadLine();
            Console.WriteLine("genere (uomo = m , donna = f):");
            char gender = Char.Parse(Console.ReadLine());
            Console.WriteLine("numero identificativo :");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("eta' :");
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine("la scheda anagrafica e' :");
            Console.WriteLine("nome : {0} ", firstName);
            Console.WriteLine("cognome : {0} ", lastName);
            Console.WriteLine("genere: {0} ", gender);
            Console.WriteLine("numero identificativo : {0} ", number);
            Console.WriteLine("eta' : {0} ", age);
        }
    }
}
