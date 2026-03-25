using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionTwo.Models
{
    internal class Library
    {
        private List<Book> books;
        private List<Person> patrons;

        public Library()
        {
            books = [];
            patrons = [];
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddPatron(Person person)
        {
            patrons.Add(person);
        }

        public Book? FindBook(string isbn)
        {
            return books.Find(b => b.ISBN.Equals(isbn));
        }

        public Person? FindPerson(string id)
        {
            return patrons.Find(p => p.ID.Equals(id));
        }

        public void DisplayBooks()
        {
            foreach(var book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void DisplayPatrons()
        {
            foreach(var patron in patrons)
            {
                Console.WriteLine(patron);
            }
        }

        public bool Borrow(string ISBN, string personID)
        {
            Book? book = FindBook(ISBN);
            Person? patron = FindPerson(personID);
            if(book == null)
            {
                Console.WriteLine("Couldn't find the Book");
                return false;
            }
            if(patron == null)
            {
                Console.WriteLine("Couldn't find the Person");
                return false;
            }

            bool res = book.BorrowBook();
            if (res)
            {
                Console.WriteLine($"{patron.Name} borrowed {book.Title}");
            }
            return res;
        }

    }
}
/* This class manages the library system including books and patrons,
and provides functionality for adding, searching, and borrowing books. */
