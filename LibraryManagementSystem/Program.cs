using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Program
    {
        public static int op;

        static void Main(string[] args)
        {
            Library library = new Library();
            int choice;

            do
            {
                Console.WriteLine("\n******Welcome To Library Management System********");
                Console.Write("\nEnter your choice: ");
                Console.WriteLine("1. Add a Book 2.View All Books 3.Search By Id 4.Search By Title");
                int op=int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Write("Enter Book ID: ");
                        int bookId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();
                        Console.Write("Is Available? TRUE//FALSE: ");
                        bool isAvailable = bool.Parse(Console.ReadLine());
                        Book Details = new Book
                        {
                            BookId = bookId,
                            Title = title,
                            Author = author,
                            Genre = genre,
                            IsAvailable = isAvailable
                        };

                        library.AddBook(Details);
                        Console.WriteLine("Book added successfully!");
                        break;
                    case 2:
                        library.ViewAllBooks();
                        break;
                    case 3:
                        Console.Write("Enter Book ID to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        library.SearchBookById(searchId);
                        break;
                    case 4:
                        Console.Write("Enter Title to search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchBookByTitle(searchTitle);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            } while (op != 5);
            Console.WriteLine("Exiting Library Management System. Goodbye!");
            Console.ReadKey();
        }
    }
}
