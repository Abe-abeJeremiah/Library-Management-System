using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    // Book class
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; }
    }

    // Library class
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully!");
        }

        public void ViewBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Status: {(book.IsBorrowed ? "Borrowed" : "Available")}");
            }
        }

        public void BorrowBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
            }
            else if (book.IsBorrowed)
            {
                Console.WriteLine("Book is already borrowed.");
            }
            else
            {
                book.IsBorrowed = true;
                Console.WriteLine("Book borrowed successfully.");
            }
        }

        public void ReturnBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
            }
            else if (!book.IsBorrowed)
            {
                Console.WriteLine("Book was not borrowed.");
            }
            else
            {
                book.IsBorrowed = false;
                Console.WriteLine("Book returned successfully.");
            }
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== Library Management System ===");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View Books");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Enter Book ID: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();

                        library.AddBook(new Book { Id = id, Title = title, Author = author, IsBorrowed = false });
                        break;

                    case "2":
                        library.ViewBooks();
                        break;

                    case "3":
                        Console.Write("Enter Book ID to borrow: ");
                        library.BorrowBook(int.Parse(Console.ReadLine()));
                        break;

                    case "4":
                        Console.Write("Enter Book ID to return: ");
                        library.ReturnBook(int.Parse(Console.ReadLine()));
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting system...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
