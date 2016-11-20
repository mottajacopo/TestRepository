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
            bool condition = false;
            List<Book> listBooksAuthor = new List<Book>(); //lista libri di un autore
            foreach (Book book in bookList)
            {
                if (book.Author.Equals(authorName))
                {
                    listBooksAuthor.Add(book);
                    condition = true;
                }
            }
            if(condition == false) //se non ci sono libri di quell'autore
            {
                return null;
            }
            else
            {
                return listBooksAuthor; //ritorna la lista dei libri dell'autore
            }
            
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
            int booksDeleted = bookList.RemoveAll(genericBook => genericBook.Author.Equals(authorName));
            if (booksDeleted != 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteSingleBook(string bookTitle)
        {
            int booksDeleted = bookList.RemoveAll(genericBook => genericBook.Title.Equals(bookTitle));
            if (booksDeleted != 0)
            {
                return true;
            }
            return false;
        }

    }
}
