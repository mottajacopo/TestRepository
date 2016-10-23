using System;

namespace es_03
{
    public class Program
    {
        public static int roots(float a, float b, float c, ref double root1, ref double root2)
        {
            float discriminant = b*b  - 4 * a * c;

            if (discriminant < 0)
            {
                return 0;
            }
            if (discriminant == 0)
            {
                root1 = -b / (2 * a);
                return 1;
            }
            if (discriminant > 0)
            {
                root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return 2;
            }
            return 0;
        }

        public static float isFloat(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            float num = 0;
            while (!float.TryParse(input, out num))
            {
                Console.Write("Errore! Inserisci di nuovo un numero: ");
                input = Console.ReadLine();
            }
            return num;
        }
    
        static void Main(string[] args)
        {
            double root1 = 0;
            double root2 = 0;
            float a;
            float b;
            float c;
            int result ;
            string input;

            Console.WriteLine("Inserisci i coefficienti dell ' equazione ax^2 + bx + c :");

            Console.Write("Inserisci a : ");
            input = Console.ReadLine();
            a = isFloat(ref input);          //controllo se l 'input inserito è un numero

            Console.Write("Inserisci b: ");
            input = Console.ReadLine();
            b = isFloat(ref input);

            Console.Write("Inserisci c: ");
            input = Console.ReadLine();
            c = isFloat(ref input);

            result = roots(a, b, c, ref root1, ref root2);

            switch (result)
            {
                case 0:
                    Console.WriteLine("L' equazione non ha radici reali.");
                    break;
                case 1:
                    Console.WriteLine("La radice dell' equazione è: {0}", root1);
                    break;
                case 2:
                    Console.WriteLine("Le radici dell' equazione sono {0} e {1}.", root1 , root2);
                    break;
                default:

                    break;
            }
        }
    }
}
