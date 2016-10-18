using System;

namespace es_06
{
    public class Program
    {
        public static void isInteger(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int i = 0;
            bool testDigit = false;

            while (testDigit == false)
            {
                testDigit = true;

                for (; i < input.Length; i++)
                {
                    if (!Char.IsDigit(input[i]) || (input[i] == '-'))         //se il char non è un numero lo reinserisco
                    {
                        if (input[i] != 'a' && input[i] != 'b' && input[i] != 'c' && input[i] != 'd' && input[i] != 'e' && input[i] != 'f')             //accetto solo i caratteri "a", "b", "c", "d", "e", "f".
                        {
                            Console.WriteLine("Errore! Inserisci di nuovo un numero:");
                            input = Console.ReadLine();
                            testDigit = false;
                            i = 0;
                        }
                    }
                }
            }
            return;
        }
        public static string fromDecToBin (string numString) {

            string DecToBin = "";
            for (int i = 0; i < numString.Length; i++) //se il numero inserito è esadecimale questa conversione non è possibile
            {
                if ((numString[i] == 'a') || (numString[i] == 'b') || (numString[i] == 'c') || (numString[i] == 'd') || (numString[i] == 'e') || (numString[i] == 'f'))
                {
                    DecToBin = "Impossibile! Il numero inserito non è decimale.";
                    return DecToBin;
                }
            }
            int numInt = int.Parse(numString);
            int rest = 0;

            if (numInt == 0) //caso particolare: il numero è 0
            {
                return "0";
            }
            while (numInt >= 1)
            {
                rest = numInt % 2;
                numInt = numInt / 2;

                if (rest == 0)
                {
                    DecToBin = "0" + DecToBin;
                }
                else
                {
                    DecToBin = "1" + DecToBin;
                }   
            }
            return DecToBin;
            }
        public static string fromBinToDec (string numString)
        {
            double BinToDec = 0; //contiene il numero trasformato in decimale, verrà convertita in stringa alla fine
            for (int i = 0; i < numString.Length; i++)
            {
                if ((numString[i] != '0') && (numString[i] != '1'))
                {
                    numString = "Impossibile! Il numero inserito non è binario.";
                    return numString;
                }
            }
         
            for (int k = 0; k < numString.Length; k++)
            {
                if (numString[k] == '1')
                {
                    BinToDec += (Math.Pow(2, numString.Length - k - 1));
                }
            }
            numString = Convert.ToString(BinToDec);
            return numString;
        }
        public static string fromHexToDec(string numString)
        {
            double HexToDec = 0; //contiene il numero trasformato in decimale, verrà convertita in stringa alla fine

            for (int k = 0; k < numString.Length; k++)
            { 
                switch (numString[k])
                {
                    case '0':
                        break;
                    case '1':
                        HexToDec += 1 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    case '2':
                        HexToDec += 2 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    case '3':
                        HexToDec += 3 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    case '4':
                        HexToDec += 4 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    case '5':
                        HexToDec += 5 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    case '6':
                        HexToDec += 6 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    case '7':
                        HexToDec += 7 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    case '8':
                        HexToDec += 8 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    case '9':
                        HexToDec += 9 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    case 'a':
                        HexToDec += 10 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    case 'b':
                        HexToDec += 11 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    case 'c':
                        HexToDec += 12 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    case 'd':
                        HexToDec += 13 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    case 'e':
                        HexToDec += 14 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    case 'f':
                        HexToDec += 15 * (Math.Pow(16, numString.Length - k - 1));
                        break;
                    default:
                        HexToDec += numString[k] * (Math.Pow(16, numString.Length - k - 1));
                        break;
                }  
            }
            numString = Convert.ToString(HexToDec);
            return numString;
        }
        static void Main(string[] args)
        {
            string numString;

            Console.WriteLine("Inserisci un numero intero per ottenere le possibili conversioni:");
            numString = Console.ReadLine();
            isInteger(ref numString); //controllo che sia un numero binario, decimale o al massimo esadecimale
     
            Console.WriteLine("Da decimale a binario: {0}", fromDecToBin(numString));
            Console.WriteLine("Da binario a decimale: {0}", fromBinToDec(numString));
            Console.WriteLine("Da esadecimale a decimale: {0}", fromHexToDec(numString));
        }
    }
}
