using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_02
{
    public class Book
    {
        private string title = null;
        private string author = null;
        private string publisher = null;
        private string releaseDate = null;
        private string isbn = null;

        public Book(string title, string author, string publisher, string releaseDate, string isbn)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.releaseDate = releaseDate;
            this.isbn = isbn;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }
        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                this.author = value;
            }
        }
        public string Publisher
        {
            get
            {
                return this.publisher;
            }
            set
            {
                this.publisher = value;
            }
        }
        public string ReleaseDate
        {
            get
            {
                return this.releaseDate;
            }
            set
            {
                this.releaseDate = value;
            }
        }
        public string Isbn
        {
            get
            {
                return this.isbn;
            }
            set
            {
                this.isbn = value;
            }
        }

    }
}
