using System;


namespace es_03
{
    
    public class Program
    {
        public static int roots(int a, int b ,int c ,ref double root1, ref double root2)
        {
            int discriminant = b*b  - 4 * a * c;

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
                root1 = -b + Math.Sqrt(discriminant);
                root2 = -b - Math.Sqrt(discriminant);
                return 2;
            }
            return 0;
        }

        public static bool isfloateger(string stringa)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int i = 0;

            for (; i < stringa.Length; i++)
            {
                if (!Char.IsDigit(stringa[i]))         //se il char non è un numero ritorna falso
                {
                    if (stringa[i] != ',')             //permette l 'inserimento di numeri con la virgola
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            double root1 = 0;
            double root2 = 0;
            int a;
            int b;
            int c;
            int result ;

            Console.WriteLine("inserisci i coefficienti dell ' equazione ax^2 + bx + c ");
            Console.WriteLine("inserisci a :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci b :");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci c :");
            c = int.Parse(Console.ReadLine());

            result = roots(a, b, c, ref root1, ref root2);

            switch (result)
            {
                case 0:
                    Console.WriteLine("l' equazione non ha radici reali");
                    break;
                case 1:
                    Console.WriteLine("la radice dell ' equazione è {0}", root1);
                    break;
                case 2:
                    Console.WriteLine("le radici dell ' equazione sono {0} e {1}", root1 , root2);
                    break;
                default:

                    break;
            }
           
        }
    }
}
