using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Products.Technics
{
    public class Technics : Product
    {
        public Technics()
        {
            Type = "Technics";
        }

        public Technics(string name, decimal price)
        {
            Type = "Technics";
            Name = name;
            Price = price;
        }

    }
}
