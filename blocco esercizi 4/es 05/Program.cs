using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(new int[][] {
            new int[] {1,2},
            new int[] {0},
            new int[] {3},
            new int[] {1},
            new int[] {5},
            new int[] {3},
            new int[] {6,7},
            new int[] {8},
            new int[] {6}});

            Console.Write("Depth-First Search (DFS) traversal (recursive): ");
            bool[] visited = new bool[Graph.MaxNode];
            int counter = 0;
           

            Console.WriteLine();
            for (int i = 0; i < g.NumberOfNode; i++)
            {
                if (visited[i] == false)
                {
                    g.TraverseDFSRecursive(i, visited );
                    counter++;
                    Console.WriteLine("sottografo {0}", counter);
                   
                }
            }
            
        }

    }
}
