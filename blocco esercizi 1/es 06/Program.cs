using System;


namespace es_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero per sapere se e' pari o dispari");
            int numero = int.Parse(Console.ReadLine());
            int resto = numero % 2;
            if (resto == 0)
            {
                Console.WriteLine("{0} e' pari" , numero);
            }
            else
            {
                Console.WriteLine ("{0} e' dispari" , numero);
            }
            
        }
    }
}
