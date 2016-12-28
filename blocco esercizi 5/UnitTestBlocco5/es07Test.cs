using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_07;

namespace UnitTestBlocco5
{
    [TestClass]
    public class es07Test
    {
        [TestMethod]
        public void TestEs07AnonymousDelegate()
        {
            Point[] points = new Point[] { new Point(2, 3), new Point(-6, 6), new Point(7, -4), new Point(2, 6) };

            Point test = Array.Find(points, delegate (Point xy)    // Find the first Point structure for which the sum is smaller than 0.0001
            {
                double sum = xy.X + xy.Y;
                if (sum < 0)
                {
                    return sum >= 0.0001;
                }
                else { return sum <= 0.0001; }
            });
            Assert.AreEqual(-6, test.X, 0.00001);
            Assert.AreEqual(6, test.Y, 0.00001);
        }

        private static bool SumNearToZero(Point xy)    // Return true if the sum is smaller than 0.0001
        {
            double sum = xy.X + xy.Y;
            if (sum < 0)
            {
                return sum >= 0.0001;
            }
            else { return sum <= 0.0001; }
        }
        [TestMethod]
        public void TestEs07NamedStaticMethod()
        {
            Point[] points = new Point[] { new Point(2, 3), new Point(-6, 6), new Point(7, -4), new Point(2, 6) };

            Point test = Array.Find(points, SumNearToZero);    // Find the first Point structure for which the sum is smaller than 0.0001
            Assert.AreEqual(-6, test.X, 0.00001);
            Assert.AreEqual(6, test.Y, 0.00001);
        }

        private static int Comparison (Point xy1, Point xy2)
        {
            double sum1 = Math.Abs(xy1.X + xy1.Y);
            double sum2 = Math.Abs(xy2.X + xy2.Y);

            if (sum1 < sum2)
            {
                return -1;
            }
            else if (sum1 == sum2)
            {
                return 0;
            }
            else
            {
                return 1;
            } 
        }
    [TestMethod]
        public void TestEs07Sort()
        {
            Point[] points = new Point[] { new Point(2, 3), new Point(-6, 6), new Point(7, -4), new Point(2, 6) };

            Array.Sort(points, Comparison);
           
            Assert.AreEqual(-6, points[0].X, 0.00001);
            Assert.AreEqual(6, points[0].Y, 0.00001);
        }
    }
}


