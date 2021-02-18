using System.Collections.Generic;

namespace LibraryApp.Model
{
    class Library
    {
        private string name;
        private string address;
        private List<Book> books;

        public Library(string name, string address, List<Book> books)
        {
            this.name = name;
            this.address = address;
            this.books = books;
        }

        public List<Book> GetBooks
        {
            get { return books; }
            set { books = value; }
        }


        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public string LibraryName
        {
            get { return name; }
            set { name = value; }
        }

    }
}
