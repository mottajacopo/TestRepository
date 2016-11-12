using System;
using System.Collections.Generic;
using System.Text;

namespace es_10
{
    public class Program
    {
        public static object[,] AlphabeticalOrder(string input)
        {
            SortedDictionary<string, int> words = GetWord(input);
            object[,] result = new object[2, words.Count]; 
            int i = 0;
            foreach (var item in words)
            {
                result[0, i] = item.Key; //nella prima riga ho le parole
                result[1, i] = item.Value; //nella seconda il numero di volte che si presentano
                i++;
            }
            return result;
        }

        public static SortedDictionary<string, int> GetWord(string text)
        {
            SortedDictionary<string, int> words = new SortedDictionary<string, int>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c == ' ' || c == '.' || c == ',' || c == '!' || c == '?' || c == '-')
                {
                    SaveWord(sb, words); //aggiungo la parola o ne incremeneto il contatore se era già presente
                }
                else
                {
                    sb.Append(c); //aggiungo il carattere alla parola corrrente
                }
            }
            SaveWord(sb, words); //nel caso ci sia un'unica parola nel testo
            return words;
        }

        public static void SaveWord(StringBuilder sb, SortedDictionary<string, int> dict)
        {
            if (sb.Length == 0)
            {
                return; 
            }
            string word = sb.ToString().ToLower(); //salvo le parole tutte minuscole

            sb.Clear(); //cancello la parola per far spazio a quella successiva

            if (dict.ContainsKey(word)) //se ho già incontrato quella parola
            {
                dict[word]++; //ne incremento il contatore
            }
            else
            {
                dict.Add(word, 1); //altrimenti la aggiungo 
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un testo per ottenere l'ordine alfabetico e il numero\ndi volte in cui si presenta ciascuna parola:");
            string input = Console.ReadLine();
            Console.WriteLine("");
            SortedDictionary<string, int> words = GetWord(input);
            object[,] result = AlphabeticalOrder(input);

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine("{0} = {1}", result[0, i], result[1, i]);
            }
        }
    }
}
