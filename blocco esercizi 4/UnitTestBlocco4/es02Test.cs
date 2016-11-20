using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_02;

namespace UnitTestBlocco4
{
    [TestClass]
    public class TestLibrary
    {
        private Library libraryForTest = null;

        [TestInitialize]
        public void InizializationOfBooks()
        {
            libraryForTest = new Library("Libreria per il test");
            libraryForTest.AddBook(new Book("It", "Stephen King", "Viking", "Settembre 1986", "0-670-81302-8"));
            libraryForTest.AddBook(new Book("Il miglio verde", "Stephen King", "Signet Books", "Settembre 1996", "978-0451190499"));
            libraryForTest.AddBook(new Book("Cujo", "Stephen King", "Viking", "Settembre 1982", "978-0-670-45193-7"));
            libraryForTest.AddBook(new Book("Robinson Crusoe", "Daniel Defoe", " Bickers and Bush", "Aprile 1719", "978-53-22-027763-8"));
            libraryForTest.AddBook(new Book("Il signore degli anelli", "J.R.R. Tolkien", "Bompiani", "Ottobre 2000", "978-88-452-9005-0"));
            libraryForTest.AddBook(new Book("Il codice Da Vinci", "Dan Brown", "Mondadori Editore", "Marzo 2004", "88-04-52341-7"));
        }

        [TestMethod]
        public void TestSearchAuthor()
        {
            List<Book> foundBooks = libraryForTest.SearchAuthor("Stephen King");
            Assert.AreEqual(3, foundBooks.Count); //controllo numero di libri trovati
            Assert.AreEqual("It", foundBooks[0].Title); //controllo il titolo dei libri trovati
            Assert.AreEqual("Il miglio verde", foundBooks[1].Title);
            Assert.AreEqual("Cujo", foundBooks[2].Title);
        }
        [TestMethod]
        public void DisplayInformationOfBook1()
        {
            string[] parameters = libraryForTest.DisplayInformation("Il codice Da Vinci");
            Assert.AreEqual("Il codice Da Vinci", parameters[0]);
            Assert.AreEqual("Dan Brown", parameters[1]);
            Assert.AreEqual("Mondadori Editore", parameters[2]);
            Assert.AreEqual("Marzo 2004", parameters[3]);
            Assert.AreEqual("88-04-52341-7", parameters[4]);
        }
        [TestMethod]
        public void DisplayInformationOfBook2()
        {
            string[] parameters = libraryForTest.DisplayInformation("Il signore degli anelli");
            Assert.AreEqual("Il signore degli anelli", parameters[0]);
            Assert.AreEqual("J.R.R. Tolkien", parameters[1]);
            Assert.AreEqual("Bompiani", parameters[2]);
            Assert.AreEqual("Ottobre 2000", parameters[3]);
            Assert.AreEqual("978-88-452-9005-0", parameters[4]);
        }
        [TestMethod]
        public void TestSearchTitleFounded()
        {
            Book searchedTitle = libraryForTest.SearchTitle("Il miglio verde");
            Assert.AreEqual("Il miglio verde", searchedTitle.Title);
        }
        [TestMethod]
        public void TestSearchTitleNotFounded()
        {
            Book searchedTitle = libraryForTest.SearchTitle("Il milio verde");
            Assert.AreEqual(null, searchedTitle);
        }
        
        [TestMethod]
        public void DeleteBooksOfAuthors()
        {
            bool delete = libraryForTest.DeleteBooksOfAuthor("Stephen King");
            Assert.AreEqual(true, delete);
            Book searchedBookDeleted1 = libraryForTest.SearchTitle("Cujo");
            Assert.AreEqual(null, searchedBookDeleted1);
            Book searchedBookDeleted2 = libraryForTest.SearchTitle("Il miglio verde");
            Assert.AreEqual(null, searchedBookDeleted2);
            Book searchedBookDeleted3 = libraryForTest.SearchTitle("It");
            Assert.AreEqual(null, searchedBookDeleted3);
        }

        [TestMethod]
        public void DeleteSingleBook()
        {
            bool delete = libraryForTest.DeleteSingleBook("Robinson Crusoe");
            Assert.AreEqual(true, delete);
            Book searchedBookDeleted = libraryForTest.SearchTitle("Robinson Crusoe");
            Assert.AreEqual(null, searchedBookDeleted);
        }

    }
}

