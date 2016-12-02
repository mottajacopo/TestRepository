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

                webClient = new WebClient();
                webClient.DownloadFile(url, filename);
                Console.WriteLine("download eseguito con successo .");
          
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("inserisci l indirizzo url del file da scaricare :");
            string url = Console.ReadLine();
            Console.WriteLine("rimominare il file :");
            string fileName = Console.ReadLine();

            try
            {
                Download(url, fileName);
            }

            catch (WebException)
            {
                Console.WriteLine("Errore . Si è verificata un eccezione di tipo WeException ." +
                                            "\n L'URI formato dalla combinazione BaseAddress e address non è valido." +
                                            "\n  - oppure - " +
                                            "\n filename è Empty." +
                                            "\n - oppure -" +
                                            "\n  Il file specificato non esiste." +
                                            "\n - oppure - si è verificato un errore durante il download dei dati.");

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Errore . Si è verificata un eccezione di tipo ArgumentNullException ." +
                                           "\n	Controllare che il valore del parametro url o fileName non siano null.");
                

            }
            catch (Exception)
            {
               Console.WriteLine("Errore . Si è verificata un eccezione di tipo Exception ." );
               
            }
           
        }

    }


}