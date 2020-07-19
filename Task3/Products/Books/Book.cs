using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Products.Books
{
    public class Book : Product
    {
        public Book()
        {
            Type = "Book";
        }

        public Book(string name, decimal price)
        {
            Type = "Book";
            Name = name;
            Price = price;
        }
    }
}
