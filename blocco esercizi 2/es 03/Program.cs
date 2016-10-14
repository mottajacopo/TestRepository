using System;


namespace es_03
{
    
    public class Program
    {
        public static int roots(float a, float b ,float c ,ref double root1, ref double root2)
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

        public static void isfloateger(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int i = 0;
            bool isDigit = false;

            while (isDigit == false)
                for (; i < input.Length; i++)
                {
                    if (!Char.IsDigit(input[i]))         //se il char non è un numero ritorna falso
                    {
                        if (input[i] != ',' && input[i] != '-')             //permette l 'inserimento di numeri con la virgola
                        {
                            Console.WriteLine("errore inserisci di nuovo numero : ");
                            input = Console.ReadLine();
                            isDigit = false;
                            i = 0;
                        }
                    }
                    isDigit = true;
                }
            return;
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

            Console.WriteLine("inserisci i coefficienti dell ' equazione ax^2 + bx + c ");

            Console.WriteLine("inserisci a :");
            input = Console.ReadLine();
            isfloateger(ref input);          //controllo se l 'input inserito è un numero
            a = float.Parse(input);

            Console.WriteLine("inserisci b :");
            input = Console.ReadLine();
            isfloateger(ref input);
            b = float.Parse(input);

            Console.WriteLine("inserisci c :");
            input = Console.ReadLine();
            isfloateger(ref input);
            c = float.Parse(input);

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
