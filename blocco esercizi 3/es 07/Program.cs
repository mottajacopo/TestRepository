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
                Exception e = new Exception("Errore . Si è verificata un eccezione di tipo WeException ." +
                                            "\n L'URI formato dalla combinazione BaseAddress e address non è valido." +
                                            "\n  - oppure - " +
                                            "\n filename è null o Empty." +
                                            "\n - oppure -" +
                                            "\n  Il file specificato non esiste." +
                                            "\n - oppure - si è verificato un errore durante il download dei dati.");
                throw e;

            }
            catch (NotSupportedException)
            {
                Exception e = new Exception("Errore . Si è verificata un eccezione di tipo NotSupportedException ." +
                                           "\n	Il metodo è stato chiamato simultaneamente su più thread.");
                throw e;
                
            }
            catch (Exception)
            {
                Exception e = new Exception("Errore . Si è verificata un eccezione di tipo Exception ." +
                                            "\n	Controllare che il valore del parametro url non sia null.");
                throw e;
               
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