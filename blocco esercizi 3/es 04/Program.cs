using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace es_04
{
    public class Program
    {
        static public DateTime[] holidays = new DateTime[] {
            new DateTime(DateTime.Now.Year, 1, 1),
            new DateTime(DateTime.Now.Year, 1, 6),
            new DateTime(DateTime.Now.Year, 4, 25),
            new DateTime(DateTime.Now.Year, 5, 1),
            new DateTime(DateTime.Now.Year, 6, 1),
            new DateTime(DateTime.Now.Year, 8, 15),
            new DateTime(DateTime.Now.Year, 11, 1),
            new DateTime(DateTime.Now.Year, 12, 8),
            new DateTime(DateTime.Now.Year, 12, 25),
            new DateTime(DateTime.Now.Year, 12, 26)
        };

        static public DateTime[] workingSaturdays = new DateTime[] {
            new DateTime(DateTime.Now.Year, 4, 23),
            new DateTime(DateTime.Now.Year, 5, 21)
        };

        static public int Compute(DateTime start, DateTime end)
        {
            
            int days = (int)(end - start).TotalDays + 1;
            int weeks = days / 7;

            // check for a weekend in a partial week from start.
            if (7 - (days % 7) <= (int)start.DayOfWeek)
                days = days - 2;
            
            //controlla le vacanze
            for (int i = start.Year; i <= end.Year; i++)
            {
                int year = i;

                foreach (DateTime dt in holidays)
                {
                    DateTime dtUpt = new DateTime(year, dt.Month, dt.Day);
                    if ((dtUpt >= start) && (dtUpt <= end) && (dtUpt.DayOfWeek != DayOfWeek.Saturday) && (dtUpt.DayOfWeek != DayOfWeek.Sunday))
                        days--;
                }
            }

            //tolgo i week-ends
            days -= weeks * 2;

            //aggiungo i sabati lavorativi
            for (int i = start.Year; i <= end.Year; i++)
            {
                int year = i;

                foreach (DateTime dt in workingSaturdays)
                {
                    DateTime dtUpt = new DateTime(year, dt.Month, dt.Day);
                    if ((dtUpt >= start) && (dtUpt <= end) && (dtUpt.DayOfWeek == DayOfWeek.Saturday))
                        days++;
                }
            }
            return days;
        }

        public static int IsInteger(ref string input)   //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int num = 0;
            while (!Int32.TryParse(input, out num))
            {
                Console.Write("Errore! Inserisci di nuovo un numero: ");
                input = Console.ReadLine();
            }
            return num;
        }
        
        public static void Main(string[] args)
        {
            DateTime start = DateTime.Today; //ottiene il giorno corrente
            Console.WriteLine("Inserisci una data per conoscere il numero di giorni lavorativi mancanti da oggi:");

            Console.Write("Giorno:");
            string input = Console.ReadLine();
            int day = IsInteger(ref input);

            Console.Write("Mese:");
            input = Console.ReadLine();
            int month = IsInteger(ref input);

            Console.Write("Anno:");
            input = Console.ReadLine();
            int year = IsInteger(ref input);
    
            DateTime end = new DateTime(year, month, day);
            Console.WriteLine("Mancano {0} giorni lavorativi.", Compute(start, end));
        }
    }
}
