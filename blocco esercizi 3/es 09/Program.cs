using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;


namespace es_09
{
    public class Program
    {
        public static string ExtractEmails(string file)
        {
  
            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);

            MatchCollection emailMatches = emailRegex.Matches(file);

            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);
            }
            string mail = sb.ToString();

            return mail;   
        }

        static void Main(string[] args)
        {
            string file = System.IO.File.ReadAllText(@"C:\Workstation\TestRemoteRepo\blocco esercizi 3\es 09\FileTest.txt");
            string mail = ExtractEmails(file);
            Console.WriteLine("{0}", mail);
        }
    }
}
