using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionTwo.Models
{
    internal class Book(string title, string author, string isbn, int availableCopies)
    {
        public string Title { set; get; } = title;
        public string Author { set; get; } = author;
        public string ISBN { set; get; } = isbn;
        public int AvailableCopies { set; get; } = availableCopies;

        public bool BorrowBook()
        {
            if (AvailableCopies > 0) AvailableCopies--;
            else return false;
            return true;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Available Copies: {AvailableCopies}";
        }
        // 
    }
}
