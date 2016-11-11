using System;
using System.Text;


namespace es_02
{
    public class Program
    {
        public static string Sum(string num1, string num2)
        {

            string numInverted1 = InvertString(num1); //inverto i due numeri
            string numInverted2 = InvertString(num2);

            int maxLenght = numInverted1.Length; //lunghezza massima tra le due stringhe
            if (numInverted2.Length > maxLenght)
            {
                maxLenght = numInverted2.Length;
            }

            StringBuilder sum = new StringBuilder();

            int remainder = 0; //valore del resto nel caso la somma di due cifre sia > 9
            for (int i = 0; i < maxLenght; i++)
            {
                int sumDigits = remainder;
                if (i < numInverted1.Length)
                {
                    int digitFirstNumber = int.Parse(numInverted1[i].ToString()); //cifra corrente del primo operando
                    sumDigits += digitFirstNumber;
                }
                if (i < numInverted2.Length)
                {
                    int digitSecondNumber = int.Parse(numInverted2[i].ToString()); //cifra corrente del secondo operando
                    sumDigits += digitSecondNumber;
                }

                remainder = sumDigits / 10; 
                if (remainder > 0)
                {
                    sum.Append(sumDigits % 10);
                }
                else
                {
                    sum.Append(sumDigits);
                }
            }

            if (remainder > 0)
            {
                sum.Append(remainder);
            }

            return InvertString(sum.ToString()); //inverto la stringa e restituisco il risultato
        }

        private static string InvertString(string number) //funzione per invertire il numero all'interno della stringa
        {
            StringBuilder InvertedString = new StringBuilder(); //creo una stringa vuota che andrò a riempire al contrario
            for (int k = number.Length - 1; k >= 0; k--)
            {
                InvertedString.Append(number[k]); //aggiungo una cifra alla volta
            }

            return InvertedString.ToString();
        }
    }
}
