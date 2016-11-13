using System;
using System.Text;
using System.Net;
using System.IO;

namespace es_07
{
    public static class Program
    {
        public static void Download(string url, string filename)
        {
            WebClient webClient = new WebClient();

            try
            {
                webClient = new WebClient();
                webClient.DownloadFile(url, filename);
                Console.WriteLine("download eseguito con successo .");
            }
            catch (WebException)
            {
                Console.WriteLine("Errore . Si è verificata un eccezione di tipo WeException .");
                Console.WriteLine("L'URI formato dalla combinazione BaseAddress e address non è valido.");
                Console.WriteLine(" - oppure -");
                Console.WriteLine(" filename è null o Empty.");
                Console.WriteLine(" - oppure -");
                Console.WriteLine("  Il file specificato non esiste.");
                Console.WriteLine(" - oppure - si è verificato un errore durante il download dei dati.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Errore . Si è verificata un eccezione di tipo NotSupportedException .");
                Console.WriteLine("Il metodo è stato chiamato simultaneamente su più thread.");
            }
            catch (Exception)
            {
                Console.WriteLine("Errore . Si è verificata un eccezione di tipo Exception .");
                Console.WriteLine("	Controllare che il valore del parametro url non sia null.");
            }
            finally
            {
                webClient.Dispose();
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("inserisci l indirizzo url del file da scaricare :");
            string url = Console.ReadLine();
            Console.WriteLine("rimominare il file :");
            string fileName = Console.ReadLine();

            Download(url, fileName);
            
        }

    }


}