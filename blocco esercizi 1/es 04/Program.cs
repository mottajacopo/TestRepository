using System;

namespace es_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Inserisci i dati del dipendente:");

            Console.WriteLine("Nome :");
            string firstName = Console.ReadLine();

            Console.WriteLine("Cognome :");
            string lastName = Console.ReadLine();

            Console.WriteLine("Genere (uomo = m , donna = f):");
            input = Console.ReadLine();
            while (input[0] != 'm' && input[0] != 'f')           //aggiunto controllo inserimento genere
            {
                Console.WriteLine("Formato genere non corretto ");
                Console.WriteLine("Reinserire genere (uomo = m , donna = f):");
                input = Console.ReadLine();
            }
            char gender = Char.Parse(input);

            Console.WriteLine("Età :");
            input = Console.ReadLine();
            while (!Char.IsDigit(input[0]))           //aggiunto controllo inserimento età
            {
                Console.WriteLine("Formato genere non corretto ");
                Console.WriteLine("Reinserire età (attenzione non inserire età negative o lettere):");
                input = Console.ReadLine();
            }
            byte age = byte.Parse(input);

            Console.WriteLine("Numero identificativo (compreso tra 27560000 to 27569999):");
            input = Console.ReadLine();
            while (!Char.IsDigit(input[0]) && int.Parse(input) > 27560000 && int.Parse(input) < 27569999)           //aggiunto controllo inserimento età
            {
                Console.WriteLine("Formato non corretto ");
                Console.WriteLine("Reinserire numero identificativo (attenzione non inserire lettere o numeri non compresi nell' intervallo previsto):");
                input = Console.ReadLine();
            }
            int number = int.Parse(input);

            Console.WriteLine("La scheda anagrafica è:");
            Console.WriteLine("Nome : {0} ", firstName);
            Console.WriteLine("Cognome : {0} ", lastName);
            Console.WriteLine("Genere: {0} ", gender);
            Console.WriteLine("Età : {0} ", age);
            Console.WriteLine("Numero identificativo : {0}\n", number);
        }
    }
}
