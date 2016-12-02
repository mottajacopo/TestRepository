using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_05
{
    public class Graph
    {
        public const int MaxNode = 1024;
        private int[][] childNodes;
        public Graph(int[][] childNodes)
        {
            this.childNodes = childNodes;
        }
        public int NumberOfNode
        {
            get
            {
                return childNodes.Length;
            }
        }
        public void TraverseDFSRecursive(int node, bool[] visited ,ref int line , ref int[,] subGraph , ref int counter)
        {
            if (!visited[node])
            {
                visited[node] = true;
                //Console.Write("{0} ",node);
                subGraph[counter, line] = node;
                line++;
                foreach (int childNode in childNodes[node])
                {
                    TraverseDFSRecursive(childNode, visited , ref line , ref subGraph , ref counter);
                }
            }
        }
    }
}
