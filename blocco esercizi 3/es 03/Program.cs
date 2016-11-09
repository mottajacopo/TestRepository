using System;
using System.IO;
using System.Collections.Generic;

namespace es_03
{
    class Program
    {
        public static List<string> DirSearch(string sDir)
        {
            List<string> array = new List<string>();

            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    array.Add(d);
                    foreach (string f in Directory.GetFiles(d))
                    {
                        array.Add(f);
                    }
                    array.AddRange( DirSearch(d));
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
            return array;
        }
        static void Main(string[] args)
        {
            string sDir = "C:\\Users\\jacopo\\Desktop";
            List<string> array = new List<string>();
            array = DirSearch(sDir);
            foreach (string w in array)
            {
                Console.WriteLine(w);
            }
        }
    }
}
