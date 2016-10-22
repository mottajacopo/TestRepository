using System;

namespace es_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num; //per il controllo di età e numero identificativo

            Console.WriteLine("Inserisci i dati del dipendente:");

            Console.Write("Nome: ");
            string firstName = Console.ReadLine();

            Console.Write("Cognome: ");
            string lastName = Console.ReadLine();

            Console.Write("Genere (uomo = m , donna = f): ");
            input = Console.ReadLine();
            while (input.Length != 1 ||  input[0] != 'm' && input[0] != 'f')           //aggiunto controllo inserimento genere
            {
                Console.WriteLine("Formato genere non corretto!");
                Console.WriteLine("Reinserire genere (uomo = m , donna = f):");
                input = Console.ReadLine();
            }
            string gender = input ;

            Console.Write("Età: ");
            input = Console.ReadLine();
            while (!Int32.TryParse(input, out num) || input[0] == '-')
            {
                Console.WriteLine("Formato non corretto!");
                Console.WriteLine("Reinserire numero identificativo (attenzione non inserire lettere o numeri non compresi nell' intervallo previsto):");
                input = Console.ReadLine();
            }

            int age = int.Parse(input);

            Console.Write("Numero identificativo (compreso tra 27560000 to 27569999): ");
            input = Console.ReadLine();

            bool controll = false;  //aggiunto controllo range numero
            while (controll == false)
            {
                {
                    while (!Int32.TryParse(input, out num) || input[0] == '-')
                    {
                        Console.WriteLine("Formato non corretto!");
                        Console.WriteLine("Reinserire numero identificativo (attenzione non inserire lettere o numeri non compresi nell' intervallo previsto):");
                        input = Console.ReadLine();
                    }
                    if (num < 27560000 || num > 27569999)
                    {
                        Console.WriteLine("Numero non compreso nel range corretto!");
                        Console.WriteLine("Reinserire numero identificativo (attenzione non inserire lettere o numeri non compresi nell' intervallo previsto):");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        controll = true;
                    }
                }
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
