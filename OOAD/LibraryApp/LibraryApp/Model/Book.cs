using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Model
{
    class Book
    {
        private int book_id;
        private string bookName;
        private string authorName;

        public Book(int book_id, string bookName, string authorName)
        {
            this.book_id = book_id;
            this.bookName = bookName;
            this.authorName = authorName;
        }

        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }


        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }


        public int BookID
        {
            get { return book_id; }
            set { book_id = value; }
        }

    }
}
