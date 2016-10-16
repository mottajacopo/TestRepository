using System;


namespace es_02
{
    public class Program
    {
        public static decimal fibonacci(decimal num1, decimal num2)
        {
            decimal a = num1;
            decimal b = num2;

            return (a + b);
        }

        static void Main(string[] args)
        {
            decimal num1 = 0;
            decimal num2 = 1;
            decimal temp;

            Console.WriteLine("Ecco i primi 100 numeri della sequenza di Fibonacci:");
            Console.WriteLine("{0}\n{1}", num1, num2);

            for(int i=0; i < 98; i++)
            {
                temp = fibonacci(num1, num2);
                Console.WriteLine("{0}", temp);
                num1 = num2;
                num2 = temp;
            }
    
        }
    }
}
