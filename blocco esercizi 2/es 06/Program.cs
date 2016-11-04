using System;

namespace es_06
{
    public class Program
    {
        public static string DecToHex(string n)
        {
            int numero = int.Parse(n);
            return String.Format("0x{0:x}", numero);
        }
        public static string HexToDec(string n)
        {
            int numero = Convert.ToInt32(n, 16);
            return Convert.ToString(numero);
        }
        public static string DecToBin(string n)
        {
            int numero = int.Parse(n);
            return Convert.ToString(numero, 2);
        }
        public static string BinToDec(string n)
        {
            int numero = Convert.ToInt32(n, 2);
            return Convert.ToString(numero);
        }
        
        static void Main(string[] args)
        {
        }
    }
}
