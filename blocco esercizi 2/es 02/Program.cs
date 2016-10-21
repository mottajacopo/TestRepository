using System;


namespace es_02
{
    public class Program
    {
        public static decimal[] fibonacci()
        {
            decimal[] array = new decimal[100];
            decimal num1 = 0;
            decimal num2 = 1;
            decimal temp;
            Console.WriteLine("{0}\n{1}", num1, num2);
            array[0] = 0;
            array[1] = 1;

            for (int i = 0; i < 98; i++)
            {
                temp = num1 + num2;
                array[i + 2] = temp;
                Console.WriteLine("{0}", temp);
                num1 = num2;
                num2 = temp;
            }
            return array;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ecco i primi 100 numeri della sequenza di Fibonacci:");
            decimal []result = fibonacci();
        }
    }
}
