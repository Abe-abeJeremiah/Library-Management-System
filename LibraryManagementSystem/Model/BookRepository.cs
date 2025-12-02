using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryManagementSystem.Model.LibraryFunction;

namespace LibraryManagementSystem.Model
{
    public class BookRepository : Books
    {
        private List<Books> bookCollection = new List<Books>();
        public void AddBook(Books book)
        {
            bookCollection.Add(book);
        }
        public List<Books> GetAllBooks()
        {
            return bookCollection;
        }
        public Books FindByISBN(string isbn)
        {
            return bookCollection.FirstOrDefault(b => b.ISBN == isbn);
        }
    }

}
