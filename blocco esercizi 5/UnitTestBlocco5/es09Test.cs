using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_09;
using System.Collections.Generic;
using System.Linq;


namespace UnitTestBlocco5
{
    [TestClass]
    public class Test09
    {
            static List<LibraryItem> items = new List<LibraryItem>();
            static List<LibraryPatron> patrons = new List<LibraryPatron>();

        [ClassInitialize]
        public static void InitializeClass(TestContext context)
        {
            LibraryItem b1 = new LibraryBook("Multithreading with C# Cookbook - Second Edition",
                "Packt Publishing", 2016, 14, "ZZ25 3G", "Eugene Agafonov");
            LibraryItem b2 = new LibraryBook("Agile Software Development: Principles, Patterns, and Practices",
                "Prentice Hall", 2002, 14, "ZZ27 3G", "Robert Cecil Martin ");
            LibraryItem m1 = new LibraryMovie("The Lord of the Rings: The Fellowship of the Ring",
                "New Line Cinema", 2002, 7, "MM33 2D", 178, "Peter Jackson", LibraryMediaItem.MediaType.BLURAY,
                LibraryMovie.MPAARatings.PG);
            LibraryItem m2 = new LibraryMovie("Star Wars", "LucasFilm", 1977, 7, "MM35 3D", 97.5,
                "George Lucas", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG);
            LibraryItem t1 = new LibraryMusic("Ten", "Epic", 1991, 14, "CD44 4Z", 53.2,
                "Pearl Jam", LibraryMediaItem.MediaType.CD, 11);
            LibraryItem t2 = new LibraryMusic("Born to Run", "columbia", 1975, 14,
                "CD46 4Z", 39.26, "Bruce Springsteen", LibraryMediaItem.MediaType.CD, 8);
            LibraryItem j1 = new LibraryJournal("IEEE Transactions on Pattern Analysis and Machine Intelligence",
                "IEEE", 2011, 14, "JJ12 7M", 1, 2, "Bioengineering Computing & Processing", "David A. Forsyth");
            LibraryItem j2 = new LibraryJournal("IEEE Transactions on Image Processing",
                "IEEE", 2011, 14, "JJ15 7M", 1, 2, "Image Processing", "Scott Acton");
            LibraryItem z1 = new LibraryMagazine("C# Monthly", "Unige Mags", 2010,
                14, "MA53 9A", 16, 9);
            LibraryItem z2 = new LibraryMagazine("C# Monthly", "Unige Mags", 2010,
                14, "MA57 9A", 19, 12);

            //items
            items.Add(b1); 
            items.Add(b2);
            items.Add(m1); 
            items.Add(m2); 
            items.Add(t1); 
            items.Add(t2); 
            items.Add(j1); 
            items.Add(j2); 
            items.Add(z1); 
            items.Add(z2);

            //patrons
            LibraryPatron p1 = new LibraryPatron("Pippo", "4w5wwt");
            LibraryPatron p2 = new LibraryPatron("Paperino", "eyeyhy");
            LibraryPatron p3 = new LibraryPatron("Pluto", "u5je5h");
            patrons.Add(p1);
            patrons.Add(p2);
            patrons.Add(p3);

            //checkout
            items[0].CheckOut(patrons[0]);
            items[2].CheckOut(patrons[1]);
            items[9].CheckOut(patrons[2]);
        }

        [TestMethod]
        public void TestEs09CheckedOutItems()
        {
            var checkedOutItems = from test in items
                                  where test.IsCheckedOut() == true
                                  select test;

            Assert.AreEqual(3, checkedOutItems.Count());
        }

        [TestMethod]
        public void TestEs09MediaItemsThatAreCheckedOut()
        {
            var checkedOutMediaItems = from test in items
                                       where test is LibraryMediaItem
                                       where test.IsCheckedOut() == true
                                       select test;

            Assert.AreEqual(1, checkedOutMediaItems.Count());
        }
        [TestMethod]
        public void TestEs09SelectTitlesOfLibraryMagazineObjects()
        {
            
            var magazine =  (from test in items
                            where test is LibraryMagazine
                            select test.Title).Distinct();

            Assert.AreEqual(1, magazine.Count());
        }

        [TestMethod]
        public void TestEs09CalculateLateFee()
        {
            decimal[] expectedFees = { 3.5M, 3.5M, 21M, 21M, 7M, 7M, 10.5M, 10.5M, 3.5M, 3.5M };

            List<decimal> actualFees = new List<decimal>();
            foreach (var element in items)
            {
                actualFees.Add(element.CalcLateFee(14));
            }
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(expectedFees[i], actualFees[i]);
            }
        }

        [TestMethod]
        public void TestEs09BooksThatAreInTheListAndTheirLoanPeriods()
        {
            var libraryBook = from test in items
                              where test is LibraryBook
                              select new { test.Title, test.LoanPeriod };

            Assert.AreEqual(2, libraryBook.Count());
            Assert.AreEqual("Multithreading with C# Cookbook - Second Edition", libraryBook.ElementAt(0).Title);
            Assert.AreEqual(14, libraryBook.ElementAt(0).LoanPeriod);
            Assert.AreEqual("Agile Software Development: Principles, Patterns, and Practices", libraryBook.ElementAt(1).Title);
            Assert.AreEqual(14, libraryBook.ElementAt(1).LoanPeriod);

        }
        [TestMethod]
        public void TestEs09AddDaysToLoanPeriods()
        {
            var testBooks = from test in items
                        where test is LibraryBook
                        select new { test.Title, LoanPeriod = test.LoanPeriod + 7 };

            Assert.AreEqual("Multithreading with C# Cookbook - Second Edition", testBooks.ElementAt(0).Title);
            Assert.AreEqual("Agile Software Development: Principles, Patterns, and Practices", testBooks.ElementAt(1).Title);
            Assert.AreEqual(21, testBooks.ElementAt(0).LoanPeriod);
            Assert.AreEqual(21, testBooks.ElementAt(1).LoanPeriod);
        }
    }
}
