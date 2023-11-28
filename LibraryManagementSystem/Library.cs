using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        public List<Book> books=new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ViewAllBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in library");
            }
            else
            {
                Console.WriteLine("List of the books ");
                foreach (var book in books)
                {
                    Console.WriteLine($"Id:{book.BookId},Title:{book.Title},Genre:{book.Genre},Isavailable:{book.IsAvailable}");
                }
            }
        }

        public void SearchBookById(int bookId)
        {
            Book foundBook = books.Find(book => book.BookId == bookId);
            if (foundBook != null)
            {
                Console.WriteLine($"Book found - ID: {foundBook.BookId}, Title: {foundBook.Title}, Author: {foundBook.Author}, Genre: {foundBook.Genre}, Available: {(foundBook.IsAvailable ? "Yes" : "No")}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void SearchBookByTitle(string title)
        {
            Book foundBook = books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (foundBook != null)
            {
                Console.WriteLine($"Book found - ID: {foundBook.BookId}, Title: {foundBook.Title}, Author: {foundBook.Author}, Genre: {foundBook.Genre}, Available: {(foundBook.IsAvailable ? "Yes" : "No")}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}
