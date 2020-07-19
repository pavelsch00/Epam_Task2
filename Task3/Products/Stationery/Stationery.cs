using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Products.Stationery
{
    public class Stationery : Product
    {
        public Stationery()
        {
            Type = "Stationery";
        }

        public Stationery(string name, decimal price)
        {
            Type = "Stationery";
            Name = name;
            Price = price;
        }
    }
}
