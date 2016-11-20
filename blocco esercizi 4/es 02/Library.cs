using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_02
{
    public class Library
    {
        private string nameLibrary = null;
        private List<Book> bookList;

        public Library(string nameLibrary) //costruttore
        {
            this.nameLibrary = nameLibrary;
            this.bookList = new List<Book>();
        }

        public string NameLibrary
        {
            get
            {
                return this.nameLibrary;
            }
            set
            {
                this.nameLibrary = value;
            }
        }
        public List<Book> BookList
        {
            get
            {
                return this.bookList;
            }
            set
            {
                this.bookList = value;
            }
        }

        public bool AddBook(Book newBook) //metodo per aggiungere un libro
        {
            BookList.Add(newBook);
            return true;
        }
        public List<Book> SearchAuthor(string authorName) //metodo per trovare i libri di un autore
        {
            List<Book> bookAuthor = null; ; //lista libri di un autore
            foreach (Book book in bookList)
            {
                if (book.Author.Equals(authorName))
                {
                    bookAuthor.Add(book);
                }
            }
            return bookAuthor;
        }
        public Book SearchTitle(string bookTitle) 
        {
            foreach(Book book in bookList)
            {
                if(book.Title.Equals(bookTitle))
                {
                    return book;
                }
            }
            return null;
        }
        public string[] DisplayInformation (string bookTitle) //parametri del libro
        {
            Book bookTitleFounded = SearchTitle(bookTitle);
            string[] parameters = new string[5];

            parameters[0] = bookTitleFounded.Title;
            parameters[1] = bookTitleFounded.Author;
            parameters[2] = bookTitleFounded.Publisher;
            parameters[3] = bookTitleFounded.ReleaseDate;
            parameters[4] = bookTitleFounded.Isbn;

            return parameters;
        }
        public bool DeleteBooksOfAuthor(string authorName)
        {
            foreach (Book book in bookList)
            {
                if (book.Author.Equals(authorName))
                {
                    BookList.Remove(book);
                }
            }
            return true;
        }
        public bool DeleteSingleBook(string bookTitle)
        {
            foreach (Book book in bookList)
            {
                if (book.Title.Equals(bookTitle))
                {
                    BookList.Remove(book);
                }
            }
            return true;
        }

    }
}
