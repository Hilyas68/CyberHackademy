using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.ClassAndObject
{
    class Book
    {
        private string _title;
        private string _author;
        private string _isbn;

        public Book(string title, string author, string isbn)
        {
            _title = title;
            _author = author;
            _isbn = isbn;
        }

        public override string ToString()
        {
            return $"Currently reading a book titled {_title} by {_author} with ISBN {_isbn}";
        }
        
    }
}
