using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Products.Foods
{
    public class Food : Product
    {
        public Food()
        {
            Type = "Food";
        }

        public Food(string name, decimal price)
        {
            Type = "Food";
            Name = name;
            Price = price;
        }


    }
}
