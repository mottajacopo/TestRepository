using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_05;

namespace UnitTestBlocco4
{
    [TestClass]

    public class TestGraph 
    {
        [TestMethod]

        public void FindSubGraph()
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

            bool[] visited = new bool[Graph.MaxNode];
            int counter = 0;
            int line;
            int[,] subGraph = new int[g.NumberOfNode, g.NumberOfNode];

            for (int i = 0; i < g.NumberOfNode; i++)
            {
                if (visited[i] == false)
                {
                    line = 0;
                    g.TraverseDFSRecursive(i, visited, ref line, ref subGraph, ref counter);
                    counter++;
                }
            }
            Assert.AreEqual(3, counter);

            Assert.AreEqual(subGraph[0,0], 0);
            Assert.AreEqual(subGraph[0,1], 1);
            Assert.AreEqual(subGraph[0,2], 2);
            Assert.AreEqual(subGraph[0,3], 3);

            Assert.AreEqual(subGraph[1,0], 4);
            Assert.AreEqual(subGraph[1,1], 5);

            Assert.AreEqual(subGraph[2,0], 6);
            Assert.AreEqual(subGraph[2,1], 8);
            Assert.AreEqual(subGraph[2,2], 7);
            
        }
    }
}