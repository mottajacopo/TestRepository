using System;

namespace es_05
{
    public class Program
    {
        public static Random rand = new Random();

        public static string[] Phrase1 = new string[]
        {"The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category." };

        public static string[] Phrase2 = new string[]
        {"Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied." };

        public static string[] Phrase3 = new string[]
        {"Dayan", "Stella", "Hellen", "Kate"};

        public static string[] Phrase4 = new string[]
        {"Johnson", "Peterson", "Charles"};

        public static string[] Phrase5 = new string[]
        {"London", "Paris", "Berlin", "New York", "Madrid"};

        public static string[] PhraseFinal = new string[5];
        public static string  RandomAdvertisement ()
        {
            
            int i = rand.Next(0, 3); 
            int j = rand.Next(0, 4); 
            int h = rand.Next(0, 3); 
            int k = rand.Next(0, 2); 
            int l = rand.Next(0, 4);

            PhraseFinal[0] = Phrase1[i];
            PhraseFinal[1] = Phrase1[j];
            PhraseFinal[2] = Phrase1[h];
            PhraseFinal[3] = Phrase1[k];
            PhraseFinal[4] = Phrase1[l];

            string result = PhraseFinal[0] + PhraseFinal[1] + PhraseFinal[2] + PhraseFinal[3] + PhraseFinal[4] ;
            return result;
        }
        public static void Main(string[] args)
        {
            
            Console.WriteLine("{0}" , RandomAdvertisement());
        }
    }
}
