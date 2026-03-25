using CompetitionTwo.Models;
using Microsoft.VisualBasic;
namespace CompetitionTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lib = new Library();

            var book1 = new Book("The Art of Data Strategy", "Liam Reynolds","ISBN111", 4);
            var book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            var book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

            lib.AddBook(book1);
            lib.AddBook(book2);
            lib.AddBook(book3);

            var student1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            var student2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);

            lib.AddPatron(student1);
            lib.AddPatron(student2);

            var staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");
            lib.AddPatron(staff1);

            Console.WriteLine("Books in Library:");
            lib.DisplayBooks();
            Console.WriteLine();
            Console.WriteLine("Patrons in Library:");
            lib.DisplayPatrons();
            Console.WriteLine();
            Console.WriteLine("Borrowing Books...");
            lib.Borrow("ISBN222", "S002");
            lib.Borrow("ISBN333", "S001");
            Console.WriteLine();
             Console.WriteLine("Books after Borrowing");
            lib.DisplayBooks();
            Console.WriteLine();
        }
    }
}
