using System;

namespace es_06
{
    public class Program
    {
        public static void isAcceptable(ref string input) 
        {
            int i = 0;
            bool testDigit = false;

            while (testDigit == false)
            {
                testDigit = true;

                for (i = 0; i < input.Length; i++)
                {
                    if (!Char.IsDigit(input[i]) || (input[i] == '-'))         //se il char non è un numero lo reinserisco
                    {
                        if (input[i] != 'a' && input[i] != 'b' && input[i] != 'c' && input[i] != 'd' && input[i] != 'e' && input[i] != 'f')             //accetto solo i caratteri "a", "b", "c", "d", "e", "f" minuscoli per semplicità
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
            } //conversione da decimale a binario

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
        }  //conversione da binario a decimale

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
        }  //conversione da esadecimale a decimale

        public static string fromDecToHex(string numString)
        { 
            string DecToHex = "";
            for (int i = 0; i < numString.Length; i++) //se il numero inserito è esadecimale questa conversione non è possibile
            {
                if ((numString[i] == 'a') || (numString[i] == 'b') || (numString[i] == 'c') || (numString[i] == 'd') || (numString[i] == 'e') || (numString[i] == 'f'))
                {
                    DecToHex = "Impossibile! Il numero inserito non è decimale.";
                    return DecToHex;
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
                rest = numInt % 16;
                numInt = numInt / 16;

                switch (rest)
                {
                    case 0:
                        DecToHex = "0" + DecToHex;
                        break;
                    case 1:
                        DecToHex = "1" + DecToHex;
                        break;
                    case 2:
                        DecToHex = "2" + DecToHex;
                        break;
                    case 3:
                        DecToHex = "3" + DecToHex;
                        break;
                    case 4:
                        DecToHex = "4" + DecToHex;
                        break;
                    case 5:
                        DecToHex = "5" + DecToHex;
                        break;
                    case 6:
                        DecToHex = "6" + DecToHex;
                        break;
                    case 7:
                        DecToHex = "7" + DecToHex;
                        break;
                    case 8:
                        DecToHex = "8" + DecToHex;
                        break;
                    case 9:
                        DecToHex = "9" + DecToHex;
                        break;
                    case 10:
                        DecToHex = "A" + DecToHex;
                        break;
                    case 11:
                        DecToHex = "B" + DecToHex;
                        break;
                    case 12:
                        DecToHex = "C" + DecToHex;
                        break;
                    case 13:
                        DecToHex = "D" + DecToHex;
                        break;
                    case 14:
                        DecToHex = "E" + DecToHex;
                        break;
                    case 15:
                        DecToHex = "F" + DecToHex;
                        break;
                }
            }
            return DecToHex;
        } //conversione da decimale a esadecimale

        static void Main(string[] args)
        {
            string numString;

            Console.WriteLine("Inserisci un numero intero per ottenere le possibili conversioni:");
            numString = Console.ReadLine();
            isAcceptable(ref numString); //controllo che sia un numero binario, decimale o al massimo esadecimale
     
            Console.WriteLine("Da decimale a binario: {0}", fromDecToBin(numString));
            Console.WriteLine("Da binario a decimale: {0}", fromBinToDec(numString));
            Console.WriteLine("Da esadecimale a decimale: {0}", fromHexToDec(numString));
            Console.WriteLine("Da decimale a esadecimale: {0}", fromDecToHex(numString));
        }
    }
}
