using System;
using System.Text;


namespace es_08
{
    class Program
    {
        public static string Encode(string message, string cipher)
        {

            StringBuilder coded = new StringBuilder(message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                uint firstletter = Convert.ToUInt16(message[i]); //converto i caratteri in interi a 16 bit
                uint cipherletter = Convert.ToUInt16(cipher[i % cipher.Length]);
                uint xor =(firstletter ^ cipherletter); //faccio l'exor tra messaggio e codice di cifratura

                coded.Append(String.Format(@"\u{0:x4}", xor)); //aggiungo alla stringa codificata l'exor in formato unicode
            }
            
            return coded.ToString(); 
        }

        static void Main(string[] args)
        {

            Console.Write("Inserisci una stringa da codificare: ");
            string message = Console.ReadLine();

            Console.Write("Inserisci un codice di cifratura: ");
            string cipher = Console.ReadLine();

            string coded = Encode(message, cipher);
            Console.Write("La stringa codificata è:\n{0}\n", coded);

        }
    }
}
