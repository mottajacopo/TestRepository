using System;

namespace es_05
{
    public class Program
    {
        public static Random rand = new Random();
        public static string  RandomAdvertisement ()
        {
            string[] Phrase1 = new string[]
            {"The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category." };

            string[] Phrase2 = new string[]
            {"Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied." };

            string[] Phrase3 = new string[]
            {"Dayan", "Stella", "Hellen", "Kate"};

            string[] Phrase4 = new string[]
            {"Johnson", "Peterson", "Charles"};

            string[] Phrase5 = new string[]
            {"London", "Paris", "Berlin", "New York", "Madrid"};

            string PhraseFinal;
            int i = rand.Next(0, 3); 
            int j = rand.Next(0, 4); 
            int h = rand.Next(0, 3); 
            int k = rand.Next(0, 2); 
            int l = rand.Next(0, 4); 

            PhraseFinal = Phrase1[i] + Phrase2[j] + "\n"+ "--" + Phrase3[h] + " " + Phrase4[k]+ "," + Phrase5[l];

            return PhraseFinal;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("{0}" , RandomAdvertisement());
        }
    }
}
