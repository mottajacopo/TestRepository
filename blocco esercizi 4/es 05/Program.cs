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
            new int[] {6,8},
            new int[] {8},
            new int[] {7}});

            Console.Write("Depth-First Search (DFS) traversal (recursive): ");
            bool[] visited = new bool[Graph.MaxNode];
            int counter = 0;
            int line ;
            int[,] subGraph = new int[g.NumberOfNode,g.NumberOfNode];
           
            Console.WriteLine();
            for (int i = 0; i < g.NumberOfNode; i++)
            {
                if (visited[i] == false)
                {
                    line = 0;
                    g.TraverseDFSRecursive(i, visited , ref line , ref subGraph , ref counter);
                    counter++;

                   for(int c = 0; c<line; c++)
                    {
                        Console.Write(subGraph[counter - 1, c]);
                    }
                    Console.WriteLine(" sottografo {0}", counter);
                }
            }
        }
    }
}
