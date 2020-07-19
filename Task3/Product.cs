using System;

namespace Task3
{
    public class Product : IProduct
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
