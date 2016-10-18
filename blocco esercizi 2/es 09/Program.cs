using System;


namespace es_09
{
    public class Program
    {

        public static void isInteger(ref string input)         //controllo per verificare che vengano inseriti numeri e non lettere o altro
        {
            int i = 0;
            bool testDigit = false;

            while (testDigit == false)
            {
                testDigit = true;

                for (; i < input.Length; i++)
                {
                    if (!Char.IsDigit(input[i]) )         
                    {
                        
                            Console.WriteLine("Errore! Inserisci di nuovo un numero : ");
                            input = Console.ReadLine();
                            testDigit = false;
                            i = -1;
                        
                    }
                }
            }
            return;
        }
        public static void maxSequence(int[] array , int n , ref int [] seq)
        {
            int[] len = new int[n];       //array che servirà per l algoritmo
            int x;
            int prev;
            int max= 0;                   //lunghezza sottosequenza più lunga
            
            int i;                        //variabile contatore
           

            for (i = 0; i < n; i++)            //inizializzo con tutti 1
            {
                len[i] = 1;
            }

            //cerco la posizione dell ' ultimo elemento della sequenza   https://www.youtube.com/watch?v=CE2b_-XfVDk

            //confronto ciascun elemento (partendo dal secondo) con quelli precedenti 
            //se l elemento di posizione x nell array[] iniziale è maggiore di quello di posizione prev (precedente)
            //e l elemento corrispondente (stessa posizione) dell array len[] è più piccolo di len[prev] + 1
            //allora aumento di 1 l elemento di posizione x su len[]

            for (x = 1; x < n; x++)           
            {
                for (prev = 0; prev < x; prev++)
                {
                    if (array[x] > array[prev] && len[x] < len[prev] + 1)   
                    {
                        len[x] = len[prev] + 1;
                    }
                }
            }
             
            for (i = 0; i < n; i++)           //cerco la posizione dell elemento più grande dell array len[] 
                if (max < len[i])
                {
                    max = len[i];
                    x = i;        //dentro x metto la posizione dell ultimo elemento della sequenza
                }

            Console.WriteLine("la lunghezza della sequenza massima è : {0}", max);
          
            //ora ricostruisco la sequenza

            int top = len[x] - 1;          //top è il valore massimo dentro l array len[] diminumito di 1
                                           //la posizione in cui si trova l elemento top dentro len[] è la stessa in cui
                                           //si trova il penultimo elemento della sottosequenza cercata  

            seq[top] = array[x];           //visto che conosco gia la posizione dell ultimo elemento lo metto gia nell array seq[] per stamparlo in seguito

            //                    .     .        .  .    
            //es array[] = {6, 9, 2, 7, 4, 7, 6, 5, 8, 4}
            //     len[] = {1, 1, 1, 2, 2, 3, 3, 3, 4, 2}

            //parto dall elemento precedente all ultimo(8) della sequenza gia trovato (5 nell es)
            //se l elemento ,rispetto a array[], è minore del prec (5<8 vero)
            // e se ,rispetto a len[] , è == len[x]-1  (3 == 3 vero ) 
            //allora quello è un elemento della sequenza  
            //ripeto per tutto l array

            for (prev = x -1; prev >= 0; prev--)
            {
                if(array[prev] < array[x] && len[prev] == len[x]-1)
                {
                    x = prev;
                    seq[top -1] = array[x];
                    top--;
                }
            }

            //stampo la sequenza
            Console.WriteLine("la massima sequenza è :");
            for(i = 0; i < max; i++)
            {
                Console.WriteLine("{0}", seq[i]);
            }

           

        }

        static void Main(string[] args)
        {
            int n;
            string input;
           

            Console.WriteLine("inserisci la lunghezza dell' array :");
            input = (Console.ReadLine());
            isInteger(ref input);
            n = int.Parse(input);
            
            Console.WriteLine("inserisci gli elementi dell' array :");
            int[] array = new int[n];
            int[] seq = new int[n];       //array che conterrà la sequenza

            

            for (int i = 0; i < n; i++)
            {
                    input = (Console.ReadLine());
                    isInteger(ref input);
                    array[i] = int.Parse(input);
            }

            maxSequence(array , n , ref seq);

            
        }
    }
}

